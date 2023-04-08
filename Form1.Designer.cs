namespace Paint
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UploadButton = new System.Windows.Forms.Button();
            this.TextButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorDisplay = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.ElipseButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.UploadButton);
            this.panel1.Controls.Add(this.TextButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.ColorDisplay);
            this.panel1.Controls.Add(this.ColorButton);
            this.panel1.Controls.Add(this.LineButton);
            this.panel1.Controls.Add(this.RectangleButton);
            this.panel1.Controls.Add(this.ElipseButton);
            this.panel1.Controls.Add(this.EraserButton);
            this.panel1.Controls.Add(this.PenButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 73);
            this.panel1.TabIndex = 1;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(721, 13);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(70, 47);
            this.UploadButton.TabIndex = 10;
            this.UploadButton.Text = "upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Location = new System.Drawing.Point(569, 13);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(70, 47);
            this.TextButton.TabIndex = 9;
            this.TextButton.Text = "text";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(645, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 47);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(493, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(70, 47);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.Location = new System.Drawing.Point(14, 13);
            this.ColorDisplay.Name = "ColorDisplay";
            this.ColorDisplay.Size = new System.Drawing.Size(57, 47);
            this.ColorDisplay.TabIndex = 6;
            this.ColorDisplay.UseVisualStyleBackColor = true;
            this.ColorDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorDisplay_Paint);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(77, 13);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(57, 47);
            this.ColorButton.TabIndex = 5;
            this.ColorButton.Text = "color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(417, 13);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(70, 47);
            this.LineButton.TabIndex = 4;
            this.LineButton.Text = "line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(341, 13);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(70, 47);
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.Text = "rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // ElipseButton
            // 
            this.ElipseButton.Location = new System.Drawing.Point(272, 13);
            this.ElipseButton.Name = "ElipseButton";
            this.ElipseButton.Size = new System.Drawing.Size(63, 47);
            this.ElipseButton.TabIndex = 2;
            this.ElipseButton.Text = "elipse";
            this.ElipseButton.UseVisualStyleBackColor = true;
            this.ElipseButton.Click += new System.EventHandler(this.ElipseButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Location = new System.Drawing.Point(203, 13);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(63, 47);
            this.EraserButton.TabIndex = 1;
            this.EraserButton.Text = "eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.Location = new System.Drawing.Point(140, 13);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(57, 47);
            this.PenButton.TabIndex = 0;
            this.PenButton.Text = "pen";
            this.PenButton.UseVisualStyleBackColor = true;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button PenButton;
        private Button EraserButton;
        private Button ElipseButton;
        private Button RectangleButton;
        private Button LineButton;
        private Button ColorButton;
        private Button ColorDisplay;
        private Button ClearButton;
        private Button SaveButton;
        private Button TextButton;
        private Button UploadButton;
    }
}