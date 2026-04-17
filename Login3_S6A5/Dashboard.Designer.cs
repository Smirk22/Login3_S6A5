namespace Login3_S6A5
{
    partial class Dashboard
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
            panel1 = new Panel();
            button1 = new Button();
            Logoutbut = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Logoutbut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 600);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(11, 178);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 1;
            button1.Text = "Accounts";
            button1.UseVisualStyleBackColor = true;
            // 
            // Logoutbut
            // 
            Logoutbut.Location = new Point(34, 509);
            Logoutbut.Margin = new Padding(3, 4, 3, 4);
            Logoutbut.Name = "Logoutbut";
            Logoutbut.Size = new Size(95, 31);
            Logoutbut.TabIndex = 3;
            Logoutbut.Text = "Log out?";
            Logoutbut.UseVisualStyleBackColor = true;
            Logoutbut.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 129);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 4;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(11, 231);
            button3.Name = "button3";
            button3.Size = new Size(136, 29);
            button3.TabIndex = 5;
            button3.Text = "Student Records";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(263, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 600);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label label1;
        public Label label2;
        public Button Logoutbut;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
    }
}