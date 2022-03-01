using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL
{
    public partial class User_Creation_Menu : Form
    {
        
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        
        public User_Creation_Menu()
        {
            InitializeComponent();
        }

        private bool CheckPassword()
        {
            //Define Regex Pattern
            Regex rgx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            //Check Password against regex
            if (rgx.IsMatch(passwordBox.Text))
                return true; 
            MessageBox.Show("Password not strong enough");
            return false;
        }

        private void HashPassword()
        {
            //Create salt value with a cryptographic PRNG 
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            
            //Create the Rfc2898DeriveBytes and get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(passwordBox.Text, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            
            //Combine the salt and password bytes for later use
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            
            //Turn the combined salt+hash into a string for storage
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            
            //Open Database Connection
            m_dbConnection.Open();
            SQLiteCommand insertSql =
                new SQLiteCommand("INSERT INTO Login (username, hash) VALUES (?,?)", m_dbConnection);
            insertSql.CommandType = CommandType.Text;
            insertSql.Parameters.AddWithValue("username", usernameBox.Text);
            insertSql.Parameters.AddWithValue("hash", savedPasswordHash);
            insertSql.ExecuteNonQuery();
        }
        
        private void createButton_Click(object sender, EventArgs e)
        {
            bool checkPassword = CheckPassword();
            if (checkPassword == true)
                HashPassword();
            else
            {
                MessageBox.Show("Invalid Password");
            }
            
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}