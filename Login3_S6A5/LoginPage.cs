using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace Login3_S6A5
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {


            InitializeComponent();

        }

        // ROUND PANEL FUNCTION
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; uid = root; password =; database = accounts");
            con.Open();

            string query = "select count(*) from users where name = @name and password = @password";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", Logintext.Text);
            cmd.Parameters.AddWithValue("@password", Passwordtext.Text);

            string emailq = "select email from users where name = @name";
            MySqlCommand bla = new MySqlCommand(emailq, con);
            bla.Parameters.AddWithValue("@name", Logintext.Text);
            string email = bla.ExecuteScalar().ToString();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                Dashboard db = new Dashboard(Logintext.Text, email);
                MessageBox.Show("Welcome!");
                db.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Account is not recognized.");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logintext_TextChanged(object sender, EventArgs e)
        {
            Logintext.Height = 60;  // pixels
            Logintext.Size = new Size(200, 60);  // width, h
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}