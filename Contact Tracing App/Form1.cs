using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            StreamWriter doc = new StreamWriter(@"C:\Users\Mags\Documents\Contact Tracing App\Record.txt", true);
            doc.WriteLine("First Name: " + txtbxFN.Text);
            doc.WriteLine("Middle Name " + txtbxMN.Text);
            doc.Close();
        }
    }
}
