using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL
{
    public partial class SixesForm : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        private SQLiteDataAdapter _sqLiteDataAdapter;
        private DataTable _dataTable;
        private SQLiteCommandBuilder _sqLiteCommandBuilder;
        private SQLiteDataReader _sqLiteDataReader;
        
        public SixesForm()
        {
            InitializeComponent();
            loadSixers();
            loadSixNames();
            loadMembers();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Show();
            this.Hide();
        }
        private void loadSixNames()
        {
            m_dbConnection.Open();
            for (int i = 1; i < 7; i++)
            {
                string sql = @"SELECT a.Name
FROM Six AS a
WHERE a.id = (?) ";
                using var cmd = new SQLiteCommand(sql, m_dbConnection);
                cmd.Parameters.AddWithValue("a.id",i.ToString());
                var rec = new List<string>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rec.Add(reader.GetString(0).ToString());
                    }
                }
            
                string result = string.Join("", rec);

                switch (i)
                {
                    case 1:
                        six1Label.Text = result; break;
                    case 2:
                        six2Label.Text = result; break;
                    case 3:
                        six3Label.Text = result; break;
                    case 4:
                        six4Label.Text = result; break;
                    case 5:
                        six5Label.Text = result; break;
                    case 6:
                        six6Label.Text = result; break;
                }
            }
            m_dbConnection.Close();
            
        }
        private void loadSixers()
        {
            m_dbConnection.Open();
            for (int i = 1; i < 7; i++)
            {
                string sql = @"SELECT b.FirstName || ' ' || b.LastName
FROM Six AS a
JOIN Person AS b ON b.id = a.Sixer
WHERE a.id = (?) ";
                using var cmd = new SQLiteCommand(sql, m_dbConnection);
                cmd.Parameters.AddWithValue("a.id",i.ToString());
                var rec = new List<string>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rec.Add(reader.GetString(0).ToString());
                    }
                }
            
                string result = string.Join("\n", rec);

                switch (i)
                {
                    case 1:
                        six1Sixer.Text = result; break;
                    case 2:
                        six2Sixer.Text = result; break;
                    case 3:
                        six3Sixer.Text = result; break;
                    case 4:
                        six4Sixer.Text = result; break;
                    case 5:
                        six5Sixer.Text = result; break;
                    case 6:
                        six6Sixer.Text = result; break;
                }
            }
            m_dbConnection.Close();
        }
        private void loadMembers()
        {
            m_dbConnection.Open();
            for (int i = 1; i < 7; i++)
            {
                string sql = @"SELECT d.FirstName || ' ' || d.LastName
FROM Six AS a
JOIN Six_Membership AS c ON c.Six = a.id
JOIN Person AS d ON d.id = c.Person
WHERE a.id = (?)";
                using var cmd = new SQLiteCommand(sql, m_dbConnection);
                cmd.Parameters.AddWithValue("a.id",i.ToString());
                var rec = new List<string>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rec.Add(reader.GetString(0).ToString());
                    }
                }
            
                string result = string.Join("\n", rec);

                switch (i)
                {
                    case 1:
                        six1People.Text = result; break;
                    case 2:
                        six2People.Text = result; break;
                    case 3:
                        six3People.Text = result; break;
                    case 4:
                        six4People.Text = result; break;
                    case 5:
                        six5People.Text = result; break;
                    case 6:
                        six6People.Text = result; break;
                }
            }
            
            m_dbConnection.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is not yet implimented");
        }
    }
}
