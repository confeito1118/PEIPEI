namespace PEIPEI
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
            qfile1 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // qfile1
            // 
            qfile1.Location = new Point(41, 34);
            qfile1.Name = "qfile1";
            qfile1.Size = new Size(180, 70);
            qfile1.TabIndex = 0;
            qfile1.Text = "共有フォルダ\r\n(192.168.100.250)";
            qfile1.UseVisualStyleBackColor = true;
            qfile1.Click += qfile1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(243, 34);
            button1.Name = "button1";
            button1.Size = new Size(180, 70);
            button1.TabIndex = 1;
            button1.Text = "共有フォルダ\r\n（\\\\NAS303F9E）";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(qfile1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button qfile1;
        private Button button1;
    }
}
