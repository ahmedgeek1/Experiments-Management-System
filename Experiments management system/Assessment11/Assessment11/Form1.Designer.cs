namespace Assessment11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateExperiment = new System.Windows.Forms.Button();
            this.groupBoxRadios = new System.Windows.Forms.GroupBox();
            this.richTextBoxExperimentDescription = new System.Windows.Forms.RichTextBox();
            this.lblExperimentNumberKnownPrompt = new System.Windows.Forms.Label();
            this.lblExperimentDescriptionKnownPrompt = new System.Windows.Forms.Label();
            this.txtExperimentNumberKnown = new System.Windows.Forms.TextBox();
            this.radioButtonExperimentNumberAndDescription = new System.Windows.Forms.RadioButton();
            this.txtBoxStudentNameKnown = new System.Windows.Forms.TextBox();
            this.radioButtonStudentNameOnly = new System.Windows.Forms.RadioButton();
            this.radioButtonNothingIsKnown = new System.Windows.Forms.RadioButton();
            this.txtBoxResultVolumeAdd = new System.Windows.Forms.TextBox();
            this.txtBoxResultWeightAdd = new System.Windows.Forms.TextBox();
            this.txtBoxResultColorAdd = new System.Windows.Forms.TextBox();
            this.txtBoxExperimentNumberEdit = new System.Windows.Forms.TextBox();
            this.txtBoxStudentNameEdit = new System.Windows.Forms.TextBox();
            this.richTextBoxExperimentDescriptionEdit = new System.Windows.Forms.RichTextBox();
            this.lblResultWeightEditPrompt = new System.Windows.Forms.Label();
            this.lblResultColorEditPrompt = new System.Windows.Forms.Label();
            this.lblExperimentDescriptionEditPrompt = new System.Windows.Forms.Label();
            this.lblExperimentNumberEditPrompt = new System.Windows.Forms.Label();
            this.lblStudentNameEditPrompt = new System.Windows.Forms.Label();
            this.lblResultVolumeEditPrompt = new System.Windows.Forms.Label();
            this.groupBoxExperimentDetailsEdit = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.listBoxExperiments = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExperimentsSummary = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBoxRadios.SuspendLayout();
            this.groupBoxExperimentDetailsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateExperiment
            // 
            this.btnCreateExperiment.BackColor = System.Drawing.Color.Firebrick;
            this.btnCreateExperiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExperiment.ForeColor = System.Drawing.Color.White;
            this.btnCreateExperiment.Location = new System.Drawing.Point(819, 115);
            this.btnCreateExperiment.Name = "btnCreateExperiment";
            this.btnCreateExperiment.Size = new System.Drawing.Size(194, 67);
            this.btnCreateExperiment.TabIndex = 0;
            this.btnCreateExperiment.Text = "Create an experiment";
            this.btnCreateExperiment.UseVisualStyleBackColor = false;
            this.btnCreateExperiment.Click += new System.EventHandler(this.btnCreateExperiment_Click);
            // 
            // groupBoxRadios
            // 
            this.groupBoxRadios.Controls.Add(this.richTextBoxExperimentDescription);
            this.groupBoxRadios.Controls.Add(this.lblExperimentNumberKnownPrompt);
            this.groupBoxRadios.Controls.Add(this.lblExperimentDescriptionKnownPrompt);
            this.groupBoxRadios.Controls.Add(this.txtExperimentNumberKnown);
            this.groupBoxRadios.Controls.Add(this.radioButtonExperimentNumberAndDescription);
            this.groupBoxRadios.Controls.Add(this.txtBoxStudentNameKnown);
            this.groupBoxRadios.Controls.Add(this.radioButtonStudentNameOnly);
            this.groupBoxRadios.Controls.Add(this.radioButtonNothingIsKnown);
            this.groupBoxRadios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadios.Location = new System.Drawing.Point(27, 45);
            this.groupBoxRadios.Name = "groupBoxRadios";
            this.groupBoxRadios.Size = new System.Drawing.Size(683, 214);
            this.groupBoxRadios.TabIndex = 1;
            this.groupBoxRadios.TabStop = false;
            this.groupBoxRadios.Text = "Create Experiment";
            // 
            // richTextBoxExperimentDescription
            // 
            this.richTextBoxExperimentDescription.Location = new System.Drawing.Point(341, 132);
            this.richTextBoxExperimentDescription.Name = "richTextBoxExperimentDescription";
            this.richTextBoxExperimentDescription.Size = new System.Drawing.Size(323, 56);
            this.richTextBoxExperimentDescription.TabIndex = 5;
            this.richTextBoxExperimentDescription.Text = "";
            // 
            // lblExperimentNumberKnownPrompt
            // 
            this.lblExperimentNumberKnownPrompt.Location = new System.Drawing.Point(5, 140);
            this.lblExperimentNumberKnownPrompt.Name = "lblExperimentNumberKnownPrompt";
            this.lblExperimentNumberKnownPrompt.Size = new System.Drawing.Size(99, 37);
            this.lblExperimentNumberKnownPrompt.TabIndex = 2;
            this.lblExperimentNumberKnownPrompt.Text = "Experiment Number";
            this.lblExperimentNumberKnownPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExperimentDescriptionKnownPrompt
            // 
            this.lblExperimentDescriptionKnownPrompt.Location = new System.Drawing.Point(206, 142);
            this.lblExperimentDescriptionKnownPrompt.Name = "lblExperimentDescriptionKnownPrompt";
            this.lblExperimentDescriptionKnownPrompt.Size = new System.Drawing.Size(130, 32);
            this.lblExperimentDescriptionKnownPrompt.TabIndex = 3;
            this.lblExperimentDescriptionKnownPrompt.Text = "Experiment Description";
            this.lblExperimentDescriptionKnownPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExperimentNumberKnown
            // 
            this.txtExperimentNumberKnown.Location = new System.Drawing.Point(110, 148);
            this.txtExperimentNumberKnown.Name = "txtExperimentNumberKnown";
            this.txtExperimentNumberKnown.Size = new System.Drawing.Size(58, 21);
            this.txtExperimentNumberKnown.TabIndex = 3;
            this.txtExperimentNumberKnown.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButtonExperimentNumberAndDescription
            // 
            this.radioButtonExperimentNumberAndDescription.AutoSize = true;
            this.radioButtonExperimentNumberAndDescription.Location = new System.Drawing.Point(20, 109);
            this.radioButtonExperimentNumberAndDescription.Name = "radioButtonExperimentNumberAndDescription";
            this.radioButtonExperimentNumberAndDescription.Size = new System.Drawing.Size(461, 19);
            this.radioButtonExperimentNumberAndDescription.TabIndex = 2;
            this.radioButtonExperimentNumberAndDescription.TabStop = true;
            this.radioButtonExperimentNumberAndDescription.Text = "Only the Experiment Number and Experiment Description are known";
            this.radioButtonExperimentNumberAndDescription.UseVisualStyleBackColor = true;
            this.radioButtonExperimentNumberAndDescription.CheckedChanged += new System.EventHandler(this.radioButtonExperimentNumberAndDescription_CheckedChanged);
            // 
            // txtBoxStudentNameKnown
            // 
            this.txtBoxStudentNameKnown.Location = new System.Drawing.Point(220, 70);
            this.txtBoxStudentNameKnown.Name = "txtBoxStudentNameKnown";
            this.txtBoxStudentNameKnown.Size = new System.Drawing.Size(100, 21);
            this.txtBoxStudentNameKnown.TabIndex = 2;
            // 
            // radioButtonStudentNameOnly
            // 
            this.radioButtonStudentNameOnly.AutoSize = true;
            this.radioButtonStudentNameOnly.Location = new System.Drawing.Point(20, 70);
            this.radioButtonStudentNameOnly.Name = "radioButtonStudentNameOnly";
            this.radioButtonStudentNameOnly.Size = new System.Drawing.Size(195, 19);
            this.radioButtonStudentNameOnly.TabIndex = 1;
            this.radioButtonStudentNameOnly.TabStop = true;
            this.radioButtonStudentNameOnly.Text = "Only Student Name Known";
            this.radioButtonStudentNameOnly.UseVisualStyleBackColor = true;
            this.radioButtonStudentNameOnly.CheckedChanged += new System.EventHandler(this.radioButtonStudentNameOnly_CheckedChanged);
            // 
            // radioButtonNothingIsKnown
            // 
            this.radioButtonNothingIsKnown.AutoSize = true;
            this.radioButtonNothingIsKnown.Location = new System.Drawing.Point(20, 31);
            this.radioButtonNothingIsKnown.Name = "radioButtonNothingIsKnown";
            this.radioButtonNothingIsKnown.Size = new System.Drawing.Size(135, 19);
            this.radioButtonNothingIsKnown.TabIndex = 0;
            this.radioButtonNothingIsKnown.TabStop = true;
            this.radioButtonNothingIsKnown.Text = "Nothing is known";
            this.radioButtonNothingIsKnown.UseVisualStyleBackColor = true;
            // 
            // txtBoxResultVolumeAdd
            // 
            this.txtBoxResultVolumeAdd.Location = new System.Drawing.Point(356, 223);
            this.txtBoxResultVolumeAdd.Name = "txtBoxResultVolumeAdd";
            this.txtBoxResultVolumeAdd.Size = new System.Drawing.Size(100, 21);
            this.txtBoxResultVolumeAdd.TabIndex = 2;
            // 
            // txtBoxResultWeightAdd
            // 
            this.txtBoxResultWeightAdd.Location = new System.Drawing.Point(190, 174);
            this.txtBoxResultWeightAdd.Name = "txtBoxResultWeightAdd";
            this.txtBoxResultWeightAdd.Size = new System.Drawing.Size(100, 21);
            this.txtBoxResultWeightAdd.TabIndex = 3;
            // 
            // txtBoxResultColorAdd
            // 
            this.txtBoxResultColorAdd.Location = new System.Drawing.Point(520, 174);
            this.txtBoxResultColorAdd.Name = "txtBoxResultColorAdd";
            this.txtBoxResultColorAdd.Size = new System.Drawing.Size(100, 21);
            this.txtBoxResultColorAdd.TabIndex = 4;
            this.txtBoxResultColorAdd.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBoxExperimentNumberEdit
            // 
            this.txtBoxExperimentNumberEdit.Location = new System.Drawing.Point(520, 37);
            this.txtBoxExperimentNumberEdit.Name = "txtBoxExperimentNumberEdit";
            this.txtBoxExperimentNumberEdit.Size = new System.Drawing.Size(100, 21);
            this.txtBoxExperimentNumberEdit.TabIndex = 5;
            // 
            // txtBoxStudentNameEdit
            // 
            this.txtBoxStudentNameEdit.Location = new System.Drawing.Point(190, 40);
            this.txtBoxStudentNameEdit.Name = "txtBoxStudentNameEdit";
            this.txtBoxStudentNameEdit.Size = new System.Drawing.Size(100, 21);
            this.txtBoxStudentNameEdit.TabIndex = 6;
            // 
            // richTextBoxExperimentDescriptionEdit
            // 
            this.richTextBoxExperimentDescriptionEdit.Location = new System.Drawing.Point(190, 78);
            this.richTextBoxExperimentDescriptionEdit.Name = "richTextBoxExperimentDescriptionEdit";
            this.richTextBoxExperimentDescriptionEdit.Size = new System.Drawing.Size(430, 71);
            this.richTextBoxExperimentDescriptionEdit.TabIndex = 7;
            this.richTextBoxExperimentDescriptionEdit.Text = "";
            // 
            // lblResultWeightEditPrompt
            // 
            this.lblResultWeightEditPrompt.AutoSize = true;
            this.lblResultWeightEditPrompt.Location = new System.Drawing.Point(72, 177);
            this.lblResultWeightEditPrompt.Name = "lblResultWeightEditPrompt";
            this.lblResultWeightEditPrompt.Size = new System.Drawing.Size(96, 15);
            this.lblResultWeightEditPrompt.TabIndex = 8;
            this.lblResultWeightEditPrompt.Text = "Result Weight";
            // 
            // lblResultColorEditPrompt
            // 
            this.lblResultColorEditPrompt.AutoSize = true;
            this.lblResultColorEditPrompt.Location = new System.Drawing.Point(414, 180);
            this.lblResultColorEditPrompt.Name = "lblResultColorEditPrompt";
            this.lblResultColorEditPrompt.Size = new System.Drawing.Size(86, 15);
            this.lblResultColorEditPrompt.TabIndex = 9;
            this.lblResultColorEditPrompt.Text = "Result Color";
            // 
            // lblExperimentDescriptionEditPrompt
            // 
            this.lblExperimentDescriptionEditPrompt.AutoSize = true;
            this.lblExperimentDescriptionEditPrompt.Location = new System.Drawing.Point(11, 81);
            this.lblExperimentDescriptionEditPrompt.Name = "lblExperimentDescriptionEditPrompt";
            this.lblExperimentDescriptionEditPrompt.Size = new System.Drawing.Size(157, 15);
            this.lblExperimentDescriptionEditPrompt.TabIndex = 10;
            this.lblExperimentDescriptionEditPrompt.Text = "Experiment Description";
            // 
            // lblExperimentNumberEditPrompt
            // 
            this.lblExperimentNumberEditPrompt.AutoSize = true;
            this.lblExperimentNumberEditPrompt.Location = new System.Drawing.Point(365, 40);
            this.lblExperimentNumberEditPrompt.Name = "lblExperimentNumberEditPrompt";
            this.lblExperimentNumberEditPrompt.Size = new System.Drawing.Size(135, 15);
            this.lblExperimentNumberEditPrompt.TabIndex = 11;
            this.lblExperimentNumberEditPrompt.Text = "Experiment Number";
            // 
            // lblStudentNameEditPrompt
            // 
            this.lblStudentNameEditPrompt.AutoSize = true;
            this.lblStudentNameEditPrompt.Location = new System.Drawing.Point(11, 43);
            this.lblStudentNameEditPrompt.Name = "lblStudentNameEditPrompt";
            this.lblStudentNameEditPrompt.Size = new System.Drawing.Size(98, 15);
            this.lblStudentNameEditPrompt.TabIndex = 13;
            this.lblStudentNameEditPrompt.Text = "Student Name";
            // 
            // lblResultVolumeEditPrompt
            // 
            this.lblResultVolumeEditPrompt.AutoSize = true;
            this.lblResultVolumeEditPrompt.Location = new System.Drawing.Point(236, 226);
            this.lblResultVolumeEditPrompt.Name = "lblResultVolumeEditPrompt";
            this.lblResultVolumeEditPrompt.Size = new System.Drawing.Size(100, 15);
            this.lblResultVolumeEditPrompt.TabIndex = 15;
            this.lblResultVolumeEditPrompt.Text = "Result Volume";
            // 
            // groupBoxExperimentDetailsEdit
            // 
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.comboBoxColors);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.btnSave);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.btnSet);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.richTextBoxExperimentDescriptionEdit);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.lblResultVolumeEditPrompt);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.txtBoxResultVolumeAdd);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.lblStudentNameEditPrompt);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.txtBoxResultWeightAdd);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.lblExperimentNumberEditPrompt);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.txtBoxResultColorAdd);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.lblExperimentDescriptionEditPrompt);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.txtBoxExperimentNumberEdit);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.lblResultColorEditPrompt);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.txtBoxStudentNameEdit);
            this.groupBoxExperimentDetailsEdit.Controls.Add(this.lblResultWeightEditPrompt);
            this.groupBoxExperimentDetailsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExperimentDetailsEdit.Location = new System.Drawing.Point(27, 285);
            this.groupBoxExperimentDetailsEdit.Name = "groupBoxExperimentDetailsEdit";
            this.groupBoxExperimentDetailsEdit.Size = new System.Drawing.Size(683, 327);
            this.groupBoxExperimentDetailsEdit.TabIndex = 16;
            this.groupBoxExperimentDetailsEdit.TabStop = false;
            this.groupBoxExperimentDetailsEdit.Text = "Experiment Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(440, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Firebrick;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Location = new System.Drawing.Point(190, 269);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(182, 40);
            this.btnSet.TabIndex = 17;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Items.AddRange(new object[] {
            "Crimson",
            "Azure",
            "Taupe",
            "Mauve",
            "Vermillion",
            "Chartreuse"});
            this.comboBoxColors.Location = new System.Drawing.Point(520, 174);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(121, 23);
            this.comboBoxColors.TabIndex = 25;
            this.comboBoxColors.Text = "Select Color";
            this.comboBoxColors.SelectedIndexChanged += new System.EventHandler(this.comboBoxColors_SelectedIndexChanged);
            // 
            // listBoxExperiments
            // 
            this.listBoxExperiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExperiments.FormattingEnabled = true;
            this.listBoxExperiments.ItemHeight = 15;
            this.listBoxExperiments.Location = new System.Drawing.Point(744, 298);
            this.listBoxExperiments.Name = "listBoxExperiments";
            this.listBoxExperiments.Size = new System.Drawing.Size(408, 109);
            this.listBoxExperiments.TabIndex = 19;
            this.listBoxExperiments.SelectedIndexChanged += new System.EventHandler(this.listBoxExperiments_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(776, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 42);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(925, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 40);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1033, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "© Ahmed Matoussi";
            // 
            // lblExperimentsSummary
            // 
            this.lblExperimentsSummary.AutoSize = true;
            this.lblExperimentsSummary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperimentsSummary.Location = new System.Drawing.Point(848, 271);
            this.lblExperimentsSummary.Name = "lblExperimentsSummary";
            this.lblExperimentsSummary.Size = new System.Drawing.Size(148, 15);
            this.lblExperimentsSummary.TabIndex = 26;
            this.lblExperimentsSummary.Text = "Experiments Summary:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(314, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(520, 20);
            this.lblWelcome.TabIndex = 27;
            this.lblWelcome.Text = "Welcome to The Experiments Management System Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1164, 624);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblExperimentsSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxExperiments);
            this.Controls.Add(this.groupBoxExperimentDetailsEdit);
            this.Controls.Add(this.groupBoxRadios);
            this.Controls.Add(this.btnCreateExperiment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRadios.ResumeLayout(false);
            this.groupBoxRadios.PerformLayout();
            this.groupBoxExperimentDetailsEdit.ResumeLayout(false);
            this.groupBoxExperimentDetailsEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateExperiment;
        private System.Windows.Forms.GroupBox groupBoxRadios;
        private System.Windows.Forms.RadioButton radioButtonExperimentNumberAndDescription;
        private System.Windows.Forms.RadioButton radioButtonStudentNameOnly;
        private System.Windows.Forms.RadioButton radioButtonNothingIsKnown;
        private System.Windows.Forms.TextBox txtBoxStudentNameKnown;
        private System.Windows.Forms.TextBox txtExperimentNumberKnown;
        private System.Windows.Forms.Label lblExperimentNumberKnownPrompt;
        private System.Windows.Forms.Label lblExperimentDescriptionKnownPrompt;
        private System.Windows.Forms.RichTextBox richTextBoxExperimentDescription;
        private System.Windows.Forms.TextBox txtBoxResultVolumeAdd;
        private System.Windows.Forms.TextBox txtBoxResultWeightAdd;
        private System.Windows.Forms.TextBox txtBoxResultColorAdd;
        private System.Windows.Forms.TextBox txtBoxExperimentNumberEdit;
        private System.Windows.Forms.TextBox txtBoxStudentNameEdit;
        private System.Windows.Forms.RichTextBox richTextBoxExperimentDescriptionEdit;
        private System.Windows.Forms.Label lblResultWeightEditPrompt;
        private System.Windows.Forms.Label lblResultColorEditPrompt;
        private System.Windows.Forms.Label lblExperimentDescriptionEditPrompt;
        private System.Windows.Forms.Label lblExperimentNumberEditPrompt;
        private System.Windows.Forms.Label lblStudentNameEditPrompt;
        private System.Windows.Forms.Label lblResultVolumeEditPrompt;
        private System.Windows.Forms.GroupBox groupBoxExperimentDetailsEdit;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxExperiments;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label lblExperimentsSummary;
        private System.Windows.Forms.Label lblWelcome;
    }
}

