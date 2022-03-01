using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL.Resources
{
    public partial class LocationForm : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");

        public LocationForm()
        {
            InitializeComponent();
            string url = "";
            m_dbConnection.Open();
            string sql = "SELECT LocationURL FROM Camp";
            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                url = rdr.GetString(0);
            }
            try
            {
                Browser1.Url = new Uri($"{url}");
            }
            finally
            {

            }
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Show();
            this.Hide();
        }
    }
}
