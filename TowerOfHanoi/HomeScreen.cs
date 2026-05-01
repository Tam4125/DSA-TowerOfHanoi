using System;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            this.Text = "Tower of Hanoi - Main Menu";
            this.StartPosition = FormStartPosition.CenterScreen; // Opens right in the middle of the screen!

            // Wire up the buttons
            btnAutoSolver.Click += BtnAutoSolver_Click;
        }

        private void BtnAutoSolver_Click(object sender, EventArgs e)
        {
            Form1 autoSolver = new Form1(this); // Pass the HomeForm so we can return to it
            autoSolver.Show();
            this.Hide();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}