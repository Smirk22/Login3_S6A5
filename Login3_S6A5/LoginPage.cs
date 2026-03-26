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
        public LoginPage()
        {
            InitializeComponent();
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

                        // 3. Ask to save
                        DialogResult result = MessageBox.Show("Do you want to save your account?", "Save Account", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // Save to 'saved' table
                            string picsave = "INSERT INTO saved (name, email) VALUES (@name, @email) ON DUPLICATE KEY UPDATE email=@email";
                            MySqlCommand savecmd = new MySqlCommand(picsave, con);
                            savecmd.Parameters.AddWithValue("@name", Logintext.Text);
                            savecmd.Parameters.AddWithValue("@email", email);
                            savecmd.ExecuteNonQuery();

                            // Try to get profile pic
                            string picQuery = "SELECT profilepic FROM users WHERE name = @name";
                            MySqlCommand picCmd = new MySqlCommand(picQuery, con);
                            picCmd.Parameters.AddWithValue("@name", Logintext.Text);
                            object picResult = picCmd.ExecuteScalar();

                            if (picResult != null && picResult != DBNull.Value)
                            {
                                byte[] imgData = (byte[])picResult;
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    Profilesave ps = new Profilesave();
                                    ps.pictureBox1.Image = Image.FromStream(ms);
                                    // You can show 'ps' or just store the data
                                }
                            }
                        }

                        MessageBox.Show("Welcome!");
                        Dashboard db = new Dashboard(Logintext.Text, email);
                        db.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account is not recognized.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage reg = new RegisterPage();
            reg.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Passwordtext.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void LoginPage_Load(object sender, EventArgs e) => RoundPanel(panel1, 25);
        private void panel1_Resize(object sender, EventArgs e) => RoundPanel(panel1, 25);

        // Empty placeholder methods to prevent errors if they are still linked in designer
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void Logintext_TextChanged(object sender, EventArgs e) { }
    }
}