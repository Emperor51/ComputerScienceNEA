using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL
{
    public partial class InputBox : Form
    {
        
        
        public InputBox()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Material(name) VALUES (?);";
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection))
                {
                    cmd.Parameters.AddWithValue("Name", textBox1.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}