using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL
{
    public partial class FoodMenuEditor : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        public FoodMenuEditor()
        {
            InitializeComponent();
            FillInFromFile();
        }

        private void FillInFromFile()
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
                    //Add the line to the List
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
            
            textBox1.Text = line2Split[0]; textBox2.Text = line2Split[1]; textBox3.Text = line2Split[2]; textBox4.Text = line2Split[3]; textBox5.Text = line2Split[4];
            textBox6.Text = line3Split[4]; textBox7.Text = line3Split[3]; textBox8.Text = line3Split[2]; textBox9.Text = line3Split[1]; textBox10.Text = line3Split[0];
            textBox11.Text = line4Split[4]; textBox12.Text = line4Split[3]; textBox13.Text = line4Split[2]; textBox14.Text = line4Split[1]; textBox15.Text = line4Split[0];
            textBox16.Text = line5Split[4]; textBox17.Text = line5Split[3]; textBox18.Text = line5Split[2]; textBox19.Text = line5Split[1]; textBox20.Text = line5Split[0];
            textBox21.Text = line6Split[4]; textBox22.Text = line6Split[3]; textBox23.Text = line6Split[2]; textBox24.Text = line6Split[1]; textBox25.Text = line6Split[0];
            textBox26.Text = line7Split[4]; textBox27.Text = line7Split[3]; textBox28.Text = line7Split[2]; textBox29.Text = line7Split[1]; textBox30.Text = line7Split[0];
            textBox31.Text = line8Split[4]; textBox32.Text = line8Split[3]; textBox33.Text = line8Split[2]; textBox34.Text = line8Split[1]; textBox35.Text = line8Split[0];  
        }

        private void FoodMenuEditor_Load(object sender, EventArgs e)
        {

        }

        private void SetEmptyAsNull()
        {
            if (string.IsNullOrEmpty(textBox1.Text)) { textBox1.Text = " "; }
            if (string.IsNullOrEmpty(textBox2.Text)) { textBox2.Text = " "; }
            if (string.IsNullOrEmpty(textBox3.Text)) { textBox3.Text = " "; }
            if (string.IsNullOrEmpty(textBox4.Text)) { textBox4.Text = " "; }
            if (string.IsNullOrEmpty(textBox5.Text)) { textBox5.Text = " "; }
            if (string.IsNullOrEmpty(textBox6.Text)) { textBox6.Text = " "; }
            if (string.IsNullOrEmpty(textBox7.Text)) { textBox7.Text = " "; }
            if (string.IsNullOrEmpty(textBox8.Text)) { textBox8.Text = " "; }
            if (string.IsNullOrEmpty(textBox9.Text)) { textBox9.Text = " "; }
            if (string.IsNullOrEmpty(textBox10.Text)) { textBox10.Text = " "; }
            if (string.IsNullOrEmpty(textBox11.Text)) { textBox11.Text = " "; }
            if (string.IsNullOrEmpty(textBox12.Text)) { textBox12.Text = " "; }
            if (string.IsNullOrEmpty(textBox13.Text)) { textBox13.Text = " "; }
            if (string.IsNullOrEmpty(textBox14.Text)) { textBox14.Text = " "; }
            if (string.IsNullOrEmpty(textBox15.Text)) { textBox15.Text = " "; }
            if (string.IsNullOrEmpty(textBox16.Text)) { textBox16.Text = " "; }
            if (string.IsNullOrEmpty(textBox17.Text)) { textBox17.Text = " "; }
            if (string.IsNullOrEmpty(textBox18.Text)) { textBox18.Text = " "; }
            if (string.IsNullOrEmpty(textBox19.Text)) { textBox19.Text = " "; }
            if (string.IsNullOrEmpty(textBox20.Text)) { textBox20.Text = " "; }
            if (string.IsNullOrEmpty(textBox21.Text)) { textBox21.Text = " "; }
            if (string.IsNullOrEmpty(textBox22.Text)) { textBox22.Text = " "; }
            if (string.IsNullOrEmpty(textBox23.Text)) { textBox23.Text = " "; }
            if (string.IsNullOrEmpty(textBox24.Text)) { textBox24.Text = " "; }
            if (string.IsNullOrEmpty(textBox25.Text)) { textBox25.Text = " "; }
            if (string.IsNullOrEmpty(textBox26.Text)) { textBox26.Text = " "; }
            if (string.IsNullOrEmpty(textBox27.Text)) { textBox27.Text = " "; }
            if (string.IsNullOrEmpty(textBox28.Text)) { textBox28.Text = " "; }
            if (string.IsNullOrEmpty(textBox29.Text)) { textBox29.Text = " "; }
            if (string.IsNullOrEmpty(textBox30.Text)) { textBox30.Text = " "; }
            if (string.IsNullOrEmpty(textBox31.Text)) { textBox31.Text = " "; }
            if (string.IsNullOrEmpty(textBox32.Text)) { textBox32.Text = " "; }
            if (string.IsNullOrEmpty(textBox33.Text)) { textBox33.Text = " "; }
            if (string.IsNullOrEmpty(textBox34.Text)) { textBox34.Text = " "; }
            if (string.IsNullOrEmpty(textBox35.Text)) { textBox35.Text = " "; }
        }
        
        private void applyButton_Click(object sender, EventArgs e)
        {
            SetEmptyAsNull();
            //Get exe location
            string dir =System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().Location);
            //Read All Lines
            var lines = System.IO.File.ReadAllLines(dir + @"\FoodInfo.txt");
            
            lines[1] = textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";" + textBox5.Text;
            lines[2] = textBox10.Text + ";" + textBox9.Text + ";" + textBox8.Text + ";" + textBox7.Text + ";" + textBox6.Text;
            lines[3] = textBox15.Text + ";" + textBox14.Text + ";" + textBox13.Text + ";" + textBox12.Text + ";" + textBox11.Text;
            lines[4] = textBox20.Text + ";" + textBox19.Text + ";" + textBox18.Text + ";" + textBox17.Text + ";" + textBox16.Text;
            lines[5] = textBox25.Text + ";" + textBox24.Text + ";" + textBox23.Text + ";" + textBox22.Text + ";" + textBox21.Text;
            lines[6] = textBox30.Text + ";" + textBox29.Text + ";" + textBox28.Text + ";" + textBox27.Text + ";" + textBox26.Text;
            lines[7] = textBox35.Text + ";" + textBox34.Text + ";" + textBox33.Text + ";" + textBox32.Text + ";" + textBox31.Text;
            
            //Write File
            System.IO.File.WriteAllLines(dir + @"\FoodInfo.txt", lines);
            
            this.Close();
            FormProvider.Menu_Form.Show();
        }

        private void applyDays_Click(object sender, EventArgs e)
        {
            //Declare Day of week Dictionary
            IDictionary<string, int> DaysOfWeek = new Dictionary<string, int>()
            {
                {"Monday", 1},
                {"Tuesday", 2},
                {"Wednesday", 3},
                {"Thursday", 4},
                {"Friday", 5},
                {"Saturday", 6},
                {"Sunday", 7}
            };
            //Set id of weekday
            int id = DaysOfWeek[comboBox1.Text];
            //Open Connection
            m_dbConnection.Open();
            //Define Statement
            var sql = $"SELECT * FROM FoodDays WHERE ID='{id}'";
            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            //Run Command
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            //Read the Data
            while (rdr.Read())
            {
                if (rdr.IsDBNull(1)) {  }
                else
                {
                    //Concatenate all the days
                    string contents = rdr.GetString(1) + ";" +
                                      rdr.GetString(2) + ";" +
                                      rdr.GetString(3) + ";" +
                                      rdr.GetString(4) + ";" +
                                      rdr.GetString(5) + ";" +
                                      rdr.GetString(6) + ";" +
                                      rdr.GetString(7);
                    //Get exe location
                    string dir = Path.GetDirectoryName(
                        System.Reflection.Assembly.GetExecutingAssembly().Location);
                    //Read All Lines
                    var lines = File.ReadAllLines(dir + @"\FoodInfo.txt");
                    //Replace first line
                    lines[0] = contents;
                    //Write back to the file
                    File.WriteAllLines(dir + @"\FoodInfo.txt", lines);
                }
            }
            m_dbConnection.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
