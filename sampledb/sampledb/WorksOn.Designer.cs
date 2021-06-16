namespace sampledb
{
    partial class WorksOn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sampleDbDataSet3 = new sampledb.SampleDbDataSet3();
            this.worksonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.works_onTableAdapter = new sampledb.SampleDbDataSet3TableAdapters.Works_onTableAdapter();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.projectNumberDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.enterDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.worksonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sampleDbDataSet3
            // 
            this.sampleDbDataSet3.DataSetName = "SampleDbDataSet3";
            this.sampleDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worksonBindingSource
            // 
            this.worksonBindingSource.DataMember = "Works_on";
            this.worksonBindingSource.DataSource = this.sampleDbDataSet3;
            // 
            // works_onTableAdapter
            // 
            this.works_onTableAdapter.ClearBeforeFill = true;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            // 
            // projectNumberDataGridViewTextBoxColumn
            // 
            this.projectNumberDataGridViewTextBoxColumn.DataPropertyName = "ProjectNumber";
            this.projectNumberDataGridViewTextBoxColumn.HeaderText = "ProjectNumber";
            this.projectNumberDataGridViewTextBoxColumn.Name = "projectNumberDataGridViewTextBoxColumn";
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            // 
            // enterDateDataGridViewTextBoxColumn
            // 
            this.enterDateDataGridViewTextBoxColumn.DataPropertyName = "EnterDate";
            this.enterDateDataGridViewTextBoxColumn.HeaderText = "EnterDate";
            this.enterDateDataGridViewTextBoxColumn.Name = "enterDateDataGridViewTextBoxColumn";
            // 
            // WorksOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorksOn";
            this.Text = "WorksOn";
            this.Load += new System.EventHandler(this.WorksOn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private SampleDbDataSet3 sampleDbDataSet3;
        private System.Windows.Forms.BindingSource worksonBindingSource;
        private SampleDbDataSet3TableAdapters.Works_onTableAdapter works_onTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDateDataGridViewTextBoxColumn;
    }
}