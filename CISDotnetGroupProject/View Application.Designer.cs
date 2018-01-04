namespace CISDotnetGroupProject
{
    partial class View_Application
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
            this.personalDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.educationDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.technologiesDataGridView = new System.Windows.Forms.DataGridView();
            this.experienceDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personalDetailsDataGridView
            // 
            this.personalDetailsDataGridView.AllowUserToAddRows = false;
            this.personalDetailsDataGridView.AllowUserToDeleteRows = false;
            this.personalDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalDetailsDataGridView.Location = new System.Drawing.Point(59, 71);
            this.personalDetailsDataGridView.Name = "personalDetailsDataGridView";
            this.personalDetailsDataGridView.ReadOnly = true;
            this.personalDetailsDataGridView.RowTemplate.Height = 28;
            this.personalDetailsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.personalDetailsDataGridView.TabIndex = 0;
            // 
            // educationDetailsDataGridView
            // 
            this.educationDetailsDataGridView.AllowUserToAddRows = false;
            this.educationDetailsDataGridView.AllowUserToDeleteRows = false;
            this.educationDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.educationDetailsDataGridView.Location = new System.Drawing.Point(59, 270);
            this.educationDetailsDataGridView.Name = "educationDetailsDataGridView";
            this.educationDetailsDataGridView.ReadOnly = true;
            this.educationDetailsDataGridView.RowTemplate.Height = 28;
            this.educationDetailsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.educationDetailsDataGridView.TabIndex = 1;
            // 
            // technologiesDataGridView
            // 
            this.technologiesDataGridView.AllowUserToAddRows = false;
            this.technologiesDataGridView.AllowUserToDeleteRows = false;
            this.technologiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technologiesDataGridView.Location = new System.Drawing.Point(639, 270);
            this.technologiesDataGridView.Name = "technologiesDataGridView";
            this.technologiesDataGridView.ReadOnly = true;
            this.technologiesDataGridView.RowTemplate.Height = 28;
            this.technologiesDataGridView.Size = new System.Drawing.Size(240, 150);
            this.technologiesDataGridView.TabIndex = 3;
            // 
            // experienceDataGridView
            // 
            this.experienceDataGridView.AllowUserToAddRows = false;
            this.experienceDataGridView.AllowUserToDeleteRows = false;
            this.experienceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.experienceDataGridView.Location = new System.Drawing.Point(639, 71);
            this.experienceDataGridView.Name = "experienceDataGridView";
            this.experienceDataGridView.ReadOnly = true;
            this.experienceDataGridView.RowTemplate.Height = 28;
            this.experienceDataGridView.Size = new System.Drawing.Size(240, 150);
            this.experienceDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Student Id";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(428, 3);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(100, 26);
            this.textBoxStudentId.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(556, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 36);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // View_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 534);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.technologiesDataGridView);
            this.Controls.Add(this.experienceDataGridView);
            this.Controls.Add(this.educationDetailsDataGridView);
            this.Controls.Add(this.personalDetailsDataGridView);
            this.Name = "View_Application";
            this.Text = "View_Application";
            this.Load += new System.EventHandler(this.View_Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personalDetailsDataGridView;
        private System.Windows.Forms.DataGridView educationDetailsDataGridView;
        private System.Windows.Forms.DataGridView technologiesDataGridView;
        private System.Windows.Forms.DataGridView experienceDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Button buttonSearch;
    }
}