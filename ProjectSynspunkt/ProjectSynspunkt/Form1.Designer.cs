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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nicklaskruse_dk_db_webdatabaseDataSet = new ProjectSynspunkt.nicklaskruse_dk_db_webdatabaseDataSet();
            this.synsPunktKunderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synsPunktKunderTableAdapter = new ProjectSynspunkt.nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktKunderTableAdapter();
            this.synsPunktVarerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.synsPunktVarerTableAdapter = new ProjectSynspunkt.nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktVarerTableAdapter();
            this.synsPunktKunderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kundeNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bynavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicklaskruse_dk_db_webdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktKunderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktVarerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktKunderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kundeNrDataGridViewTextBoxColumn,
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.bynavnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.synsPunktKunderBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(372, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // synsPunktVarerBindingSource
            // 
            this.synsPunktVarerBindingSource.DataMember = "SynsPunktVarer";
            this.synsPunktVarerBindingSource.DataSource = this.nicklaskruse_dk_db_webdatabaseDataSet;
            // 
            // synsPunktVarerTableAdapter
            // 
            this.synsPunktVarerTableAdapter.ClearBeforeFill = true;
            // 
            // synsPunktKunderBindingSource1
            // 
            this.synsPunktKunderBindingSource1.DataMember = "SynsPunktKunder";
            this.synsPunktKunderBindingSource1.DataSource = this.nicklaskruse_dk_db_webdatabaseDataSet;
            // 
            // kundeNrDataGridViewTextBoxColumn
            // 
            this.kundeNrDataGridViewTextBoxColumn.DataPropertyName = "kundeNr";
            this.kundeNrDataGridViewTextBoxColumn.HeaderText = "kundeNr";
            this.kundeNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kundeNrDataGridViewTextBoxColumn.Name = "kundeNrDataGridViewTextBoxColumn";
            this.kundeNrDataGridViewTextBoxColumn.ReadOnly = true;
            this.kundeNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "fornavn";
            this.fornavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            this.fornavnDataGridViewTextBoxColumn.Width = 150;
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "efternavn";
            this.efternavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            this.efternavnDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // bynavnDataGridViewTextBoxColumn
            // 
            this.bynavnDataGridViewTextBoxColumn.DataPropertyName = "bynavn";
            this.bynavnDataGridViewTextBoxColumn.HeaderText = "bynavn";
            this.bynavnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bynavnDataGridViewTextBoxColumn.Name = "bynavnDataGridViewTextBoxColumn";
            this.bynavnDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 1060);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicklaskruse_dk_db_webdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktKunderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktVarerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.synsPunktKunderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private nicklaskruse_dk_db_webdatabaseDataSet nicklaskruse_dk_db_webdatabaseDataSet;
        private System.Windows.Forms.BindingSource synsPunktKunderBindingSource;
        private nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktKunderTableAdapter synsPunktKunderTableAdapter;
        private System.Windows.Forms.BindingSource synsPunktVarerBindingSource;
        private nicklaskruse_dk_db_webdatabaseDataSetTableAdapters.SynsPunktVarerTableAdapter synsPunktVarerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bynavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource synsPunktKunderBindingSource1;
    }
}

