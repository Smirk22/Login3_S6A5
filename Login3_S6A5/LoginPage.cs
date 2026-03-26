using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login3_S6A5
{
    public partial class LoginPage : Form
    {
        int trynumer = +1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(label3.Text);
            num--;
            label3.Text = num.ToString();
            if (num <= 0)
            {
                timer1.Stop();
                label3.Visible = false;
                Enabled = true;
            }
        }

        public LoginPage()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
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

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;uid=root;password=;database=accounts";

            try
            {
                Profilesave ps = new Profilesave();
                using (MySqlConnection con = new MySqlConnection(connStr))
                {
                    con.Open();

                    // 1. Verify User exists
                    string query = "SELECT COUNT(*) FROM users WHERE name = @name AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", Logintext.Text);
                    cmd.Parameters.AddWithValue("@password", Passwordtext.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        // 2. SUCCESS: Get Email
                        string emailq = "SELECT email FROM users WHERE name = @name";
                        MySqlCommand bla = new MySqlCommand(emailq, con);
                        bla.Parameters.AddWithValue("@name", Logintext.Text);
                        string email = bla.ExecuteScalar()?.ToString() ?? "";
                        Dashboard db = new Dashboard(Logintext.Text, email);

                        MessageBox.Show("Welcome!");

                        this.Hide();

                        db.ShowDialog();

                        this.Close();
                      

                  

                    }
                    else
                    {
                        MessageBox.Show("Account is not recognized.");
                        trynumer++;
                        int num = 10;

                        if (trynumer >= 4)
                        {
                            MessageBox.Show("Too many failed attempts. Locked down for 10 seconds.");
                            label3.Text = num.ToString();
                            label3.Visible = true;
                            timer1.Start();
                            Enabled = false;
                            Logintext.Text = "";
                            Passwordtext.Text = "";

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
        }






        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Passwordtext.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            RoundPanel(panel1, 25);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            RoundPanel(panel1, 25);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage reg = new RegisterPage();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        // Empty placeholder methods to prevent errors if they are still linked in designer
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void Logintext_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}