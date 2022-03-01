using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Computer_Science_NEA_FINAL
{
    public partial class Camp_Editor : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");

        public Camp_Editor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Camp_Editor_Load(object sender, EventArgs e)
        {

            m_dbConnection.Open();
            string sql = "SELECT * FROM Camp";

            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<string> MenuContents = new List<string>();

            while (rdr.Read())
            {
                if (rdr.IsDBNull(1))
                {
                    
                }
                else
                {
                    MenuContents.Add(rdr.GetString(1));
                    MenuContents.Add(rdr.GetString(2));
                    MenuContents.Add(rdr.GetString(3));
                }
            }
            campNameTextBox.Text = MenuContents[0];
            locationTextBox.Text = MenuContents[1];
            locationURLTextBox.Text = MenuContents[2];
        }

        private void applyCampEdits_Click(object sender, EventArgs e)
        {
            SQLiteCommand sqlUpdate = new SQLiteCommand(@"UPDATE Camp SET
                                                        CampName = (?),
                                                        Location = (?),
                                                        LocationURL = (?) WHERE ID = 1", m_dbConnection);
            sqlUpdate.Parameters.AddWithValue("CampName", campNameTextBox.Text);
            sqlUpdate.Parameters.AddWithValue("Location", locationTextBox.Text);
            sqlUpdate.Parameters.AddWithValue("LocationURL", locationURLTextBox.Text);
            sqlUpdate.ExecuteNonQuery();
            Main_Menu mainMenu = new Main_Menu();
            mainMenu.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
