namespace HazLog
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
            this.components = new System.ComponentModel.Container();
            this.btntree = new System.Windows.Forms.Button();
            this.btnblue = new System.Windows.Forms.Button();
            this.btnmap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subSystemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRELikelihoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESeverityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREOutcomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postLikelihoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSTSeverityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSTOutcomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mitigationAchievedYesNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalLocalMitigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postMitigationValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazardLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hazardLogDataSet = new HazLog.HazardLogDataSet();
            this.hazardLogTableAdapter = new HazLog.HazardLogDataSetTableAdapters.HazardLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazardLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazardLogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btntree
            // 
            this.btntree.Location = new System.Drawing.Point(369, 12);
            this.btntree.Name = "btntree";
            this.btntree.Size = new System.Drawing.Size(75, 23);
            this.btntree.TabIndex = 0;
            this.btntree.Text = "Tree";
            this.btntree.UseVisualStyleBackColor = true;
            this.btntree.Click += new System.EventHandler(this.btntree_Click);
            // 
            // btnblue
            // 
            this.btnblue.Location = new System.Drawing.Point(450, 12);
            this.btnblue.Name = "btnblue";
            this.btnblue.Size = new System.Drawing.Size(75, 23);
            this.btnblue.TabIndex = 1;
            this.btnblue.Text = "BluePrint";
            this.btnblue.UseVisualStyleBackColor = true;
            this.btnblue.Click += new System.EventHandler(this.btnblue_Click);
            // 
            // btnmap
            // 
            this.btnmap.Location = new System.Drawing.Point(531, 12);
            this.btnmap.Name = "btnmap";
            this.btnmap.Size = new System.Drawing.Size(75, 23);
            this.btnmap.TabIndex = 2;
            this.btnmap.Text = "MindMap";
            this.btnmap.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.subSystemsDataGridViewTextBoxColumn,
            this.hazardsDataGridViewTextBoxColumn,
            this.pRELikelihoodDataGridViewTextBoxColumn,
            this.pRESeverityDataGridViewTextBoxColumn,
            this.pREOutcomeDataGridViewTextBoxColumn,
            this.mitigationDataGridViewTextBoxColumn,
            this.postLikelihoodDataGridViewTextBoxColumn,
            this.pOSTSeverityDataGridViewTextBoxColumn,
            this.pOSTOutcomeDataGridViewTextBoxColumn,
            this.mitigationAchievedYesNoDataGridViewTextBoxColumn,
            this.additionalLocalMitigationDataGridViewTextBoxColumn,
            this.postMitigationValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hazardLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(992, 397);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subSystemsDataGridViewTextBoxColumn
            // 
            this.subSystemsDataGridViewTextBoxColumn.DataPropertyName = "Sub-Systems";
            this.subSystemsDataGridViewTextBoxColumn.HeaderText = "Sub-Systems";
            this.subSystemsDataGridViewTextBoxColumn.Name = "subSystemsDataGridViewTextBoxColumn";
            this.subSystemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hazardsDataGridViewTextBoxColumn
            // 
            this.hazardsDataGridViewTextBoxColumn.DataPropertyName = "Hazards";
            this.hazardsDataGridViewTextBoxColumn.HeaderText = "Hazards";
            this.hazardsDataGridViewTextBoxColumn.Name = "hazardsDataGridViewTextBoxColumn";
            this.hazardsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRELikelihoodDataGridViewTextBoxColumn
            // 
            this.pRELikelihoodDataGridViewTextBoxColumn.DataPropertyName = "PRELikelihood";
            this.pRELikelihoodDataGridViewTextBoxColumn.HeaderText = "PRELikelihood";
            this.pRELikelihoodDataGridViewTextBoxColumn.Name = "pRELikelihoodDataGridViewTextBoxColumn";
            this.pRELikelihoodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRESeverityDataGridViewTextBoxColumn
            // 
            this.pRESeverityDataGridViewTextBoxColumn.DataPropertyName = "PRESeverity";
            this.pRESeverityDataGridViewTextBoxColumn.HeaderText = "PRESeverity";
            this.pRESeverityDataGridViewTextBoxColumn.Name = "pRESeverityDataGridViewTextBoxColumn";
            this.pRESeverityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pREOutcomeDataGridViewTextBoxColumn
            // 
            this.pREOutcomeDataGridViewTextBoxColumn.DataPropertyName = "PREOutcome";
            this.pREOutcomeDataGridViewTextBoxColumn.HeaderText = "PREOutcome";
            this.pREOutcomeDataGridViewTextBoxColumn.Name = "pREOutcomeDataGridViewTextBoxColumn";
            this.pREOutcomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mitigationDataGridViewTextBoxColumn
            // 
            this.mitigationDataGridViewTextBoxColumn.DataPropertyName = "Mitigation";
            this.mitigationDataGridViewTextBoxColumn.HeaderText = "Mitigation";
            this.mitigationDataGridViewTextBoxColumn.Name = "mitigationDataGridViewTextBoxColumn";
            this.mitigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postLikelihoodDataGridViewTextBoxColumn
            // 
            this.postLikelihoodDataGridViewTextBoxColumn.DataPropertyName = "PostLikelihood";
            this.postLikelihoodDataGridViewTextBoxColumn.HeaderText = "PostLikelihood";
            this.postLikelihoodDataGridViewTextBoxColumn.Name = "postLikelihoodDataGridViewTextBoxColumn";
            this.postLikelihoodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOSTSeverityDataGridViewTextBoxColumn
            // 
            this.pOSTSeverityDataGridViewTextBoxColumn.DataPropertyName = "POSTSeverity";
            this.pOSTSeverityDataGridViewTextBoxColumn.HeaderText = "POSTSeverity";
            this.pOSTSeverityDataGridViewTextBoxColumn.Name = "pOSTSeverityDataGridViewTextBoxColumn";
            this.pOSTSeverityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOSTOutcomeDataGridViewTextBoxColumn
            // 
            this.pOSTOutcomeDataGridViewTextBoxColumn.DataPropertyName = "POSTOutcome";
            this.pOSTOutcomeDataGridViewTextBoxColumn.HeaderText = "POSTOutcome";
            this.pOSTOutcomeDataGridViewTextBoxColumn.Name = "pOSTOutcomeDataGridViewTextBoxColumn";
            this.pOSTOutcomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mitigationAchievedYesNoDataGridViewTextBoxColumn
            // 
            this.mitigationAchievedYesNoDataGridViewTextBoxColumn.DataPropertyName = "Mitigation achieved ? Yes/No";
            this.mitigationAchievedYesNoDataGridViewTextBoxColumn.HeaderText = "Mitigation achieved ? Yes/No";
            this.mitigationAchievedYesNoDataGridViewTextBoxColumn.Name = "mitigationAchievedYesNoDataGridViewTextBoxColumn";
            this.mitigationAchievedYesNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // additionalLocalMitigationDataGridViewTextBoxColumn
            // 
            this.additionalLocalMitigationDataGridViewTextBoxColumn.DataPropertyName = "Additional local mitigation";
            this.additionalLocalMitigationDataGridViewTextBoxColumn.HeaderText = "Additional local mitigation";
            this.additionalLocalMitigationDataGridViewTextBoxColumn.Name = "additionalLocalMitigationDataGridViewTextBoxColumn";
            this.additionalLocalMitigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postMitigationValueDataGridViewTextBoxColumn
            // 
            this.postMitigationValueDataGridViewTextBoxColumn.DataPropertyName = "Post mitigation value";
            this.postMitigationValueDataGridViewTextBoxColumn.HeaderText = "Post mitigation value";
            this.postMitigationValueDataGridViewTextBoxColumn.Name = "postMitigationValueDataGridViewTextBoxColumn";
            this.postMitigationValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hazardLogBindingSource
            // 
            this.hazardLogBindingSource.DataMember = "HazardLog";
            this.hazardLogBindingSource.DataSource = this.hazardLogDataSet;
            // 
            // hazardLogDataSet
            // 
            this.hazardLogDataSet.DataSetName = "HazardLogDataSet";
            this.hazardLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hazardLogTableAdapter
            // 
            this.hazardLogTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnmap);
            this.Controls.Add(this.btnblue);
            this.Controls.Add(this.btntree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazardLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazardLogDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntree;
        private System.Windows.Forms.Button btnblue;
        private System.Windows.Forms.Button btnmap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HazardLogDataSet hazardLogDataSet;
        private System.Windows.Forms.BindingSource hazardLogBindingSource;
        private HazardLogDataSetTableAdapters.HazardLogTableAdapter hazardLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subSystemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRELikelihoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESeverityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREOutcomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mitigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postLikelihoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSTSeverityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSTOutcomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mitigationAchievedYesNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalLocalMitigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postMitigationValueDataGridViewTextBoxColumn;
    }
}

