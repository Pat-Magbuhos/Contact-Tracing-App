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

        private void fltrbttn_Click(object sender, EventArgs e)
        {
            string path4 = @"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\Records\";
            string path5 = @"C:\Users\Mags\source\repos\Contact Tracing App\Contact Tracing App\Records\Searches\";
            string[] docs = Directory.GetFiles(path4, dateTimeFilter.Text + ".txt", SearchOption.TopDirectoryOnly);

            using (var rslt = File.Create(path5 + dateTimeFilter.Text + " (SEARCH).txt"))
            {
                foreach (var doc in docs)
                {
                    using (var data = File.OpenRead(doc))
                    {
                        data.CopyTo(rslt);
                    }
                }
            }

            var rst = File.ReadAllText(path5 + dateTimeFilter.Text + " (SEARCH).txt");
            rslts.Text = rst;
        }
    }
}