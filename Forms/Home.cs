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

namespace RomFitness
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            string imagePath = "Public/backIMG.jpg";
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateMENU_Click(object sender, EventArgs e)
        {
            RomFitness rf = new RomFitness();

            rf.Show();
            this.Hide();
        }

        private void btnCreateWPlan_Click(object sender, EventArgs e)
        {
            WorkoutPlan wp = new WorkoutPlan();

            wp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terms t = new Terms();

            t.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkoutExamples we = new WorkoutExamples();

            we.Show();
            this.Hide();
        }
    }
}
