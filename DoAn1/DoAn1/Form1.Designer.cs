namespace DoAn1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.userControl31 = new DoAn1.UserControl3();
            this.userControl21 = new DoAn1.UserControl2();
            this.userControl11 = new DoAn1.UserControl1();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(39, 391);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 35);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Open";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 360);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(154, 391);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(82, 35);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Draw";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(464, 154);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(85, 47);
            this.userControl31.TabIndex = 9;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(463, 83);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(86, 47);
            this.userControl21.TabIndex = 8;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(463, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(86, 46);
            this.userControl11.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button btn2;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
    }
}

