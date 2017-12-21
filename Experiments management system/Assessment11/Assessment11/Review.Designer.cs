namespace Assessment11
{
    partial class Review
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblExperimentDetailsPopup = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblExperimentNumber = new System.Windows.Forms.Label();
            this.lblExperimentDescription = new System.Windows.Forms.Label();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.lblResultWeight = new System.Windows.Forms.Label();
            this.lblResultVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Firebrick;
            this.btnOK.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(240, 222);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblExperimentDetailsPopup
            // 
            this.lblExperimentDetailsPopup.AutoSize = true;
            this.lblExperimentDetailsPopup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperimentDetailsPopup.Location = new System.Drawing.Point(237, 21);
            this.lblExperimentDetailsPopup.Name = "lblExperimentDetailsPopup";
            this.lblExperimentDetailsPopup.Size = new System.Drawing.Size(122, 15);
            this.lblExperimentDetailsPopup.TabIndex = 1;
            this.lblExperimentDetailsPopup.Text = "Experiment details";
            this.lblExperimentDetailsPopup.Click += new System.EventHandler(this.lblExperimentDetailsPopup_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(31, 76);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(95, 15);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblExperimentNumber
            // 
            this.lblExperimentNumber.AutoSize = true;
            this.lblExperimentNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperimentNumber.Location = new System.Drawing.Point(332, 76);
            this.lblExperimentNumber.Name = "lblExperimentNumber";
            this.lblExperimentNumber.Size = new System.Drawing.Size(131, 15);
            this.lblExperimentNumber.TabIndex = 3;
            this.lblExperimentNumber.Text = "Experiment Number";
            // 
            // lblExperimentDescription
            // 
            this.lblExperimentDescription.AutoSize = true;
            this.lblExperimentDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperimentDescription.Location = new System.Drawing.Point(31, 120);
            this.lblExperimentDescription.Name = "lblExperimentDescription";
            this.lblExperimentDescription.Size = new System.Drawing.Size(152, 15);
            this.lblExperimentDescription.TabIndex = 4;
            this.lblExperimentDescription.Text = "Experiment Description";
            // 
            // lblResultColor
            // 
            this.lblResultColor.AutoSize = true;
            this.lblResultColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultColor.Location = new System.Drawing.Point(29, 174);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(82, 15);
            this.lblResultColor.TabIndex = 5;
            this.lblResultColor.Text = "Result Color";
            // 
            // lblResultWeight
            // 
            this.lblResultWeight.AutoSize = true;
            this.lblResultWeight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultWeight.Location = new System.Drawing.Point(237, 174);
            this.lblResultWeight.Name = "lblResultWeight";
            this.lblResultWeight.Size = new System.Drawing.Size(90, 15);
            this.lblResultWeight.TabIndex = 6;
            this.lblResultWeight.Text = "ResultWeight";
            // 
            // lblResultVolume
            // 
            this.lblResultVolume.AutoSize = true;
            this.lblResultVolume.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultVolume.Location = new System.Drawing.Point(435, 174);
            this.lblResultVolume.Name = "lblResultVolume";
            this.lblResultVolume.Size = new System.Drawing.Size(97, 15);
            this.lblResultVolume.TabIndex = 7;
            this.lblResultVolume.Text = "Result Volume";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(618, 269);
            this.Controls.Add(this.lblResultVolume);
            this.Controls.Add(this.lblResultWeight);
            this.Controls.Add(this.lblResultColor);
            this.Controls.Add(this.lblExperimentDescription);
            this.Controls.Add(this.lblExperimentNumber);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblExperimentDetailsPopup);
            this.Controls.Add(this.btnOK);
            this.Name = "Review";
            this.Text = "Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblExperimentDetailsPopup;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblExperimentNumber;
        private System.Windows.Forms.Label lblExperimentDescription;
        private System.Windows.Forms.Label lblResultColor;
        private System.Windows.Forms.Label lblResultWeight;
        private System.Windows.Forms.Label lblResultVolume;
    }
}