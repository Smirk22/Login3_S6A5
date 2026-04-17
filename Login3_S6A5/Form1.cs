using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Login3_S6A5
{
    public partial class Accounts : Form
    {
        private void LoadUsers()
        {
            string noc = "server=localhost; database=accounts; uid=root; pwd=;";
            MySqlConnection quo = new MySqlConnection(noc);
            quo.Open();

            string query = "SELECT id, name, email, password, profilepic FROM users";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, quo);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            quo.Close();
        }
        private void Accounts_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        public Accounts()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
