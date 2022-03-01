using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Computer_Science_NEA_FINAL
{
    public partial class Login_Menu : Form
    {

        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");

        public Login_Menu(string label1Text)
        {
            InitializeComponent();
            this.label1.Text = label1Text;
            
        }

        private void hideCreate(int userType)
        {
            switch (userType)
            {
                case 1: FormProvider.userType = 1;
                    break;
                case 2: FormProvider.userType = 2;
                    break;
            }
        }
        
        
        private string ValidateLogin(string usernameBox, string passwordBox)
        {
            try  { m_dbConnection.Close(); }
            finally{}
            m_dbConnection.Open();
            string sql;
            
            ///Hash Command
            string savedPasswordHash = "";
            
            SQLiteCommand insertSql =
                new SQLiteCommand("SELECT hash FROM Login WHERE username = (?)", m_dbConnection);
            insertSql.CommandType = CommandType.Text;
            insertSql.Parameters.AddWithValue("username", usernameBox);
            
            using SQLiteDataReader rdr = insertSql.ExecuteReader();
            //Read Hash
            try
            {   if (rdr.HasRows)
                {   while (rdr.Read())
                    { savedPasswordHash = rdr.GetString(0); } }
                else {
                    throw new UnauthorizedAccessException("Invalid Username"); }
            }
            catch (UnauthorizedAccessException) { return "Denied"; }
            
            ///Auth Command
            int authLevel = 2;
            SQLiteCommand getAuthLevel =
                new SQLiteCommand(@"SELECT c.id
            FROM Login AS a
            JOIN Person_Role as b on b.Person = a.id
            JOIN Role_Type as c on c.id = b.Role
            WHERE a.username = (?)", m_dbConnection);
            getAuthLevel.CommandType = CommandType.Text;
            getAuthLevel.Parameters.AddWithValue("a.username", usernameBox);
            
            using SQLiteDataReader rdr2 = getAuthLevel.ExecuteReader();
            //Read Auth
            try
            {
                if (rdr2.HasRows)
                {
                    while (rdr2.Read())
                    {
                        authLevel = rdr2.GetInt16(0);
                        FormProvider.userType = authLevel;
                    }
                }
            }
            finally{}

            m_dbConnection.Close();

            // Extract the bytes 
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            // Get the salt 
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            // Compute the hash on the password the user entered 
            var pbkdf2 = new Rfc2898DeriveBytes(passwordBox, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            // Compare the results 
            try
            {
                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] != hash[i])
                        throw new UnauthorizedAccessException();
                    else
                    {
                        hideCreate(0);
                        return "Approved";
                        
                    }
                
                        
            }
            catch (UnauthorizedAccessException) { MessageBox.Show("Invalid Password", "Unauthorised Access Error"); }

            return "Denied";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validation = ValidateLogin(usernameBox.Text, passwordBox.Text);

            if (validation == "Approved")
            {
                FormProvider.MainMenu.Show();
                this.Close();
            }
            else if (validation == "Denied")
            {
                MessageBox.Show("Invalid Username and Password");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            User_Creation_Menu userCreationMenu = new User_Creation_Menu();
            userCreationMenu.Show();
        }
    }
}