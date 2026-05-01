namespace TowerOfHanoi
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAutoSolver = new Button();
            SuspendLayout();
            // 
            // btnAutoSolver
            // 
            btnAutoSolver.BackColor = Color.FromArgb(40, 255, 255, 255);
            btnAutoSolver.FlatStyle = FlatStyle.Flat;
            btnAutoSolver.Font = new Font("Roboto", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAutoSolver.ForeColor = Color.White;
            btnAutoSolver.Location = new Point(1562, 1271);
            btnAutoSolver.Name = "btnAutoSolver";
            btnAutoSolver.Size = new Size(552, 100);
            btnAutoSolver.TabIndex = 0;
            btnAutoSolver.Text = "Continue";
            btnAutoSolver.UseVisualStyleBackColor = false;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu_screen_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2149, 1410);
            Controls.Add(btnAutoSolver);
            DoubleBuffered = true;
            Name = "HomeScreen";
            Text = "Home Screen";
            Load += HomeScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAutoSolver;
    }
}