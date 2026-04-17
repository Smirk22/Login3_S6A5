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
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage log = new LoginPage();

            panel2.Controls.Clear();

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

        private void button1_Click_1(object sender, EventArgs e)
        {

            // Clear any existing controls in panel2
            panel2.Controls.Clear();

            // Create an instance of Form1
            Accounts accountsForm = new Accounts();

            // Set it to display inside panel2
            accountsForm.TopLevel = false;
            accountsForm.FormBorderStyle = FormBorderStyle.None;
            accountsForm.Dock = DockStyle.Fill;

            // Add it to panel2 and show it
            panel2.Controls.Add(accountsForm);
            panel2.Tag = accountsForm;
            accountsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Clear any existing controls in panel2
            panel2.Controls.Clear();
        }
    }

}
