using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aforge
{
    public partial class Form1 : Form
    {

        private FilterInfoCollection CaptureDevice; // list of webcam
        private VideoCaptureDevice FinalFrame;


        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);//constructor
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }

            comboBox1.SelectedIndex = 0; // default
            FinalFrame = new VideoCaptureDevice();
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs){
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();// clone the bitmap

            Bitmap varBmp = new Bitmap((Bitmap)eventArgs.Frame.Clone());
            Bitmap newBitmap = new Bitmap(varBmp);

            string filename = string.Format("Img{0}.Jpg", DateTime.Now.Ticks);
            newBitmap.Save(@"C:\Sample\" + filename, ImageFormat.Jpeg);

            //Now Dispose to free the memory
            newBitmap.Dispose();
            newBitmap = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);// specified web cam and its filter moniker string
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);// click button event is fired, 
            FinalFrame.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FinalFrame.IsRunning == true) FinalFrame.Stop();
        }
    }
   
}
