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
            doc.WriteLine("Experiencing andy Covid-19 Symptoms? " + txtbxSYMPTMS.Text);
            doc.WriteLine("Spcification: " + txtbxSPCFY.Text);
            doc.WriteLine("");
            doc.Close();

            MessageBox.Show("Thank You for Participating! Stay Safe");
            txtbxFN.Text = "";
            txtbxMN.Text = "";
            txtbxLN.Text = "";
            txtbxSTRT.Text = "";
            txtbxBRNGY.Text = "";
            txtbxPRV.Text = "";
            txtbxAG.Text = "";
            txtbxDT.Text = "";
            txtbxTP.Text = "";
            txtbxSYMPTMS.Text = "";
            txtbxSPCFY.Text = "";
        }

        private void lst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                                               SYMPTOMS                                                       Fever           CoughShortness of Breath         Fatigue         Body Aches          Headache            Sorethroat          Loss of taste or smell          Diarrhea");
        }

        private void prvcy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In accordance to Data Privacy Act of 2012, please be guided that your personal information will only be shared when it is expressly authorized by law. Provided, that there are adequate safeguards for data privacy and security, and processing adheres to principle of transparency, legitimate purpose and proportionality.                                                                                                                                                        Also, please be reminded that non-cooperation of persons identified as having the notifiable disease, or affected by the health event of public concern, such as COVID19, is prohibited by law under Republic Act No. 11332. Thank you for your understanding in these difficult times.");         
        }
    }
}
