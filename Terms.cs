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
    public partial class Terms : Form
    {
        public Terms()
        {
            InitializeComponent();

            string imagePath = "Public/lightBack.jpg";
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            ShowtxtFile("WorkoutPlansTerms.txt", lblWPbody);

            ShowtxtFile("MenuTerms.txt", lblMenubody);
            }
        private void ShowtxtFile(string filename,Label plantext)
        {
            try
            {
                System.IO.StreamReader sr1 = new StreamReader(filename);
                string str = "";
                string line;

                while ((line = sr1.ReadLine()) != null)
                    str += line + "\n";
                sr1.Close();
                plantext.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Hide();
        }

        private void SaveFile(string filename, Label planText)
        {
            try
            {
                string fileName = filename;

                //save on desktop
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string text = planText.Text;
                    sw.WriteLine(text);

                    MessageBox.Show("File Saved!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnsaveMenuTerms_Click(object sender, EventArgs e)
        {
            SaveFile("RomFitnessMENU_terms.txt", lblMenubody);
            
        }


        private void btnSaveTermswp_Click(object sender, EventArgs e)
        {
            SaveFile("RomFitnessWorkoutplan_terms.txt", lblWPbody);
        }
    }
}
