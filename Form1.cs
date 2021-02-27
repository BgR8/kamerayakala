using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Aforge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Bilgisayara Bağlı kameraları tutan dizin
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

        private void Form1_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame; 
            vcd.Start();
        }

        // vcd.NewFrame += 2kez tab dediğimde bu yöntem gelir.
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Kameraya çerçeveyi tanıt.
            // Bitmap sınıfından image adında nesne oluşturup kameradan aldığımız çerçevemizi oluştur.
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}
