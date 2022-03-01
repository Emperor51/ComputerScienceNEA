using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Computer_Science_NEA_FINAL
{
    public class Person
    {
        SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=NEA-Database.sqlite;Version=3;");
        
        //Attributes
        public int personId;
        public string username;
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string medication;
        public string notes;
        
        //Address Data
        public int addressId;
        public string line1;
        public string line2;
        public string line3;
        public string city;
        public string county;
        public string postCode;
        public string what3Words;
        
        //Fill in Data
        public void humanDataFill(int option)
        {
            //Open Database
            m_dbConnection.Open();
            string sql = "";
            using var cmd = new SQLiteCommand();
            cmd.Connection = m_dbConnection;
            //ID Option
            if (option == 1)
            {
                sql = @"SELECT * FROM Person WHERE id = (?)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id",personId.ToString());
            }
            else if (option == 2)
            {
                sql = @"SELECT * FROM Person WHERE FirstName = (?) AND LastName = (?)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("FirstName",firstName);
                cmd.Parameters.AddWithValue("LastName",lastName);
            }
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    personId = (int) (long) reader["id"];
                    username = reader["username"].ToString();
                    firstName = reader["firstName"].ToString();
                    lastName = reader["lastName"].ToString();
                    dateOfBirth = reader["dateOfBirth"].ToString();
                    medication = reader["medication"].ToString();
                    notes = reader["notes"].ToString();    
                }
            }
            m_dbConnection.Close();
        }

        public void addressDataFill()
        {
            //Open Database
            m_dbConnection.Open();
            string sql = @"SELECT c.ID, c.Line1, c.Line2, c.Line3, c.City, c.County, c.PostCode, c.What3Words
            FROM Person as a
            LEFT JOIN Person_Address as b on b.Person = a.id
            LEFT JOIN Address as c on c.ID = b.Address
            WHERE b.Person = (?)";
            using var cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.Parameters.AddWithValue("b.Person", personId.ToString());
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    addressId = (int) (long) reader["id"];
                    line1 = reader["Line1"].ToString();
                    line2 = reader["Line2"].ToString();
                    line3 = reader["Line3"].ToString();
                    city = reader["City"].ToString();
                    county = reader["County"].ToString();
                    postCode = reader["PostCode"].ToString();
                    what3Words = reader["What3Words"].ToString();
                }
            }
        }
    }
}