using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login3_S6A5
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username, string email)
        {
            InitializeComponent();
            label1.Text = username;
            label2.Text = email;

        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            Profilesave ps = new Profilesave();
            LoginPage login = new LoginPage();
            DialogResult result = MessageBox.Show("Do you want to save your profile picture?", "Save Profile Picture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string noc = "server = localhost; database = accounts; uid = root; pwd =;";
            MySqlConnection quo = new MySqlConnection(noc);
            quo.Open();

            if (result == DialogResult.Yes)
            {
                string picsave = "insert into saved (name, email) values (@name, @email)";
                MySqlCommand savecmd = new MySqlCommand(picsave, quo);
                savecmd.Parameters.AddWithValue("@name", login.Logintext.Text);
                savecmd.Parameters.AddWithValue("@email", label2.Text);

                string pic = "select profilepic from users where name = @name";
                MySqlCommand haha = new MySqlCommand(pic, quo);

                haha.Parameters.AddWithValue("@name", login.Logintext.Text);
                object result2 = haha.ExecuteScalar();

                byte[] imgData = (byte[])result2;

                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    ps.pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage();
            log.Refresh();

            this.Hide();

            log.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profilesave ps = new Profilesave();

            this.Hide();

            ps.ShowDialog();

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
