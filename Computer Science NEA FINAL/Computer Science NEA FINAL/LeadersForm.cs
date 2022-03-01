using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL.Resources
{
    public partial class LeadersForm : Form
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        private SQLiteDataAdapter _sqLiteDataAdapter;
        private DataTable _dataTable;
        private SQLiteCommandBuilder _sqLiteCommandBuilder;
        private SQLiteDataReader _sqLiteDataReader;
        public LeadersForm()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void LeadersForm_Load(object sender, EventArgs e)
        {
            try
            {
                m_dbConnection.Open();
                string sql = @"SELECT a.FirstName, c.desc as 'Contact Number', g.Line1, g.Line2, g.Line3, g.City, g.County, g.PostCode
/*Link the Relationship*/
FROM Person as a
LEFT JOIN Person_Contact_Point as b on b.Person = a.id
/*Link the Contact Point and the Person(s) it relates to*/
LEFT JOIN Contact_Point as c on c.ID = b.Contact_Point
/*Link the Role of Person1*/
JOIN Person_Role as d on d.Person = a.id
/**/
JOIN Role_Type as e on e.ID = d.Role
/**/
LEFT JOIN Person_Address as f on f.Person = a.id
LEFT JOIN Address as g on g.ID = f.Address
WHERE e.name = 'Leader'";
                _sqLiteDataAdapter = new SQLiteDataAdapter(sql, m_dbConnection);
                _dataTable = new DataTable();
                _sqLiteDataAdapter.Fill(_dataTable);
                dataGridView1.DataSource = _dataTable;
                m_dbConnection.Close();
            }
            catch
            {
                MessageBox.Show("Errored");
            }
        }
    }
}
