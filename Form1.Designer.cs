namespace WinFormsApp2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KakaoTalk_20260220_145110712;
            pictureBox1.Location = new Point(35, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(467, 32);
            label1.Name = "label1";
            label1.Size = new Size(168, 62);
            label1.TabIndex = 1;
            label1.Text = "강현우";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(435, 142);
            label2.Name = "label2";
            label2.Size = new Size(228, 38);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터 sw 2학년";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(388, 225);
            label3.Name = "label3";
            label3.Size = new Size(367, 38);
            label3.TabIndex = 3;
            label3.Text = "hyenwoo1207@gmail.com";
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(560, 335);
            button1.Name = "button1";
            button1.Size = new Size(228, 72);
            button1.TabIndex = 4;
            button1.Text = "배경 변경 버튼";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(354, 335);
            button2.Name = "button2";
            button2.Size = new Size(200, 72);
            button2.TabIndex = 5;
            button2.Text = "github";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(107, 335);
            button3.Name = "button3";
            button3.Size = new Size(172, 72);
            button3.TabIndex = 6;
            button3.Text = "이미지 변경";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
