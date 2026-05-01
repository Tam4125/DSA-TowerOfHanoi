namespace TowerOfHanoi
{
    partial class AutoSolver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoSolver));
            groupBox1 = new GroupBox();
            lblStep = new Label();
            picCanvas = new PictureBox();
            lblTime = new Label();
            groupBox2 = new GroupBox();
            btnToInteractiveMode = new Button();
            btnStop = new Button();
            imageList3 = new ImageList(components);
            btnStart = new Button();
            label2 = new Label();
            numDisks = new NumericUpDown();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            txtLog = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDisks).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStep);
            groupBox1.Controls.Add(picCanvas);
            groupBox1.Controls.Add(lblTime);
            groupBox1.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(32, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1941, 651);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graphic Zone";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblStep
            // 
            lblStep.AutoSize = true;
            lblStep.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblStep.Location = new Point(27, 132);
            lblStep.Name = "lblStep";
            lblStep.Size = new Size(82, 37);
            lblStep.TabIndex = 2;
            lblStep.Text = "Step";
            lblStep.Click += label3_Click;
            // 
            // picCanvas
            // 
            picCanvas.BackgroundImageLayout = ImageLayout.None;
            picCanvas.Location = new Point(216, 132);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1636, 467);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTime.Location = new Point(27, 66);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(88, 37);
            lblTime.TabIndex = 0;
            lblTime.Tag = "";
            lblTime.Text = "Time";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnToInteractiveMode);
            groupBox2.Controls.Add(btnStop);
            groupBox2.Controls.Add(btnStart);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numDisks);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(32, 789);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1941, 646);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control Zone";
            // 
            // btnToInteractiveMode
            // 
            btnToInteractiveMode.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnToInteractiveMode.ForeColor = Color.Green;
            btnToInteractiveMode.ImageIndex = 1;
            btnToInteractiveMode.Location = new Point(27, 358);
            btnToInteractiveMode.Name = "btnToInteractiveMode";
            btnToInteractiveMode.Size = new Size(484, 193);
            btnToInteractiveMode.TabIndex = 5;
            btnToInteractiveMode.Text = "Interactive Mode";
            btnToInteractiveMode.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnToInteractiveMode.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnStop.ImageIndex = 3;
            btnStop.ImageList = imageList3;
            btnStop.Location = new Point(27, 266);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(484, 58);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += button2_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "bin.png");
            imageList3.Images.SetKeyName(1, "interactivity.png");
            imageList3.Images.SetKeyName(2, "left-arrow.png");
            imageList3.Images.SetKeyName(3, "stop.png");
            imageList3.Images.SetKeyName(4, "undo.png");
            imageList3.Images.SetKeyName(5, "upload.png");
            imageList3.Images.SetKeyName(6, "video.png");
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnStart.ImageIndex = 6;
            btnStart.ImageList = imageList3;
            btnStart.Location = new Point(27, 173);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(484, 58);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(252, 37);
            label2.TabIndex = 2;
            label2.Text = "Number of Disks";
            label2.Click += label2_Click;
            // 
            // numDisks
            // 
            numDisks.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            numDisks.Location = new Point(352, 80);
            numDisks.Name = "numDisks";
            numDisks.Size = new Size(159, 44);
            numDisks.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(txtLog);
            groupBox3.Location = new Point(699, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1198, 535);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log Zone";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button4
            // 
            button4.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button4.ImageIndex = 5;
            button4.ImageList = imageList3;
            button4.Location = new Point(610, 413);
            button4.Name = "button4";
            button4.Size = new Size(484, 58);
            button4.TabIndex = 6;
            button4.Text = "Export Log";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button3.ImageIndex = 0;
            button3.ImageList = imageList3;
            button3.Location = new Point(50, 413);
            button3.Name = "button3";
            button3.Size = new Size(484, 58);
            button3.TabIndex = 5;
            button3.Text = "Delete Log";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtLog
            // 
            txtLog.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtLog.Location = new Point(50, 79);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(1106, 237);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            txtLog.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2140, 1471);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Auto-solver Mode";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDisks).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblTime;
        private Label label2;
        private NumericUpDown numDisks;
        private Button btnStop;
        private Button btnStart;
        private Button button3;
        private RichTextBox txtLog;
        private Button button4;
        private Label lblStep;
        private PictureBox picCanvas;
        private Button btnToInteractiveMode;
        private ImageList imageList3;
    }
}
