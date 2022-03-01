using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Computer_Science_NEA_FINAL.Resources
{
    public partial class Menu_Form : Form
    {
        public Menu_Form()
        {
            InitializeComponent();
            GetFoodFromFile();
            authCheck();
        }

        private void authCheck()
        {
            if (FormProvider.userType == 1)
                Edit.Show();
            else
                Edit.Hide();
        }
        
        private void GetFoodFromFile()
        {
            List<string> food = new List<string>();
            
            String line;
            try
            {
                //Get exe location
                string dir =System.IO.Path.GetDirectoryName(
                    System.Reflection.Assembly.GetExecutingAssembly().Location);
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(dir + @"\FoodInfo.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    food.Add(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                //Apply Food From File
                ApplyFoodFromFile(food);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        
        private void ApplyFoodFromFile(List<string> food)
        {
            //Split up File
            string line1 = food[0];
            string line2 = food[1];
            string line3 = food[2];
            string line4 = food[3];
            string line5 = food[4];
            string line6 = food[5];
            string line7 = food[6];
            string line8 = food[7];
            
            string[] line1Split = line1.Split(';');
            string[] line2Split = line2.Split(';');
            string[] line3Split = line3.Split(';');
            string[] line4Split = line4.Split(';');
            string[] line5Split = line5.Split(';');
            string[] line6Split = line6.Split(';');
            string[] line7Split = line7.Split(';');
            string[] line8Split = line8.Split(';');
            
            
            //Set Days of Week
            Day1.Text = line1Split[0]; Day2.Text = line1Split[1]; Day3.Text = line1Split[2]; Day4.Text = line1Split[3]; Day5.Text = line1Split[4]; Day6.Text = line1Split[5]; Day7.Text = line1Split[6];
            //SetDay1-7's Food
            label1.Text = line2Split[0]; label2.Text = line2Split[1]; label3.Text = line2Split[2]; label4.Text = line2Split[3]; label5.Text = line2Split[4];
            label6.Text = line3Split[0]; label7.Text = line3Split[1]; label8.Text = line3Split[2]; label9.Text = line3Split[3]; label10.Text = line3Split[4];
            label11.Text = line4Split[0]; label12.Text = line4Split[1]; label13.Text = line4Split[2]; label14.Text = line4Split[3]; label15.Text = line4Split[4];
            label16.Text = line5Split[0]; label17.Text = line5Split[1]; label18.Text = line5Split[2]; label19.Text = line5Split[3]; label20.Text = line5Split[4];
            label21.Text = line6Split[0]; label22.Text = line6Split[1]; label23.Text = line6Split[2]; label24.Text = line6Split[3]; label25.Text = line6Split[4];
            label26.Text = line7Split[0]; label27.Text = line7Split[1]; label28.Text = line7Split[2]; label29.Text = line7Split[3]; label30.Text = line7Split[4];
            label31.Text = line8Split[0]; label32.Text = line8Split[1]; label33.Text = line8Split[2]; label34.Text = line8Split[3]; label35.Text = line8Split[4]; 
        }
        
        private void homeButton_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Show();
            this.Hide();
        }

        private void AfternoonSnack_Click(object sender, EventArgs e)
        {

        }

        private void Dinner_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            FoodMenuEditor foodMenuEditor = new FoodMenuEditor();
            foodMenuEditor.Show();
            this.Hide();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            GetFoodFromFile();
        }
    }
}
