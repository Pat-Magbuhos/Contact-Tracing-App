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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shwrcrds_Click(object sender, EventArgs e)
        {
                string path = @"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\Records\";
                string path2 = @"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\Records\All\";
                string[] files = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
            using (var output = File.Create(path2 + "Records.txt"))
            {
                foreach (var file in files)
                {
                    using (var data = File.OpenRead(file))
                    {
                        data.CopyTo(output);
                    }
                }
            }

            string path3 = @"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\Records\All\Records.txt";
            var rst = File.ReadAllText(path3);
            rslts.Text = rst;


        }
    }
}