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
    public partial class DeleteAndUpdate : Form
    {
        public DeleteAndUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            dh.Update(Convert.ToInt32(stdnum.Text), Convert.ToInt32(stdMod.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            dh.Delete(Convert.ToInt32(stdNumdelete.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteAndUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
