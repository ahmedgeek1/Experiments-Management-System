using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment11
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void reviewExperienceDetails(string experimentNumber, string studentName, string experimentDescription, string color, string weight, string volume)
        {
            lblStudentName.Text = "Student Name: "+studentName;
            lblExperimentNumber.Text = "Experiment Number: " + experimentNumber.ToString();
            lblExperimentDescription.Text = "Experiment Description: "+experimentDescription;
            lblResultColor.Text = "Result Color: "+color;
            lblResultVolume.Text = "Result Volume: "+volume.ToString();
            lblResultWeight.Text = "Result Weight: "+weight.ToString();
        }

        private void lblExperimentDetailsPopup_Click(object sender, EventArgs e)
        {

        }
    }
}
