using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG252_Project_Joshua_Simanga_Mieke
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search();
            s.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            View v = new View();
            v.Show();
        }

        private void btnUpdatesAndDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteAndUpdate dau = new DeleteAndUpdate();
            dau.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
