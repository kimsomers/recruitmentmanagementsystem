namespace RecruitmentManagementSystem
{
    partial class JobList
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
            this.components = new System.ComponentModel.Container();
            this.dgvJobList = new System.Windows.Forms.DataGridView();
            this.jOBIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBTITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBCOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBCITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBCOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBADDEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBCATEGORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSearch = new RecruitmentManagementSystem.DataSetSearch();
            this.jOBTableAdapter = new RecruitmentManagementSystem.DataSetSearchTableAdapters.JOBTableAdapter();
            this.btnJobListClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobList
            // 
            this.dgvJobList.AllowUserToAddRows = false;
            this.dgvJobList.AllowUserToDeleteRows = false;
            this.dgvJobList.AllowUserToOrderColumns = true;
            this.dgvJobList.AutoGenerateColumns = false;
            this.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jOBIDDataGridViewTextBoxColumn,
            this.jOBTITLEDataGridViewTextBoxColumn,
            this.jOBCOMPANYDataGridViewTextBoxColumn,
            this.jOBCITYDataGridViewTextBoxColumn,
            this.jOBCOUNTRYDataGridViewTextBoxColumn,
            this.jOBSTATUSDataGridViewTextBoxColumn,
            this.jOBADDEDDataGridViewTextBoxColumn,
            this.jOBCATEGORYDataGridViewTextBoxColumn});
            this.dgvJobList.DataSource = this.jOBBindingSource;
            this.dgvJobList.Location = new System.Drawing.Point(13, 13);
            this.dgvJobList.Name = "dgvJobList";
            this.dgvJobList.ReadOnly = true;
            this.dgvJobList.Size = new System.Drawing.Size(845, 344);
            this.dgvJobList.TabIndex = 0;
            // 
            // jOBIDDataGridViewTextBoxColumn
            // 
            this.jOBIDDataGridViewTextBoxColumn.DataPropertyName = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.HeaderText = "JOBID";
            this.jOBIDDataGridViewTextBoxColumn.Name = "jOBIDDataGridViewTextBoxColumn";
            this.jOBIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBTITLEDataGridViewTextBoxColumn
            // 
            this.jOBTITLEDataGridViewTextBoxColumn.DataPropertyName = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.HeaderText = "JOBTITLE";
            this.jOBTITLEDataGridViewTextBoxColumn.Name = "jOBTITLEDataGridViewTextBoxColumn";
            this.jOBTITLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBCOMPANYDataGridViewTextBoxColumn
            // 
            this.jOBCOMPANYDataGridViewTextBoxColumn.DataPropertyName = "JOBCOMPANY";
            this.jOBCOMPANYDataGridViewTextBoxColumn.HeaderText = "JOBCOMPANY";
            this.jOBCOMPANYDataGridViewTextBoxColumn.Name = "jOBCOMPANYDataGridViewTextBoxColumn";
            this.jOBCOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBCITYDataGridViewTextBoxColumn
            // 
            this.jOBCITYDataGridViewTextBoxColumn.DataPropertyName = "JOBCITY";
            this.jOBCITYDataGridViewTextBoxColumn.HeaderText = "JOBCITY";
            this.jOBCITYDataGridViewTextBoxColumn.Name = "jOBCITYDataGridViewTextBoxColumn";
            this.jOBCITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBCOUNTRYDataGridViewTextBoxColumn
            // 
            this.jOBCOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "JOBCOUNTRY";
            this.jOBCOUNTRYDataGridViewTextBoxColumn.HeaderText = "JOBCOUNTRY";
            this.jOBCOUNTRYDataGridViewTextBoxColumn.Name = "jOBCOUNTRYDataGridViewTextBoxColumn";
            this.jOBCOUNTRYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBSTATUSDataGridViewTextBoxColumn
            // 
            this.jOBSTATUSDataGridViewTextBoxColumn.DataPropertyName = "JOBSTATUS";
            this.jOBSTATUSDataGridViewTextBoxColumn.HeaderText = "JOBSTATUS";
            this.jOBSTATUSDataGridViewTextBoxColumn.Name = "jOBSTATUSDataGridViewTextBoxColumn";
            this.jOBSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBADDEDDataGridViewTextBoxColumn
            // 
            this.jOBADDEDDataGridViewTextBoxColumn.DataPropertyName = "JOBADDED";
            this.jOBADDEDDataGridViewTextBoxColumn.HeaderText = "JOBADDED";
            this.jOBADDEDDataGridViewTextBoxColumn.Name = "jOBADDEDDataGridViewTextBoxColumn";
            this.jOBADDEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBCATEGORYDataGridViewTextBoxColumn
            // 
            this.jOBCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "JOBCATEGORY";
            this.jOBCATEGORYDataGridViewTextBoxColumn.HeaderText = "JOBCATEGORY";
            this.jOBCATEGORYDataGridViewTextBoxColumn.Name = "jOBCATEGORYDataGridViewTextBoxColumn";
            this.jOBCATEGORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jOBBindingSource
            // 
            this.jOBBindingSource.DataMember = "JOB";
            this.jOBBindingSource.DataSource = this.dataSetSearch;
            // 
            // dataSetSearch
            // 
            this.dataSetSearch.DataSetName = "DataSetSearch";
            this.dataSetSearch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOBTableAdapter
            // 
            this.jOBTableAdapter.ClearBeforeFill = true;
            // 
            // btnJobListClose
            // 
            this.btnJobListClose.Location = new System.Drawing.Point(783, 366);
            this.btnJobListClose.Name = "btnJobListClose";
            this.btnJobListClose.Size = new System.Drawing.Size(75, 23);
            this.btnJobListClose.TabIndex = 1;
            this.btnJobListClose.Text = "Close";
            this.btnJobListClose.UseVisualStyleBackColor = true;
            this.btnJobListClose.Click += new System.EventHandler(this.btnJobListClose_Click);
            // 
            // JobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 401);
            this.Controls.Add(this.btnJobListClose);
            this.Controls.Add(this.dgvJobList);
            this.Name = "JobList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobList";
            this.Load += new System.EventHandler(this.JobList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJobList;
        private DataSetSearch dataSetSearch;
        private System.Windows.Forms.BindingSource jOBBindingSource;
        private DataSetSearchTableAdapters.JOBTableAdapter jOBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBTITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBCOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBCITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBCOUNTRYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBADDEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBCATEGORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnJobListClose;
    }
}