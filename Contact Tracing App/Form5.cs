using QRCoder;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttngenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtbxinput.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            qrpic.Image = code.GetGraphic(5);
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\QR Codes\";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = path;

            if (qrpic.Image == null)
            {
                MessageBox.Show("No QR Code Image Found");
                MessageBox.Show("Generate Your First QR and Try Again");
            }

            else if (dialog.ShowDialog() == DialogResult.OK)
            {
                qrpic.Image.Save(dialog.FileName);
            }
        }
    }
}
