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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace Contact_Tracing_App
{
    public partial class Form4 : Form
    {
       private FilterInfoCollection filterInfoCollection;
       private VideoCaptureDevice captureDevice;
        public Form4()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                camchoices.Items.Add(filterInfo.Name);
            camchoices.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();

            internetTime.Start();
        }

        private void cptr_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[camchoices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            captureDevice.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            campreview.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning == true)
                captureDevice.Stop();
            
        }

        private void camTimer_Tick(object sender, EventArgs e)
        {
           
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode((Bitmap)campreview.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    generateqr.Text = decoded;
                    StreamWriter doc = new StreamWriter(@"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\Records\" + date.Text + ".txt", true);
                    doc.Write(generateqr.Text);
                    doc.WriteLine(" ");
                    doc.Close();
                    captureDevice.Stop();
                    MessageBox.Show("Thank You for Participating, Stay Safe!");
                    
                }
            }
            catch(Exception ex)
            {
               
            }


        }

        private void generatebttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 F5 = new Form5();

            F5.ShowDialog();
            F5 = null;
            this.Show();
        }

        private void internetTime_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void readbttn_Click(object sender, EventArgs e)
        {
            camTimer.Start();
        }
    }
}
