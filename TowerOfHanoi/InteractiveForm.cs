using System;
using System.Drawing;
using System.Windows.Forms;
using TowerOfHanoi.Algorithms;
using TowerOfHanoi.Models;
using TowerOfHanoi.UI;

namespace TowerOfHanoi
{
    public partial class InteractiveForm : Form
    {
        private InteractiveEngine gameEngine;
        private AutoSolver parentForm;
        private Tower selectedTower = null;

        private Form homeFormParent;

        // NEW: Game State Tracker
        private bool isGameWon = false;

        public InteractiveForm(Form homeParent)
        {
            InitializeComponent();
            this.homeFormParent = homeParent;

            gameEngine = new InteractiveEngine();
            gameEngine.OnLogUpdated += Engine_OnLogUpdated;

            picCanvas.Paint += picCanvas_Paint;
            picCanvas.MouseClick += picCanvas_MouseClick;
            btnUndo.Click += BtnUndo_Click;
            btnBack.Click += BtnBack_Click;

            gameEngine.InitializeGame(3);
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            // If the game is won, do not allow any more clicking!
            if (isGameWon) return;

            int thirdOfCanvas = picCanvas.Width / 3;
            Tower clickedTower = null;

            if (e.X < thirdOfCanvas) clickedTower = gameEngine.TowerA;
            else if (e.X < thirdOfCanvas * 2) clickedTower = gameEngine.TowerB;
            else clickedTower = gameEngine.TowerC;

            if (selectedTower == null)
            {
                // First click: Select the source rod
                if (!clickedTower.GetStack().IsEmpty())
                {
                    selectedTower = clickedTower;
                    txtLog.AppendText($"Selected {selectedTower.GetName()}...\n");

                    // ---> THE FIX: Force the screen to redraw immediately to show the highlight! <---
                    picCanvas.Invalidate();
                }
            }
            else
            {
                // If the user clicks the exact same rod again, cancel the selection
                if (selectedTower == clickedTower)
                {
                    selectedTower = null;
                    txtLog.AppendText("Selection canceled.\n");
                }
                else
                {
                    // Second click: Select destination and attempt move
                    bool moveSuccessful = gameEngine.TryMoveDisk(selectedTower, clickedTower);
                    selectedTower = null;

                    // Check Win Condition immediately after moving
                    if (moveSuccessful && gameEngine.IsSolved())
                    {
                        isGameWon = true;
                        btnUndo.Enabled = false; // Disable Undo button

                        txtLog.AppendText("\n=========================================\n");
                        txtLog.AppendText("🎉 PROBLEM SOLVED SUCCESSFULLY! 🎉\n");
                        txtLog.AppendText("Interactive mode locked. Please go back to Auto-Solver.\n");
                        txtLog.AppendText("=========================================\n");
                    }
                }

                // Redraw screen after attempting a move or canceling
                picCanvas.Invalidate();
            }
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            gameEngine.UndoLastMove();
            selectedTower = null;
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            HanoiRenderer.DrawGame(
                e.Graphics,
                picCanvas.Width,
                picCanvas.Height,
                gameEngine.TowerA,
                gameEngine.TowerB,
                gameEngine.TowerC
            );

            // --- BETTER VISUAL HIGHLIGHT ---
            if (selectedTower != null && !isGameWon)
            {
                int rodIndex = selectedTower.GetName() == "Rod A" ? 0 : selectedTower.GetName() == "Rod B" ? 1 : 2;
                int xCenter = (picCanvas.Width / 4) * (rodIndex == 0 ? 1 : rodIndex == 1 ? 2 : 3);

                // 1. Draw a soft glowing column behind the rod
                int highlightWidth = 140;
                int highlightHeight = picCanvas.Height - 60;
                Rectangle highlightRect = new Rectangle(xCenter - (highlightWidth / 2), picCanvas.Height - highlightHeight - 40, highlightWidth, highlightHeight);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 255, 255, 0)), highlightRect);

                // 2. Draw a bouncing Yellow Arrow pointing down at the rod
                using (Font arrowFont = new Font("Arial", 28, FontStyle.Bold))
                {
                    e.Graphics.DrawString("▼", arrowFont, Brushes.Yellow, xCenter - 18, picCanvas.Height - highlightHeight - 80);
                }
            }

            // --- NEW: WIN OVERLAY SCREEN ---
            if (isGameWon)
            {
                // Wash out the background so the text pops
                Rectangle fullScreen = new Rectangle(0, 0, picCanvas.Width, picCanvas.Height);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 255, 255, 255)), fullScreen);

                // Draw giant "SOLVED!" text in the center
                using (Font winFont = new Font("Comic Sans MS", 48, FontStyle.Bold))
                using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics.DrawString("PROBLEM SOLVED!", winFont, Brushes.ForestGreen, fullScreen, format);
                }
            }
        }

        private void Engine_OnLogUpdated(string msg)
        {
            txtLog.AppendText(msg);
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Let the OnFormClosed event handle the navigation!
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            homeFormParent.Show();
            base.OnFormClosed(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void InteractiveForm_Load(object sender, EventArgs e)
        {

        }
    }
}