/* Application interest by adding multiple forms on the screen simultaneously
 * Week12 assessment
 * C# part I
 * Ahmed MATOUSSI
 * ahmedgeek1@gmail.com
 */
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
    public partial class Form1 : Form
    {
        //declaring some global variables tto the form, can be used in any method in this form
        Experiment exp;
        Boolean experienceHasBeenSet = false, experienceSetted = false, experimentSaved = false, experienceHasBeenSetAfterEditing=false;
        Boolean overwrite = false;
        int countNumberOfExperiments = 0, indexListBox = 0;
        string[] Experiments = new string[51];
        int[] ExperimentsNumber = new int[51];
        int[] ExperimentsNumberAndListBxIndex = new int[51];
        string[,] ExperimentDetArray = new string[51, 7];
        int index, experimentNumberlimit;
        public Form1()
        {
            //initializing the components
            InitializeComponent();
            //set the form of editing details to invisible until an experiment gets created or a radio button is selected
            txtBoxStudentNameKnown.Visible = false;
            txtExperimentNumberKnown.Visible = false;
            richTextBoxExperimentDescription.Visible = false;
            lblExperimentDescriptionKnownPrompt.Visible = false;
            lblExperimentNumberKnownPrompt.Visible = false;
            groupBoxExperimentDetailsEdit.Visible = false;
        }


        private void btnCreateExperiment_Click(object sender, EventArgs e)
        {

            if (countNumberOfExperiments <= 50)
            {//if the number of experiments is over 50, then don't allow the user to add more
                if (radioButtonNothingIsKnown.Checked)
                {   //if the radion button of nothing known is selected, then create a new experiment using the default constructor
                    exp = new Experiment();
                    groupBoxExperimentDetailsEdit.Visible = true; //make the groupbox of editing the details of the experiment after creating it to visible
                    experienceHasBeenSet = true; //to show that the experiment has been created
                }
                else if (radioButtonStudentNameOnly.Checked)
                {//if the student name only is knon and the radion button is the one selected
                    if (txtBoxStudentNameKnown.Text != "") //data validation, student name should not be empty
                    {
                        int studentName;
                        if (!int.TryParse(txtBoxStudentNameKnown.Text, out studentName))
                        {   //if student name is valid, not numeric, then 
                            exp = new Experiment(txtBoxStudentNameKnown.Text); //create experiment using the construct passing the student name entered as a parameter
                            exp.StudentName = txtBoxStudentNameKnown.Text; //the experiment student name in the memory gets the name of the student entered in the textbox
                            txtBoxStudentNameEdit.Text = exp.StudentName; //the student name edit get the student name created and stored in the memory
                            groupBoxExperimentDetailsEdit.Visible = true; //show the group box to edit experiment details
                            experienceHasBeenSet = true; //experiment has been created
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid student name"); //else show validation message
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the student name!"); //else show validation message
                    }

                }
                else if (radioButtonExperimentNumberAndDescription.Checked)
                { //if the experiment number and the experiment description radio button option is checked
                    int experimentNumber;
                    if (int.TryParse(txtExperimentNumberKnown.Text, out experimentNumber))
                    {   //data validation on the experiment number
                        if (richTextBoxExperimentDescription.Text != "")
                        {
                            if(experimentNumber>0 && experimentNumber <= 50)
                            {
                                //datavalidation on the experiment description
                                exp = new Experiment(experimentNumber, txtBoxStudentNameKnown.Text); //create the experiment using the constructor with 2 parameters passed in
                                exp.ExperimentNumber = experimentNumber; //the experiment number in memory store the current experiment number entered in the textbox by the user
                                exp.ExperimentDescription = richTextBoxExperimentDescription.Text; //the experiment description in memory store the current experiment description entered in the richtextbox by the user
                                txtBoxExperimentNumberEdit.Text = exp.ExperimentNumber.ToString(); // the textbox in the edit form, gets the experiment number stored in the memory
                                richTextBoxExperimentDescriptionEdit.Text = exp.ExperimentDescription; //the rich textbox edit gets the experiment description stored in the memory
                                groupBoxExperimentDetailsEdit.Visible = true; //make the groupbox visible
                                experienceHasBeenSet = true; //experience has been created
                            }else
                            {
                                MessageBox.Show("Experiment number should be between 0 and 50");//else show validation message

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a description for the experiment");//else show validation message
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Experiment Number");//else show validation message
                    }


                }
            }
            else
            {
                MessageBox.Show("You have exceeded the number of the experiments allowed!\n You are no longer able to add other experiments!"); //else show message to tell the user that he exceded the number of possible experiment to be created
                //disable the controls button
                btnCreateExperiment.Visible = false; 
                btnSet.Visible = false;
                btnSave.Visible = false;
            }
            if (experienceHasBeenSet)
            {   //if the experiment has been created then set all the radio button, the textboxes of the first group bpx to readonly, to not allow the user to change and mess up with the memory object created
                txtBoxStudentNameKnown.ReadOnly = true;
                txtExperimentNumberKnown.ReadOnly = true;
                richTextBoxExperimentDescription.ReadOnly = true;
                radioButtonExperimentNumberAndDescription.AutoCheck = false;
                radioButtonStudentNameOnly.AutoCheck = false;
                radioButtonNothingIsKnown.AutoCheck = false;
                btnCreateExperiment.Visible = false;
                MessageBox.Show("An experiment has been created, Please edit it using the form below!"); //prompt user with creation of an experiment
            }
        }

        private void radioButtonExperimentNumberAndDescription_CheckedChanged(object sender, EventArgs e)
        {
            //if the radion button checked then show the textboxes and richboxes that allow the user to enter details accordongly
            if (radioButtonExperimentNumberAndDescription.Checked)
            {
                txtExperimentNumberKnown.Visible = true;
                richTextBoxExperimentDescription.Visible = true;
                lblExperimentDescriptionKnownPrompt.Visible = true;
                lblExperimentNumberKnownPrompt.Visible = true;
            }
            else
            {
                txtExperimentNumberKnown.Visible = false;
                richTextBoxExperimentDescription.Visible = false;
                lblExperimentDescriptionKnownPrompt.Visible = false;
                lblExperimentNumberKnownPrompt.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonStudentNameOnly_CheckedChanged(object sender, EventArgs e)
        {//if the radion button checked then show the textboxes and richboxes that allow the user to enter details accordongly
            if (radioButtonStudentNameOnly.Checked)
            {
                txtBoxStudentNameKnown.Visible = true;
            }
            else
            {
                txtBoxStudentNameKnown.Visible = false;
            }

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int experimentNumber;
            double resultVolume, resultWeight, resultColor;

            //data validation on the textboxes and the user entries
            if (int.TryParse(txtBoxExperimentNumberEdit.Text, out experimentNumber))
            {
                if (experimentNumber > 0 && experimentNumber <= 50)
                {
                    if (double.TryParse(txtBoxResultVolumeAdd.Text, out resultVolume) || txtBoxResultVolumeAdd.Text == "")
                    {
                        if (double.TryParse(txtBoxResultWeightAdd.Text, out resultWeight) || txtBoxResultWeightAdd.Text == "")
                        {
                            /* if (!double.TryParse(txtBoxResultColorAdd.Text, out resultColor) || txtBoxResultColorAdd.Text == "")
                            {*/
                            for (int i = 0; i < ExperimentsNumber.Length; i++)
                            {
                                if (Experiments[i] != null)
                                {
                                    if (ExperimentsNumber[i] == experimentNumber)
                                    {// if the experiment number is equal to another experiment number saved in the listbox and the array, then show an overwrite form class
                                        OverWriteExperimentConfirmation OverWriteWindowConfirmation = new OverWriteExperimentConfirmation();
                                        OverWriteWindowConfirmation.showPromptMessage(experimentNumber);
                                        OverWriteWindowConfirmation.StartPosition = FormStartPosition.CenterParent;
                                        OverWriteWindowConfirmation.ShowDialog();
                                        if (OverWriteWindowConfirmation.confirmation())
                                        { //here code after confirmation
                                            exp.StudentName = txtBoxStudentNameEdit.Text;
                                            exp.ExperimentNumber = experimentNumber;
                                            exp.ExperimentDescription = richTextBoxExperimentDescriptionEdit.Text;
                                            exp.ResultVolume = resultVolume;
                                            exp.ResultColor = txtBoxResultColorAdd.Text;
                                            exp.ResultWeight = resultWeight;
                                            experienceHasBeenSet = true;
                                            experienceSetted = true;
                                            overwrite = true;
                                        }
                                        else
                                        {//if no overwrite confirmed then the user should change the experiment number
                                            txtBoxExperimentNumberEdit.Focus();
                                        }

                                    }
                                    else
                                    {//else if the experiment number does  not match with any of the experiment numbers saved before then add it normally to the memory
                                        exp.StudentName = txtBoxStudentNameEdit.Text;
                                        exp.ExperimentNumber = experimentNumber;
                                        exp.ExperimentDescription = richTextBoxExperimentDescriptionEdit.Text;
                                        exp.ResultVolume = resultVolume;
                                        //exp.ResultColor = txtBoxResultColorAdd.Text;
                                        if (comboBoxColors.SelectedIndex != -1)
                                        {
                                            exp.ResultColor = comboBoxColors.SelectedItem.ToString();
                                        }
                                        exp.ResultWeight = resultWeight;
                                        experienceHasBeenSet = true;
                                        experienceSetted = true;
                                    }
                                }
                                else
                                {
                                    exp.StudentName = txtBoxStudentNameEdit.Text;
                                    exp.ExperimentNumber = experimentNumber;
                                    exp.ExperimentDescription = richTextBoxExperimentDescriptionEdit.Text;
                                    exp.ResultVolume = resultVolume;
                                    //exp.ResultColor = txtBoxResultColorAdd.Text;
                                    if (comboBoxColors.SelectedIndex != -1)
                                    {
                                        exp.ResultColor = comboBoxColors.SelectedItem.ToString();

                                    }
                                    else
                                    {
                                        exp.ResultColor = "";
                                        //MessageBox.Show(exp.ResultColor);
                                    }


                                    exp.ResultWeight = resultWeight;
                                    experienceHasBeenSet = true;
                                    experienceSetted = true;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a color");//else show validation message
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid result Weight");//else show validation message
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid result Volume");//else show validation message
                }

                /* }
                 else
                 {
                     MessageBox.Show("Please enter a valid integer experiment number");//else show validation message
                 }*/

                /*if (experienceSetted)
                {
                    MessageBox.Show("Experiment details have been set, if you have setted all its details please save it!"); //prompt user
                }*/
            }else
            {
                MessageBox.Show("Experiment number should be between 0 and 50");//else show validation message
        }
    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (experienceHasBeenSet)
            {//if experiment created and setted after editing
                //data validation on the textboxes and the user entries
                //all data should be setted properly
                if (exp.StudentName != "")
                {
                    if (exp.ExperimentNumber != 0)
                    {
                        if (exp.ExperimentDescription != "")
                        {
                            if (exp.ResultColor != "")
                            {
                                if (exp.ResultWeight != 0)
                                {
                                    if (exp.ResultVolume != 0)
                                    {
                                        if (overwrite)
                                        {//if overwrite then get the listbox index from the table, using the experiment number entered
                                            int vr = ExperimentsNumberAndListBxIndex[exp.ExperimentNumber];
                                            //save the details of the new experiment to overwrite and change the experiment details in the array
                                            ExperimentDetArray[vr, 0] = indexListBox.ToString();
                                            ExperimentDetArray[vr, 1] = exp.StudentName;
                                            ExperimentDetArray[vr, 2] = exp.ExperimentNumber.ToString();
                                            ExperimentDetArray[vr, 3] = exp.ExperimentDescription;
                                            ExperimentDetArray[vr, 4] = exp.ResultWeight.ToString();
                                            ExperimentDetArray[vr, 5] = exp.ResultColor;
                                            ExperimentDetArray[vr, 6] = exp.ResultVolume.ToString();
                                        }
                                        else
                                        {   //save the experiment details in the table normally with the next empty index in the array
                                            ExperimentDetArray[indexListBox, 0] = indexListBox.ToString();
                                            ExperimentDetArray[indexListBox, 1] = exp.StudentName;
                                            ExperimentDetArray[indexListBox, 2] = exp.ExperimentNumber.ToString();
                                            ExperimentDetArray[indexListBox, 3] = exp.ExperimentDescription;
                                            ExperimentDetArray[indexListBox, 4] = exp.ResultWeight.ToString();
                                            ExperimentDetArray[indexListBox, 5] = exp.ResultColor;
                                            ExperimentDetArray[indexListBox, 6] = exp.ResultVolume.ToString();
                                        }
                                        //add the line to the listbox
                                        Experiments[exp.ExperimentNumber] = "Experiment Number: " + exp.ExperimentNumber + "\t Experience Description: " +
                                         exp.ExperimentDescription;
                                        listBoxExperiments.Items.Add(Experiments[exp.ExperimentNumber]);
                                        //show a message confirmation that the expriment has been saved successfulyy and disable all edit groupbox and allow the user to create new experiment using 1st groupbox
                                        btnCreateExperiment.Visible = true;
                                        txtBoxStudentNameKnown.ReadOnly = false;
                                        txtExperimentNumberKnown.ReadOnly = false;
                                        richTextBoxExperimentDescription.ReadOnly = false;
                                        radioButtonExperimentNumberAndDescription.AutoCheck = true;
                                        radioButtonStudentNameOnly.AutoCheck = true;
                                        radioButtonNothingIsKnown.AutoCheck = true;

                                        if (!overwrite)
                                        {   //if it's not overwrite
                                            ExperimentsNumberAndListBxIndex[exp.ExperimentNumber] = indexListBox;
                                            indexListBox++; //index of the listbox increment
                                            countNumberOfExperiments++; //number of experiments increment 
                                        }

                                       

                                        ExperimentsNumber[exp.ExperimentNumber] = exp.ExperimentNumber;
                                        experienceHasBeenSet = false;
                                        MessageBox.Show("Thank you for adding a new experiement! \n If you want to create a new experiment, please use the same process.");
                                        //clearing the group box fields
                                        groupBoxExperimentDetailsEdit.Visible = false;
                                        radioButtonExperimentNumberAndDescription.Checked = false;
                                        radioButtonNothingIsKnown.Checked = false;
                                        radioButtonStudentNameOnly.Checked = false;
                                        txtBoxStudentNameKnown.Text = "";
                                        richTextBoxExperimentDescription.Text = "";
                                        txtExperimentNumberKnown.Text = "";
                                        txtBoxExperimentNumberEdit.Text = "";
                                        txtBoxStudentNameEdit.Text = "";
                                        //txtBoxResultColorAdd.Text = "";
                                        comboBoxColors.SelectedIndex = -1;
                                       // MessageBox.Show(comboBoxColors.SelectedValue.ToString());
                                        txtBoxResultVolumeAdd.Text = "";
                                        txtBoxResultWeightAdd.Text = "";
                                        if (overwrite)
                                        {   
                                            overwrite = false;
                                            // MessageBox.Show("index list box - how many indexes until now: " + indexListBox);
                                            // MessageBox.Show(ExperimentDetArray[indexListBox, 1]);

                                            // here the problem
                                            //  MessageBox.Show(ExperimentsNumberAndListBxIndex[exp.ExperimentNumber].ToString());
                                            listBoxExperiments.Items.RemoveAt(ExperimentsNumberAndListBxIndex[exp.ExperimentNumber]);

                                            ExperimentDetArray[indexListBox, 0] = "";
                                            ExperimentDetArray[indexListBox, 1] = "";
                                            ExperimentDetArray[indexListBox, 2] = "";
                                            ExperimentDetArray[indexListBox, 3] = "";
                                            ExperimentDetArray[indexListBox, 4] = "";
                                            ExperimentDetArray[indexListBox, 5] = "";
                                            ExperimentDetArray[indexListBox, 6] = "";

                                            //MessageBox.Show(ExperimentDetArray[indexListBox, 1]);

                                            ExperimentDetArray[indexListBox, 0] = indexListBox.ToString();
                                            ExperimentDetArray[indexListBox, 1] = exp.StudentName;
                                            ExperimentDetArray[indexListBox, 2] = exp.ExperimentNumber.ToString();
                                            ExperimentDetArray[indexListBox, 3] = exp.ExperimentDescription;
                                            ExperimentDetArray[indexListBox, 4] = exp.ResultWeight.ToString();
                                            ExperimentDetArray[indexListBox, 5] = exp.ResultColor;
                                            ExperimentDetArray[indexListBox, 6] = exp.ResultVolume.ToString();

                                            //MessageBox.Show(ExperimentDetArray[indexListBox, 1]);

                                            listBoxExperiments.Items.Clear(); //clear all listbox items
                                            for (int i = 0; i < indexListBox; i++)
                                            {
                                                //add all listbox items from the table details corresponding with the listboxindex and the experiment number in the array 
                                                //MessageBox.Show("exp number " + ExperimentDetArray[i, 2]);
                                                string line = "Experiment Number: " + ExperimentDetArray[i, 2] + "\t Experience Description: " +
                                                 ExperimentDetArray[i, 3];
                                                listBoxExperiments.Items.Add(line);
                                                experimentSaved = true;
                                            }

                                            if (experimentSaved)
                                            {
                                                //if experiment saved then allow the user to add new experiment
                                                btnCreateExperiment.Visible = true;
                                                txtBoxStudentNameKnown.ReadOnly = false;
                                                txtExperimentNumberKnown.ReadOnly = false;
                                                richTextBoxExperimentDescription.ReadOnly = false;
                                                radioButtonExperimentNumberAndDescription.AutoCheck = true;
                                                radioButtonStudentNameOnly.AutoCheck = true;
                                                radioButtonNothingIsKnown.AutoCheck = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please set a result Volume!");//else show validation message
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please set a result weight");//else show validation message
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please set a result Color");//else show validation message
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please set the experiment description");//else show validation message
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please set the experiment number!");//else show validation message
                    }
                }
                else
                {
                    MessageBox.Show("Please set the student name for this experiment!");//else show validation message
                }

            }
            else
            {
                MessageBox.Show("Please set details of an experience before saving it!"); //show the message to prompt user to set details before saving it
            }
        }

        private void listBoxExperiments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxExperiments.SelectedItem != null)
            {   //if an item is selected in the listbox, then show the form and pass the details of that experiment selected according the the index and the experiment number
                Review reviewForm = new Review();
                reviewForm.StartPosition = FormStartPosition.CenterParent; ///center the form
                //pass all details to the experiment details using the method
                reviewForm.reviewExperienceDetails(
                 ExperimentDetArray[listBoxExperiments.SelectedIndex, 2],
                 ExperimentDetArray[listBoxExperiments.SelectedIndex, 1],
                 ExperimentDetArray[listBoxExperiments.SelectedIndex, 3],
                 ExperimentDetArray[listBoxExperiments.SelectedIndex, 5],
                 ExperimentDetArray[listBoxExperiments.SelectedIndex, 4],
                 ExperimentDetArray[listBoxExperiments.SelectedIndex, 6]);
                reviewForm.ShowDialog(); //show the dialog
            }
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxColors.SelectedItem.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   //make the groupbox edit invisible
            //clear all textboxes
            //empty all array
            //set all booleans to false
            //clear all items in the listbox
            //allow the user to create new experiment
            //set nulll to all indexes or incrementter used
            groupBoxExperimentDetailsEdit.Visible = false;
            radioButtonExperimentNumberAndDescription.Checked = false;
            radioButtonNothingIsKnown.Checked = false;
            radioButtonStudentNameOnly.Checked = false;
            txtBoxStudentNameKnown.Text = "";
            richTextBoxExperimentDescription.Text = "";
            txtExperimentNumberKnown.Text = "";
            txtBoxExperimentNumberEdit.Text = "";
            txtBoxStudentNameEdit.Text = "";
            //txtBoxResultColorAdd.Text = "";
            comboBoxColors.SelectedValue = false;
            txtBoxResultVolumeAdd.Text = "";
            txtBoxResultWeightAdd.Text = "";
            txtBoxStudentNameKnown.ReadOnly = false;
            txtExperimentNumberKnown.ReadOnly = false;
            richTextBoxExperimentDescription.ReadOnly = false;
            radioButtonExperimentNumberAndDescription.AutoCheck = true;
            radioButtonStudentNameOnly.AutoCheck = true;
            radioButtonNothingIsKnown.AutoCheck = true;
            btnCreateExperiment.Visible = true;

            listBoxExperiments.Items.Clear();
            Array.Clear(ExperimentDetArray, 0, ExperimentDetArray.Length);
            Array.Clear(Experiments, 0, Experiments.Length);
            Array.Clear(ExperimentsNumber, 0, ExperimentsNumber.Length);
            Array.Clear(ExperimentsNumberAndListBxIndex, 0, ExperimentsNumberAndListBxIndex.Length);
            experienceHasBeenSet = false;
            overwrite = false;
            experimentSaved = false;
            experienceHasBeenSetAfterEditing = false;
            countNumberOfExperiments = 0;
            indexListBox = 0;
            index = 0;
            exp = null; //destroy/set to null the experiment object created in memory
            createExperiment();//declate a new default object exoeriment 
        }

        private void createExperiment()
        {//declaration of experiment from a class
            Experiment exp;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}