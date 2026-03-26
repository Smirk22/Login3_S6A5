namespace Login3_S6A5
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            checkBox1 = new CheckBox();
            label1 = new Label();
            Loginbutton = new Button();
            Passwordtext = new TextBox();
            Logintext = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Loginbutton);
            panel1.Controls.Add(Passwordtext);
            panel1.Controls.Add(Logintext);
            panel1.Location = new Point(309, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 623);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 275);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 9;
            label3.Text = "0";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(308, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(212, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "\"Don't have an account? Register here\"";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(275, 239);
            label2.Name = "label2";
            label2.Size = new Size(297, 21);
            label2.TabIndex = 7;
            label2.Text = "Please Enter your Credentials to Continue";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 181);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(560, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 142);
            panel3.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(360, 388);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(360, 196);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 4;
            label1.Text = "Welcome Back!!";
            label1.Click += label1_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Loginbutton.BackColor = Color.MediumSeaGreen;
            Loginbutton.BackgroundImageLayout = ImageLayout.None;
            Loginbutton.Location = new Point(242, 457);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(373, 40);
            Loginbutton.TabIndex = 3;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Passwordtext
            // 
            Passwordtext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Passwordtext.Location = new Point(242, 346);
            Passwordtext.Name = "Passwordtext";
            Passwordtext.PasswordChar = '*';
            Passwordtext.PlaceholderText = "Password";
            Passwordtext.Size = new Size(373, 23);
            Passwordtext.TabIndex = 2;
            // 
            // Logintext
            // 
            Logintext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Logintext.BorderStyle = BorderStyle.FixedSingle;
            Logintext.Location = new Point(242, 303);
            Logintext.Name = "Logintext";
            Logintext.PlaceholderText = "Username";
            Logintext.Size = new Size(373, 23);
            Logintext.TabIndex = 1;
            Logintext.TextChanged += Logintext_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1456, 795);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "LoginPage";
            Text = "Login Page";
            Load += LoginPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Passwordtext;
        private Button Loginbutton;
        private Label label1;
        private CheckBox checkBox1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        public TextBox Logintext;
        private LinkLabel linkLabel1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
