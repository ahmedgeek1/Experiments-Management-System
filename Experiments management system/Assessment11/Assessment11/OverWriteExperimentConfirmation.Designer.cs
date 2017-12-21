namespace Assessment11
{
    partial class OverWriteExperimentConfirmation
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
            this.btnConfirmOverWrite = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblOverWritePompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmOverWrite
            // 
            this.btnConfirmOverWrite.BackColor = System.Drawing.Color.Firebrick;
            this.btnConfirmOverWrite.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOverWrite.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOverWrite.Location = new System.Drawing.Point(132, 59);
            this.btnConfirmOverWrite.Name = "btnConfirmOverWrite";
            this.btnConfirmOverWrite.Size = new System.Drawing.Size(98, 37);
            this.btnConfirmOverWrite.TabIndex = 0;
            this.btnConfirmOverWrite.Text = "Yes";
            this.btnConfirmOverWrite.UseVisualStyleBackColor = false;
            this.btnConfirmOverWrite.Click += new System.EventHandler(this.btnConfirmOverWrite_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Firebrick;
            this.btnNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(297, 59);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(98, 37);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblOverWritePompt
            // 
            this.lblOverWritePompt.AutoSize = true;
            this.lblOverWritePompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverWritePompt.Location = new System.Drawing.Point(48, 20);
            this.lblOverWritePompt.Name = "lblOverWritePompt";
            this.lblOverWritePompt.Size = new System.Drawing.Size(357, 17);
            this.lblOverWritePompt.TabIndex = 2;
            this.lblOverWritePompt.Text = "Are you sure you want to overwrite this experiment?";
            // 
            // OverWriteExperimentConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(498, 118);
            this.Controls.Add(this.lblOverWritePompt);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnConfirmOverWrite);
            this.Name = "OverWriteExperimentConfirmation";
            this.Text = "OverWriteExperimentConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmOverWrite;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblOverWritePompt;
    }
}