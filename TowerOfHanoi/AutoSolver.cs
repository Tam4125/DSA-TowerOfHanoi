using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TowerOfHanoi.Algorithms;
using TowerOfHanoi.UI;

namespace TowerOfHanoi
{
    public partial class Form1 : Form
    {
        private HanoiEngine gameEngine;
        private CancellationTokenSource cts;
        private System.Windows.Forms.Timer solveTimer;
        private Stopwatch stopwatch;

        private Form homeFormParent;

        private bool isGameWon = false;

        public Form1(Form homeParent)
        {
            InitializeComponent();
            this.homeFormParent = homeParent;

            // Initialize the Engine and subscribe to its events
            gameEngine = new HanoiEngine();
            gameEngine.OnMoveCompleted += Engine_OnMoveCompleted;
            gameEngine.OnStateChanged += () => picCanvas.Invalidate();

            btnStart.Click += BtnStart_Click;
            btnStop.Click += BtnStop_Click;
            btnToInteractiveMode.Click += btnToInteractiveMode_Click;
            picCanvas.Paint += picCanvas_Paint;
            numDisks.ValueChanged += numDisks_ValueChanged;

            stopwatch = new Stopwatch();
            solveTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            solveTimer.Tick += SolveTimer_Tick;

            numDisks.Minimum = 3;
            numDisks.Maximum = 10;
            numDisks.Value = 3;



            ResetGameUI();
        }

        private void ResetGameUI()
        {
            isGameWon = false;

            gameEngine.InitializeGame((int)numDisks.Value);
            lblStep.Text = "Step: 0";
            lblTime.Text = "Time: 00:00:00";

            solveTimer.Stop();
            stopwatch.Reset();

            txtLog.Clear();
            txtLog.AppendText("Initialized all request components.\nWaiting for command...\n");
            picCanvas.Invalidate();
        }

        // --- Event Handlers from Engine ---
        private void Engine_OnMoveCompleted(string logMessage)
        {
            lblStep.Text = $"Step: {gameEngine.StepCount}";
            txtLog.AppendText(logMessage);
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        // --- UI Interactions ---
        private void numDisks_ValueChanged(object sender, EventArgs e)
        {
            if (btnStart.Enabled) ResetGameUI();
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            ResetGameUI();
            btnStart.Enabled = false;
            numDisks.Enabled = false;

            cts = new CancellationTokenSource();
            stopwatch.Start();
            solveTimer.Start();

            try
            {
                await gameEngine.SolveAsync((int)numDisks.Value, cts.Token);
                txtLog.AppendText("Solved successfully!\n");

                isGameWon = true;
                picCanvas.Invalidate();
            }
            catch (OperationCanceledException)
            {
                txtLog.AppendText("\n--- Solve stopped by user. ---\n");
            }
            finally
            {
                btnStart.Enabled = true;
                numDisks.Enabled = true;
                stopwatch.Stop();
                solveTimer.Stop();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e) => cts?.Cancel();

        private void SolveTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = $"Time: {stopwatch.Elapsed:hh\\:mm\\:ss}";
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Call the Renderer and pass it the Engine's data
            HanoiRenderer.DrawGame(
                e.Graphics,
                picCanvas.Width,
                picCanvas.Height,
                gameEngine.TowerA,
                gameEngine.TowerB,
                gameEngine.TowerC
            );

            if (isGameWon)
            {
                // Wash out the background so the text pops
                Rectangle fullScreen = new Rectangle(0, 0, picCanvas.Width, picCanvas.Height);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 255, 255, 255)), fullScreen);

                // Draw giant "SOLVED!" text in the center
                using (Font winFont = new Font("Comic Sans MS", 48, FontStyle.Bold))
                using (StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics.DrawString("PUZZLE SOLVED!", winFont, Brushes.ForestGreen, fullScreen, format);
                }
            }
        }

        // --- Log Buttons ---
        private void button3_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            txtLog.AppendText("Log cleared.\nWaiting for command...\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Files (*.txt)|*.txt", FileName = "HanoiLog.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtLog.Text);
                    MessageBox.Show("Log exported successfully!", "Export Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnToInteractiveMode_Click(object sender, EventArgs e)
        {
            InteractiveForm interactiveScreen = new InteractiveForm(this);
            interactiveScreen.Show();
            this.Hide(); // Hide the auto-solver while playing manually
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            homeFormParent.Show();
            base.OnFormClosed(e);
        }

        // Empty events left by designer
        private void Form1_Load(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void picCanvas_Click(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}