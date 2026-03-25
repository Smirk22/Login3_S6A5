using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Dashboard db = new Dashboard(label1.Text, label2.Text);
            LoginPage log = new LoginPage();
           log.Refresh();
            db.Close();
        }
    }
}
