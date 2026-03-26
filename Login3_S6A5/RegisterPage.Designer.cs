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

            // panel1 (The Rounded Container)
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(450, 80); // Adjust based on your screen size
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 600);
            panel1.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(170, 40);
            lblTitle.Text = "Create Account";

            // Nametxt
            Nametxt.PlaceholderText = "Username";
            Nametxt.Location = new Point(100, 130);
            Nametxt.Size = new Size(350, 30);

            // Emailtxt
            Emailtxt.PlaceholderText = "Email Address";
            Emailtxt.Location = new Point(100, 190);
            Emailtxt.Size = new Size(350, 30);

            // Passwordtxt
            Passwordtxt.PlaceholderText = "Password";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.Location = new Point(100, 250);
            Passwordtxt.Size = new Size(350, 30);

            // ConfirmPasswordtxt
            ConfirmPasswordtxt.PlaceholderText = "Confirm Password";
            ConfirmPasswordtxt.PasswordChar = '*';
            ConfirmPasswordtxt.Location = new Point(100, 310);
            ConfirmPasswordtxt.Size = new Size(350, 30);

            // checkBox1 (Show Password)
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(100, 350);
            checkBox1.Text = "Show Passwords";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

            // Registerbtn
            Registerbtn.BackColor = Color.MediumSeaGreen;
            Registerbtn.FlatStyle = FlatStyle.Flat;
            Registerbtn.ForeColor = Color.White;
            Registerbtn.Location = new Point(100, 410);
            Registerbtn.Size = new Size(350, 45);
            Registerbtn.Text = "REGISTER";
            Registerbtn.Click += Registerbtn_Click;

            // lnkBackToLogin
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.Location = new Point(190, 480);
            lnkBackToLogin.Text = "Already have an account? Login";
            lnkBackToLogin.LinkClicked += lnkBackToLogin_LinkClicked;

            // Adding controls to panel1
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(Nametxt);
            panel1.Controls.Add(Emailtxt);
            panel1.Controls.Add(Passwordtxt);
            panel1.Controls.Add(ConfirmPasswordtxt);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Registerbtn);
            panel1.Controls.Add(lnkBackToLogin);

            // RegisterPage (Main Form)
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen; // Matches Login theme
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