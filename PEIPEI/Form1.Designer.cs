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
            doui = new Button();
            button1 = new Button();
            mail = new Button();
            kuruma = new Button();
            menuStrip1 = new MenuStrip();
            ホームhToolStripMenuItem = new ToolStripMenuItem();
            車両関係cToolStripMenuItem = new ToolStripMenuItem();
            test = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // doui
            // 
            doui.Location = new Point(50, 64);
            doui.Name = "doui";
            doui.Size = new Size(180, 70);
            doui.TabIndex = 0;
            doui.Text = "共有フォルダ\r\n(192.168.100.250)";
            doui.UseVisualStyleBackColor = true;
            doui.Click += qfile1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(236, 64);
            button1.Name = "button1";
            button1.Size = new Size(180, 70);
            button1.TabIndex = 1;
            button1.Text = "共有フォルダ\r\n（\\\\NAS303F9E）";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mail
            // 
            mail.Location = new Point(50, 180);
            mail.Name = "mail";
            mail.Size = new Size(180, 70);
            mail.TabIndex = 2;
            mail.Text = "Yahoo Mail";
            mail.UseVisualStyleBackColor = true;
            mail.Click += mail_Click;
            // 
            // kuruma
            // 
            kuruma.Location = new Point(236, 180);
            kuruma.Name = "kuruma";
            kuruma.Size = new Size(180, 70);
            kuruma.TabIndex = 3;
            kuruma.Text = "車両関係";
            kuruma.UseVisualStyleBackColor = true;
            kuruma.Click += kuruma_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ホームhToolStripMenuItem, 車両関係cToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(931, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // ホームhToolStripMenuItem
            // 
            ホームhToolStripMenuItem.Name = "ホームhToolStripMenuItem";
            ホームhToolStripMenuItem.Size = new Size(75, 24);
            ホームhToolStripMenuItem.Text = "ホーム(&h)";
            // 
            // 車両関係cToolStripMenuItem
            // 
            車両関係cToolStripMenuItem.Name = "車両関係cToolStripMenuItem";
            車両関係cToolStripMenuItem.Size = new Size(100, 24);
            車両関係cToolStripMenuItem.Text = "車両関係(&c)";
            // 
            // test
            // 
            test.Location = new Point(50, 288);
            test.Name = "test";
            test.Size = new Size(94, 29);
            test.TabIndex = 5;
            test.Text = "button2";
            test.UseVisualStyleBackColor = true;
            test.Click += test_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 495);
            Controls.Add(test);
            Controls.Add(kuruma);
            Controls.Add(mail);
            Controls.Add(button1);
            Controls.Add(doui);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "結づぺい ver1.0.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button doui;
        private Button button1;
        private Button mail;
        private Button kuruma;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ホームhToolStripMenuItem;
        private ToolStripMenuItem 車両関係cToolStripMenuItem;
        private Button test;
    }
}
