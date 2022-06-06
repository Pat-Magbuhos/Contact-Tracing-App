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
            doc.WriteLine("Middle Name: " + txtbxMN.Text);
            doc.WriteLine("Last Name: " + txtbxLN.Text);
            doc.WriteLine("Street Address: " + txtbxSTRT.Text);
            doc.WriteLine("Barangay: " + txtbxBRNGY.Text);
            doc.WriteLine("Province and Municipality: " + txtbxPRV.Text);
            doc.WriteLine("Age: " + txtbxAG.Text);
            doc.WriteLine("Date: " + txtbxDT.Text);
            doc.WriteLine("Temperature: " + txtbxTP.Text);
            doc.Close();
        }

        private void lst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                                               SYMPTOMS                                                       Fever           CoughShortness of Breath         Fatigue         Body Aches          Headache            Sorethroat          Loss of taste or smell          Diarrhea");
        }            
    }
}
