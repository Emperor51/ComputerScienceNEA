using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Computer_Science_NEA_FINAL
{
    public partial class AddIncident : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        public AddIncident()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {
            loadLeaders();
            loadCubs();
            loadMaterials();
        }

        private void loadLeaders()
        {
            m_dbConnection.Open();
            string sql = @"SELECT a.FirstName || ' ' || a.LastName
FROM Person as a
JOIN Person_Role as b on b.Person = a.id
JOIN Role_Type as c on c.ID = b.Role
WHERE c.name = 'Leader'";
            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            var rec = new List<string>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rec.Add(reader.GetString(0).ToString());
                }
            }
            for (int i = 0; i < rec.Count; i++)
            {
                recorderOption.Items.Add(rec[i]);
            }  
            m_dbConnection.Close();
        }
        private void loadCubs()
        {
            m_dbConnection.Open();
            string sql = @"SELECT a.FirstName || ' ' || a.LastName
FROM Person as a
JOIN Person_Role as b on b.Person = a.id
JOIN Role_Type as c on c.ID = b.Role
WHERE c.name = 'Cub'";
            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            var rec = new List<string>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rec.Add(reader.GetString(0).ToString());
                }
            }
            for (int i = 0; i < rec.Count; i++)
            {
                injuredOption.Items.Add(rec[i]);
            }  
            m_dbConnection.Close();
        }
        private void loadMaterials()
        {
            m_dbConnection.Open();
            string sql = @"SELECT Name FROM Material";
            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            var rec = new List<string>();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rec.Add(reader.GetString(0).ToString());
                }
            }
            for (int i = 0; i < rec.Count; i++)
            {
                materialOption.Items.Add(rec[i]);
            }  
            m_dbConnection.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Define Regex Pattern
            Regex timeRegex = new Regex(@"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$");
            //Check Password against regex
            try
            {
                //Check all boxes are filled in
                if (!timeRegex.IsMatch(timeTextBox.Text))
                    throw new Exception("Invalid Time Format.");
                if (injuredOption.Text == "")
                    throw new Exception("Please add the name of the injured person.");
                if (recorderOption.Text == "")
                    throw new Exception("Please add the name of the recording person.");
                if (locationTextBox.Text == "")
                    throw new Exception("Please add a location.");
                if (howRichTextBox.Text == "")
                    throw new Exception("Please explain how the incident occurred.");
                if (materialOption.Text == "")
                    throw new Exception("Please select materials used.");
                //Get Injured and Recorder Person
                var injuredFullName = injuredOption.Text.Split();
                var recorderFullName = recorderOption.Text.Split();
                Person injured = getPerson(injuredFullName);
                Person recorder = getPerson(recorderFullName);
                //Add new Accident to database
                newAccident(injured, recorder);
            }
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }*/
            finally{}
        }

        private void newAccident(Person injured, Person recorder)
        {
            string AccidentID = "";
            //Add Accident to Database
            string sql = @"INSERT INTO Accident(Injured_Person, Recorder_Person, Date, Time, Location, How) VALUES (?,?,?,?,?,?);";
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection))
                {
                    cmd.Parameters.AddWithValue("Injured_Person", injured.personId);
                    cmd.Parameters.AddWithValue("Recorder_Person", recorder.personId);
                    cmd.Parameters.AddWithValue("Date", dateIncidentPicker.Value.Date.ToString());
                    cmd.Parameters.AddWithValue("Time", timeTextBox.Text);
                    cmd.Parameters.AddWithValue("Location", locationTextBox.Text);
                    cmd.Parameters.AddWithValue("How", howRichTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            //Obtain ID of the new Accident
            string sqlGetAccidentID = @$"SELECT ID FROM Accident
WHERE Injured_Person = '{injured.personId}' AND
Recorder_Person = '{recorder.personId}' AND
Time = '{timeTextBox.Text}' AND
Location = '{locationTextBox.Text}' AND
How = '{howRichTextBox.Text}';";
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sqlGetAccidentID, m_dbConnection))
                {
                    cmd.Parameters.AddWithValue("Injured_Person", injured.personId);
                    cmd.Parameters.AddWithValue("Recorder_Person", recorder.personId);
                    //cmd.Parameters.AddWithValue("Date", dateIncidentPicker.Value.Date.ToString());
                    cmd.Parameters.AddWithValue("Time", timeTextBox.Text);
                    cmd.Parameters.AddWithValue("Location", locationTextBox.Text);
                    cmd.Parameters.AddWithValue("How", howRichTextBox.Text);
                    Console.WriteLine(cmd.CommandText);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AccidentID = reader["ID"].ToString();
                        }
                    }
                }
            }
            //Make material list
            string[] matrialsUsed = materialsLabel.Text.Split("\n");
            Dictionary<string, int> materialCount = new Dictionary<string, int>();
            foreach (string word in matrialsUsed)
            {
                if (materialCount.ContainsKey(word))
                {
                    materialCount[word] += 1; 
                }
                else
                {
                    materialCount.Add(word,1);
                }
            }
            //Get Length of Dictionary
            int j = materialCount.Count;
            string materialID = "";
            //Get Material IDs
            sql = @"SELECT ID FROM Material WHERE Name = (?)";
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection))
                {
                    foreach(KeyValuePair<string, int> entry in materialCount)
                    {
                        cmd.Parameters.AddWithValue("Name", entry.Key);
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            materialID = rdr.GetValue(0).ToString();
                            addMaterialToDatabase(AccidentID, materialID, entry.Value.ToString());
                        }
                    }
                }
            }
        }

        private void addMaterialToDatabase(string accidentID, string materialID, string quantity)
        {
            string sql = @"INSERT INTO Accident_Material(Accident, Material, Quantity) VALUES (?,?,?);";
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection))
                {
                    cmd.Parameters.AddWithValue("Accident", accidentID);
                    cmd.Parameters.AddWithValue("Material", materialID);
                    cmd.Parameters.AddWithValue("Quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private Person getPerson(string[] fullName)
        {
            Person person = new Person();
            person.firstName = fullName[0];
            person.lastName = fullName[1];
            person.humanDataFill(2); //Add all human data
            person.addressDataFill(); //Add all address data
            return person;
        }

        private void addMaterialFormButton_Click(object sender, EventArgs e)
        {
            InputBox addMaterialForm = new InputBox();
            addMaterialForm.Show();
        }
        
        private void materialOption_DropDown(object sender, EventArgs e)
        {
            //Ensure items reloaded after add material
            materialOption.Items.Clear();
            loadMaterials();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            materialsLabel.Text = materialsLabel.Text + "\n" + materialOption.Text;
        }
    }
//    "SELECT a.FirstName || a.LastName
/*Link the Relationship*/
//    FROM Person as a
//    LEFT JOIN Person_Contact_Point as b on b.Person = a.id
/*Link the Contact Point and the Person(s) it relates to*/
//    LEFT JOIN Contact_Point as c on c.ID = b.Contact_Point
/*Link the Role of Person1*/
//    JOIN Person_Role as d on d.Person = a.id
/**/
//    JOIN Role_Type as e on e.ID = d.Role
/**/
//    LEFT JOIN Person_Address as f on f.Person = a.id
//    LEFT JOIN Address as g on g.ID = f.Address
//    WHERE e.name = 'Cub'"
}
