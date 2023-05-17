namespace ProjectSynspunkt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vareNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vareNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salgsPrisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vareTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.synsPunktVarerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nicklaskruse_dk_db_webdatabaseDataSet = new ProjectSynspunkt.nicklaskruse_dk_db_webdatabaseDataSet();
            this.synsPunktKunderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synsPunktKunderTableAdapter = new ProjectSynspunkt.nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktKunderTableAdapter();
            this.synsPunktVarerTableAdapter = new ProjectSynspunkt.nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktVarerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktVarerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicklaskruse_dk_db_webdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktKunderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Hype";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "sdf";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vareNrDataGridViewTextBoxColumn,
            this.vareNavnDataGridViewTextBoxColumn,
            this.antalDataGridViewTextBoxColumn,
            this.salgsPrisDataGridViewTextBoxColumn,
            this.vareTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.synsPunktVarerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(292, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // vareNrDataGridViewTextBoxColumn
            // 
            this.vareNrDataGridViewTextBoxColumn.DataPropertyName = "vareNr";
            this.vareNrDataGridViewTextBoxColumn.HeaderText = "vareNr";
            this.vareNrDataGridViewTextBoxColumn.Name = "vareNrDataGridViewTextBoxColumn";
            this.vareNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vareNavnDataGridViewTextBoxColumn
            // 
            this.vareNavnDataGridViewTextBoxColumn.DataPropertyName = "vareNavn";
            this.vareNavnDataGridViewTextBoxColumn.HeaderText = "vareNavn";
            this.vareNavnDataGridViewTextBoxColumn.Name = "vareNavnDataGridViewTextBoxColumn";
            // 
            // antalDataGridViewTextBoxColumn
            // 
            this.antalDataGridViewTextBoxColumn.DataPropertyName = "antal";
            this.antalDataGridViewTextBoxColumn.HeaderText = "antal";
            this.antalDataGridViewTextBoxColumn.Name = "antalDataGridViewTextBoxColumn";
            // 
            // salgsPrisDataGridViewTextBoxColumn
            // 
            this.salgsPrisDataGridViewTextBoxColumn.DataPropertyName = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.HeaderText = "salgsPris";
            this.salgsPrisDataGridViewTextBoxColumn.Name = "salgsPrisDataGridViewTextBoxColumn";
            // 
            // vareTypeDataGridViewTextBoxColumn
            // 
            this.vareTypeDataGridViewTextBoxColumn.DataPropertyName = "vareType";
            this.vareTypeDataGridViewTextBoxColumn.HeaderText = "vareType";
            this.vareTypeDataGridViewTextBoxColumn.Name = "vareTypeDataGridViewTextBoxColumn";
            // 
            // synsPunktVarerBindingSource
            // 
            this.synsPunktVarerBindingSource.DataMember = "SynsPunktVarer";
            this.synsPunktVarerBindingSource.DataSource = this.nicklaskruse_dk_db_webdatabaseDataSet;
            // 
            // nicklaskruse_dk_db_webdatabaseDataSet
            // 
            this.nicklaskruse_dk_db_webdatabaseDataSet.DataSetName = "nicklaskruse_dk_db_webdatabaseDataSet";
            this.nicklaskruse_dk_db_webdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // synsPunktKunderBindingSource
            // 
            this.synsPunktKunderBindingSource.DataMember = "SynsPunktKunder";
            this.synsPunktKunderBindingSource.DataSource = this.nicklaskruse_dk_db_webdatabaseDataSet;
            // 
            // synsPunktKunderTableAdapter
            // 
            this.synsPunktKunderTableAdapter.ClearBeforeFill = true;
            // 
            // synsPunktVarerTableAdapter
            // 
            this.synsPunktVarerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktVarerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicklaskruse_dk_db_webdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktKunderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private nicklaskruse_dk_db_webdatabaseDataSet nicklaskruse_dk_db_webdatabaseDataSet;
        private System.Windows.Forms.BindingSource synsPunktKunderBindingSource;
        private nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktKunderTableAdapter synsPunktKunderTableAdapter;
        private System.Windows.Forms.BindingSource synsPunktVarerBindingSource;
        private nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktVarerTableAdapter synsPunktVarerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vareNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vareNavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salgsPrisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vareTypeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

