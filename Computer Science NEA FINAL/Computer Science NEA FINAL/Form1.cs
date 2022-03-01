using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Computer_Science_NEA_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void leaderLoginButton_Click(object sender, EventArgs e)
        {
            Login_Menu loginMenu = new Login_Menu("Leader Login Menu");
            loginMenu.Show();
            
            this.Hide();
        }

        private void parentLoginButton_Click(object sender, EventArgs e)
        {
            Login_Menu loginMenu = new Login_Menu("Parent Login Menu");
            loginMenu.Show();

            this.Hide();
        }
    }
}
