namespace Login3_S6A5
{
    partial class RegisterPage
    {
        private System.ComponentModel.IContainer components = null;

        // Ensure these variable names match exactly what the Logic file expects
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox ConfirmPasswordtxt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.LinkLabel lnkBackToLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            panel1 = new Panel();
            lblTitle = new Label();
            Nametxt = new TextBox();
            Emailtxt = new TextBox();
            Passwordtxt = new TextBox();
            ConfirmPasswordtxt = new TextBox();
            checkBox1 = new CheckBox();
            Registerbtn = new Button();
            lnkBackToLogin = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(Nametxt);
            panel1.Controls.Add(Emailtxt);
            panel1.Controls.Add(Passwordtxt);
            panel1.Controls.Add(ConfirmPasswordtxt);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Registerbtn);
            panel1.Controls.Add(lnkBackToLogin);
            panel1.Location = new Point(450, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 600);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(170, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(189, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(100, 130);
            Nametxt.Name = "Nametxt";
            Nametxt.PlaceholderText = "Username";
            Nametxt.Size = new Size(350, 23);
            Nametxt.TabIndex = 1;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(100, 190);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.PlaceholderText = "Email Address";
            Emailtxt.Size = new Size(350, 23);
            Emailtxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(100, 250);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.PlaceholderText = "Password";
            Passwordtxt.Size = new Size(350, 23);
            Passwordtxt.TabIndex = 3;
            // 
            // ConfirmPasswordtxt
            // 
            ConfirmPasswordtxt.Location = new Point(100, 310);
            ConfirmPasswordtxt.Name = "ConfirmPasswordtxt";
            ConfirmPasswordtxt.PasswordChar = '*';
            ConfirmPasswordtxt.PlaceholderText = "Confirm Password";
            ConfirmPasswordtxt.Size = new Size(350, 23);
            ConfirmPasswordtxt.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(100, 350);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(113, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show Passwords";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Registerbtn
            // 
            Registerbtn.BackColor = Color.MediumSeaGreen;
            Registerbtn.FlatStyle = FlatStyle.Flat;
            Registerbtn.ForeColor = Color.White;
            Registerbtn.Location = new Point(100, 410);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(350, 45);
            Registerbtn.TabIndex = 6;
            Registerbtn.Text = "REGISTER";
            Registerbtn.UseVisualStyleBackColor = false;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // lnkBackToLogin
            // 
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.Location = new Point(190, 480);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new Size(175, 15);
            lnkBackToLogin.TabIndex = 7;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Already have an account? Login";
            lnkBackToLogin.LinkClicked += lnkBackToLogin_LinkClicked;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1450, 800);
            Controls.Add(panel1);
            Name = "RegisterPage";
            Text = "Register Account";
            Load += RegisterPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void SetupCustomUI()
        {
            // Copy your existing styling code here (the colors, panel positions, etc.)
            // Make sure the names match: Nametxt, Emailtxt, Passwordtxt, etc.
            // ... (Your previous green/gold styling code)
        }
    }
}