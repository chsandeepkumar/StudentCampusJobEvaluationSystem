namespace CISDotnetGroupProject
{
    partial class FacultyViewForm
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
            this.applicantDetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.labelApplicantDetails = new System.Windows.Forms.Label();
            this.labelLoggedInUserDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicantDetailsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // applicantDetailsdataGridView
            // 
            this.applicantDetailsdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.applicantDetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicantDetailsdataGridView.Location = new System.Drawing.Point(12, 88);
            this.applicantDetailsdataGridView.Name = "applicantDetailsdataGridView";
            this.applicantDetailsdataGridView.Size = new System.Drawing.Size(884, 331);
            this.applicantDetailsdataGridView.TabIndex = 0;
            // 
            // labelApplicantDetails
            // 
            this.labelApplicantDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicantDetails.Location = new System.Drawing.Point(12, 22);
            this.labelApplicantDetails.Name = "labelApplicantDetails";
            this.labelApplicantDetails.Size = new System.Drawing.Size(491, 51);
            this.labelApplicantDetails.TabIndex = 1;
            this.labelApplicantDetails.Text = "Applicant Details";
            this.labelApplicantDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelApplicantDetails.Click += new System.EventHandler(this.labelApplicantDetails_Click);
            // 
            // labelLoggedInUserDetails
            // 
            this.labelLoggedInUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInUserDetails.Location = new System.Drawing.Point(449, 22);
            this.labelLoggedInUserDetails.Name = "labelLoggedInUserDetails";
            this.labelLoggedInUserDetails.Size = new System.Drawing.Size(431, 51);
            this.labelLoggedInUserDetails.TabIndex = 2;
            this.labelLoggedInUserDetails.Text = "Welcome to Faculty";
            this.labelLoggedInUserDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FacultyViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 461);
            this.Controls.Add(this.labelLoggedInUserDetails);
            this.Controls.Add(this.labelApplicantDetails);
            this.Controls.Add(this.applicantDetailsdataGridView);
            this.Name = "FacultyViewForm";
            this.Text = "Faculty ";
            this.Load += new System.EventHandler(this.FacultyViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicantDetailsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView applicantDetailsdataGridView;
        private System.Windows.Forms.Label labelApplicantDetails;
        private System.Windows.Forms.Label labelLoggedInUserDetails;
    }
}