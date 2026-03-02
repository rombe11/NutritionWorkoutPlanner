using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.IO;

namespace RomFitness
{
    public partial class WorkoutExamples : Form
    {


        public WorkoutExamples()
        {
            InitializeComponent();

            string imagePath = "Public/lightBack.jpg";
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void WorkoutExamples_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://youtube.com/shorts/pBT87_Xz2pw?si=093oivSAsq1tKhgo";
            string linkData = e.Link.LinkData.ToString();

            System.Diagnostics.Process.Start(linkData);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://youtube.com/shorts/Fpyeg95QY00?si=e-_osbLWV6BqL4UV";
            string linkData = e.Link.LinkData.ToString();

            System.Diagnostics.Process.Start(linkData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://www.youtube.com/watch?v=iCQ2gC4DqJw&pp=ygUZd29ya291dCBleGVyY2lzZSBleGFtcGxlcw%3D%3D";
            string linkData = e.Link.LinkData.ToString();

            System.Diagnostics.Process.Start(linkData);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://www.youtube.com/watch?v=Fov5eUBJpis&pp=ygUZd29ya291dCBleGVyY2lzZSBleGFtcGxlcw%3D%3D";
            string linkData = e.Link.LinkData.ToString();

            System.Diagnostics.Process.Start(linkData);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://www.youtube.com/shorts/QwXkV6AT_LA";

            string linkData = e.Link.LinkData.ToString();
            System.Diagnostics.Process.Start(linkData);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.LinkData = "https://www.pexels.com/video/a-man-working-out-using-dumbbell-5319099/";

            string linkData = e.Link.LinkData.ToString();
            System.Diagnostics.Process.Start(linkData);
        }
    }
}
