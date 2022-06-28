using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verify_Click(object sender, EventArgs e)
        {
            string userid = "Admin";
            string pass = "Admin101";

            if (user.Text.Length > 0)
            {
                if (user.Text == userid && password.Text == pass)
                {
                    this.Hide();
                    Form3 F3 = new Form3();

                    F3.ShowDialog();
                }
                
                else
                {
                    MessageBox.Show("Unable to Identify User");
                }
            }

        }
    }
}
