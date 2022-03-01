using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Computer_Science_NEA_FINAL.Resources
{
    public partial class MedicalForm : Form
    {
        public MedicalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProvider.MainMenu.Show();
            this.Hide();
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            AddIncident incident = new AddIncident();
            incident.Show();
        }
    }
}
