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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileHandler fh = new FileHandler();
            //Simanga down here can you just the student Class
            List<StudentCredentials> readList = fh.ReadCredentials();
            bool foundSearch = false;
            foreach (var item in readList)
            {
                if (item.UserName==txtLoginUsername.Text && item.Password==txtLoginPassword.Text)
                {
                    foundSearch = true;
                    this.Hide();// this hides form 1
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
            }
            if (foundSearch==false)
            {
                try
                {
                    throw new CredentialException("Either the username or password was not a match in the txt file");
                }
                catch (Exception mes)
                {

                    MessageBox.Show(mes.Message, "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
