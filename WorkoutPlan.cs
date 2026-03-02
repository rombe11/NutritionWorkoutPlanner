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
    public partial class WorkoutPlan : Form
    {
        public WorkoutPlan()
        {
            InitializeComponent();
            string imagePath = "Public/lightBack.jpg";
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void DisplayWorkoutPlan(string fileName)
        {
            try
            {
                lblWPbody.Visible = true;
                lblWPbody.Text = "";
                System.IO.StreamReader sr = new StreamReader(fileName);
                string str = "";
                string line;

                while ((line = sr.ReadLine()) != null)
                    str += line + "\n";
                sr.Close();
                lblWPbody.Text = str;

                btnSavePlan.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuildWPlan_Click(object sender, EventArgs e)
        {
            //Mass
            if (radioMass.Checked && radioBeginer.Checked)
            {
                if (radio1or2.Checked)
                {
                    //fullbody-mass-beginner
                    DisplayWorkoutPlan("wpMass_fullbody.txt");
                }
                else if (radio3orMore.Checked)
                {
                    //lower-upper/mass/begginer
                    DisplayWorkoutPlan("lowerUpperBeginner.txt"); 
                }
            }
            else if (radioMass.Checked && radioAdvanced.Checked) {
                if (radio1or2.Checked)
                {
                    //fullbody/advanced/mass
                    DisplayWorkoutPlan("FullBody_Mass_Advanced.txt");
                }
                else if (radio3orMore.Checked)
                {
                    //lower-upper/advanced/mass
                    DisplayWorkoutPlan("LowerUpper_Mass_Advanced.txt");
                }
            }
            
            //toning
            else if (radioToning.Checked && radioBeginer.Checked)
            {
                if (radio1or2.Checked)
                {
                    //fullbody/toning/beginner
                    DisplayWorkoutPlan("woPlanBeginner_toning_fullbody.txt");
                }
                else if (radio3orMore.Checked)
                {
                    //lower - upper/toning/beginner
                    DisplayWorkoutPlan("LowerUpper_Toning_Beginner.txt"); 
                }
            }
            else if (radioToning.Checked && radioAdvanced.Checked)
            {
                if (radio1or2.Checked)
                {
                    //fullbody/advanced/toning
                    DisplayWorkoutPlan("FullBody_Toning_Advanced.txt"); 
                }
                else if (radio3orMore.Checked)
                {
                    //lower - upper
                    DisplayWorkoutPlan("wpAdvanced_Toning23.txt");
                }
            }
            else
            {
                MessageBox.Show("Please fill all details");
            }
        }
        private void SaveFile(string filename,Label planText)
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
        private void btnSavePlan_Click(object sender, EventArgs e)
        {
            SaveFile("RomFitnessWorkoutplan.txt", lblWPbody);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSavePlan.Enabled = false;
            lblWPbody.Text = "";
        }
        private void btnShowExamples_Click(object sender, EventArgs e)
        {
            WorkoutExamples we = new WorkoutExamples();

            we.Show();
            this.Hide();
        }
    }
}
