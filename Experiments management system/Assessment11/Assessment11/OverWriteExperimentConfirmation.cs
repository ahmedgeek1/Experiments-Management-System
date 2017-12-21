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
    public partial class OverWriteExperimentConfirmation : Form
    {
        Boolean buttonYesWasClicked = false;
        Boolean buttonNoWasClicked = false;

        public OverWriteExperimentConfirmation()
        {
            InitializeComponent();
            
        }

        private void btnConfirmOverWrite_Click(object sender, EventArgs e)
        {
            buttonYesWasClicked = true;
            this.Close();
        }

        public Boolean confirmation()
        {
            Boolean conf = false;
            if (buttonYesWasClicked) { conf = true;}
            else if (buttonNoWasClicked) { conf = false;}
            return conf;
        }
        public void showPromptMessage(int experimentNumber)
        {
            lblOverWritePompt.Text = "Are you sure you want to overwrite the experiment number " + experimentNumber + " ?"; 
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            buttonNoWasClicked = true;
            this.Close();
        }
    }
}
