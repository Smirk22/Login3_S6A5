using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login3_S6A5
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            // Database Connection
            string connectionString = "server=localhost;uid=root;password=;database=accounts";

            if (Passwordtxt.Text != ConfirmPasswordtxt.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO users (name, email, password) VALUES (@name, @email, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", Nametxt.Text);
                    cmd.Parameters.AddWithValue("@email", Emailtxt.Text);
                    cmd.Parameters.AddWithValue("@password", Passwordtxt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful!");

                    // Return to Login
                    new LoginPage().Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
         
            }
            this.Hide(); // Hide the register page
            new LoginPage().Show(); // Go back to login
        }


        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.ShowDialog();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = checkBox1.Checked ? '\0' : '*';
            ConfirmPasswordtxt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void RoundPanel(Control panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(panel.Width - d, 0, d, d, 270, 90);
            path.AddArc(panel.Width - d, panel.Height - d, d, d, 0, 90);
            path.AddArc(0, panel.Height - d, d, d, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void RegisterPage_Load(object sender, EventArgs e) => RoundPanel(panel1, 25);
        private void panel1_Resize(object sender, EventArgs e) => RoundPanel(panel1, 25);

        private void RegisterPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}