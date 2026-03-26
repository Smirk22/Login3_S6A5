using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login3_S6A5
{
    public partial class Profilesave : Form
    {
        public Profilesave()
        {
            InitializeComponent();
        }

        public string Loggedname;

        private void Profilesave_Load(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage();

            string connectionString = "server=localhost;database=accounts;uid=root;pwd=;";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            string pic = "select profilepic from saved where name = @name";
            MySqlCommand haha = new MySqlCommand(pic, con);

            haha.Parameters.AddWithValue("@name", Loggedname);
            object result2 = haha.ExecuteScalar();

            if (result2 != null && result2 != DBNull.Value)
            {
                byte[] imgData = (byte[])result2;

                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("No image found for this user!"); // ← tells you if image is null
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
