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
    public partial class RomFitness : Form
    {
        public RomFitness()
        {
            InitializeComponent();

            string imagePath = "Public/lightBack.jpg";
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void CreateMenu()
        {
            int sex = 0, index = 0;

            try
            {
                if (radioMale.Checked)
                    sex = 1;
                else if (radioFemale.Checked)
                    sex = 0;
                else
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                double bmr = bmrCalc(sex, Convert.ToInt32(comboAge.Text), Convert.ToInt32(comboHeight.Text), Convert.ToInt32(comboWeight.Text));
                double calPerMeal = bmr / 3;

                lblMenuBody.Text += "Nutirion Menu By RomFitness\n";
                lblMenuBody.Text += "\nBMR : " + bmr.ToString() + " Calories per a day\n";

                Dictionary<string, int> itemCalories = new Dictionary<string, int>();
                List<string> selectedProteins = GetSelectedProteins();
                List<string> selectedCarbs = GetSelectedCarbs();

                if (selectedProteins.Count == 0 || selectedCarbs.Count == 0)
                {
                    MessageBox.Show("Please select at least one protein and one carb before creating the menu.");
                    return;
                }

                try
                {
                    string filePath = "caloriesPer100gr.txt";

                    if (File.Exists(filePath))
                    {
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string itemName = line;
                                int caloriePer100g;
                                if ((line = sr.ReadLine()) != null && int.TryParse(line, out caloriePer100g))
                                {
                                    itemCalories[itemName] = caloriePer100g;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
                
                for (int i = 0; i < 3; i++)
                {
                    //add meal
                    switch (i)
                    {
                        case 0:
                            lblMenuBody.Text += "\nBreakfast: \n";
                            break;
                        case 1:
                            lblMenuBody.Text += "\nLunch: \n";
                            break;
                        case 2:
                            lblMenuBody.Text += "\nDinner: \n";
                            break;
                    }

                    //add protein and carb
                    if (selectedProteins.Count > 0 && selectedCarbs.Count > 0)
                    {
                        string protein = selectedProteins[index % selectedProteins.Count];
                        string carb = selectedCarbs[index % selectedCarbs.Count];

                        if (itemCalories.TryGetValue(protein, out int proteinCalories) && itemCalories.TryGetValue(carb, out int carbCalories))
                        {
                            int proteinAmount = (int)Math.Round((calPerMeal / 4) / (proteinCalories / 100.0));
                            int carbAmount = (int)Math.Round((calPerMeal / 4) / (carbCalories / 100.0));

                            lblMenuBody.Text += "\n" + protein + " : " + proteinAmount.ToString() + " gr\n";
                            lblMenuBody.Text += "\n" + carb + " : " + carbAmount.ToString() + " gr\n";
                        }

                        index++;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Not all required details filled:\n" +e.Message);
                return;
            }
        }
      
        private double bmrCalc(int sex, int age, int height, int weight)
        {
            double bmr = (height * 6.25) + (weight * 10) - (age * 5);
            if (sex == 1) //male
                bmr += 5;
            else if(sex == 0)//female
                bmr -= 161;

            return bmr;
        }

        private List<string> GetSelectedProteins()
        {
            List<string> selectedProteins = new List<string>();

            foreach (string protein in checklst_Proteins.CheckedItems)
            {
                selectedProteins.Add(protein);
            }

            return selectedProteins;
        }

        private List<string> GetSelectedCarbs()
        {
            List<string> selectedCarbs = new List<string>();

            foreach (string carb in checklst_Carbs.CheckedItems)
            {
                selectedCarbs.Add(carb);
            }

            return selectedCarbs;
        }

        private void RomFitness_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMenu();
            btnSaveMenu.Enabled = true;
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "NutritionMenu_ByRomfitness.txt";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string text = lblMenuBody.Text;
                    sw.WriteLine(text);

                    MessageBox.Show("Menu Saved");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();

            home.Show();
            this.Hide();
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Terms t = new Terms();

            t.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMenuBody.Text = "";
            btnSaveMenu.Enabled = false;
        }
    }
}
