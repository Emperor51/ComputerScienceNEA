using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Computer_Science_NEA_FINAL
{
    public partial class Main_Menu : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        
        public Main_Menu()
        {
            InitializeComponent();
            authCheck();
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
                }
            }
            CampTitleLabel.Text = MenuContents[0];
        }

        private void authCheck()
        {
            if (FormProvider.userType == 1)
                editCamp.Show();
            else
                editCamp.Hide();
        }
        private static string ReadSingleRow(IDataRecord record)
        {
            return String.Format("{0}", record[0]);
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void editCamp_Click(object sender, EventArgs e)
        {
            Camp_Editor campEditor = new Camp_Editor();
            campEditor.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormProvider.LocationForm.Show();
                this.Hide();
            }
            catch (UriFormatException)
            {
                MessageBox.Show("No Valid URL");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProvider.ItineraryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProvider.SixesForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormProvider.Menu_Form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormProvider.MedicalForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormProvider.BlogForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormProvider.GalleryForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormProvider.CubDetailsFormLeaders.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormProvider.LeadersForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormProvider.PastCampsForm.Show();
            this.Hide();
        }
    }
}
