using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL.Resources
{
    public partial class BlogForm : Form
    {
        public BlogForm()
        {
            InitializeComponent();
            Browser1.Url = new Uri("https://www.1stlissscouts.org.uk/2019/08/cub-camp-day-5-2/");
        }

        private void BlogForm_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void Browser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
