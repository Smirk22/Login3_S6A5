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
            Logoutbut = new Button();
            label2 = new Label();
            label1 = new Label();
            savebut = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(savebut);
            panel1.Controls.Add(Logoutbut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 450);
            panel1.TabIndex = 0;
            // 
            // Logoutbut
            // 
            Logoutbut.Location = new Point(30, 382);
            Logoutbut.Name = "Logoutbut";
            Logoutbut.Size = new Size(83, 23);
            Logoutbut.TabIndex = 3;
            Logoutbut.Text = "Log out?";
            Logoutbut.UseVisualStyleBackColor = true;
            Logoutbut.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // savebut
            // 
            savebut.Location = new Point(30, 124);
            savebut.Name = "savebut";
            savebut.Size = new Size(83, 23);
            savebut.TabIndex = 4;
            savebut.Text = "Saved";
            savebut.UseVisualStyleBackColor = true;
            savebut.Click += button2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label label1;
        public Label label2;
        public Button Logoutbut;
        public Button savebut;
    }
}