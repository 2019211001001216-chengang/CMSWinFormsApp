namespace CMSWinFormsApp
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbWokerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDBDataSet = new CMSWinFormsApp.CMSDBDataSet();
            this._LAPTOP_ASQ7IHLSDataSet = new CMSWinFormsApp._LAPTOP_ASQ7IHLSDataSet();
            this.tbWokerTableAdapter = new CMSWinFormsApp.CMSDBDataSetTableAdapters.tbWokerTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWokerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._LAPTOP_ASQ7IHLSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on the Edit Button to load the records";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(38, 381);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(142, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(247, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(381, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbWokerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(593, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // workerIdDataGridViewTextBoxColumn
            // 
            this.workerIdDataGridViewTextBoxColumn.DataPropertyName = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.HeaderText = "WorkerId";
            this.workerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerIdDataGridViewTextBoxColumn.Name = "workerIdDataGridViewTextBoxColumn";
            this.workerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbWokerBindingSource
            // 
            this.tbWokerBindingSource.DataMember = "tbWoker";
            this.tbWokerBindingSource.DataSource = this.cMSDBDataSet;
            // 
            // cMSDBDataSet
            // 
            this.cMSDBDataSet.DataSetName = "CMSDBDataSet";
            this.cMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _LAPTOP_ASQ7IHLSDataSet
            // 
            this._LAPTOP_ASQ7IHLSDataSet.DataSetName = "_LAPTOP_ASQ7IHLSDataSet";
            this._LAPTOP_ASQ7IHLSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbWokerTableAdapter
            // 
            this.tbWokerTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "Select WorkerId,Name from tbWorker";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LAPTOP-ASQ7IHLS;Initial Catalog=CMSDB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter2.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "Select workerId,Name from tbwoker ";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [tbwoker] ([workerId], [Name]) VALUES (@workerId, @Name);\r\nSELECT Wor" +
    "kerId, Name FROM tbWoker WHERE (WorkerId = @WorkerId)";
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@workerId", System.Data.SqlDbType.Int, 0, "workerId"),
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"),
            new System.Data.SqlClient.SqlParameter("@WorkerId", System.Data.SqlDbType.Int, 4, "WorkerId")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@workerId", System.Data.SqlDbType.Int, 0, "workerId"),
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 0, "Name"),
            new System.Data.SqlClient.SqlParameter("@Original_workerId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "workerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@WorkerId", System.Data.SqlDbType.Int, 4, "WorkerId")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [tbwoker] WHERE (([workerId] = @Original_workerId) AND ((@IsNull_Name" +
    " = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)))";
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_workerId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "workerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter3
            // 
            this.sqlDataAdapter3.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapter3.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tbWoker", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("workerId", "workerId"),
                        new System.Data.Common.DataColumnMapping("Name", "Name")})});
            this.sqlDataAdapter3.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWokerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._LAPTOP_ASQ7IHLSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _LAPTOP_ASQ7IHLSDataSet _LAPTOP_ASQ7IHLSDataSet;
        private CMSDBDataSet cMSDBDataSet;
        private System.Windows.Forms.BindingSource tbWokerBindingSource;
        private CMSDBDataSetTableAdapters.tbWokerTableAdapter tbWokerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
    }
}