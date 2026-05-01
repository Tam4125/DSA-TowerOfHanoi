namespace TowerOfHanoi
{
    partial class InteractiveForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InteractiveForm));
            groupBox1 = new GroupBox();
            picCanvas = new PictureBox();
            groupBox3 = new GroupBox();
            txtLog = new RichTextBox();
            label2 = new Label();
            btnUndo = new Button();
            imageList2 = new ImageList(components);
            btnBack = new Button();
            groupBox2 = new GroupBox();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picCanvas);
            groupBox1.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(90, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1941, 650);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Graphic Zone";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(216, 132);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1636, 467);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtLog);
            groupBox3.Location = new Point(699, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1198, 535);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log Zone";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(50, 79);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(1106, 403);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 2;
            // 
            // btnUndo
            // 
            btnUndo.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnUndo.ImageIndex = 1;
            btnUndo.ImageList = imageList2;
            btnUndo.Location = new Point(27, 130);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(484, 101);
            btnUndo.TabIndex = 3;
            btnUndo.Text = "Undo Move";
            btnUndo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "left-arrow.png");
            imageList2.Images.SetKeyName(1, "undo.png");
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBack.ImageIndex = 0;
            btnBack.ImageList = imageList2;
            btnBack.Location = new Point(27, 266);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(484, 181);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back to Auto-Solver";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(btnUndo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Roboto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(90, 745);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1941, 646);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controller";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "left-arrow.png");
            imageList1.Images.SetKeyName(1, "undo.png");
            // 
            // InteractiveForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2139, 1390);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "InteractiveForm";
            Text = "Interactive Mode";
            Load += InteractiveForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private PictureBox picCanvas;
        private GroupBox groupBox3;
        private RichTextBox txtLog;
        private Label label2;
        private Button btnUndo;
        private Button btnBack;
        private GroupBox groupBox2;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}