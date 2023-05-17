namespace Synspunkt_winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btn_createVare = new Button();
            btn_updateVare = new Button();
            btn_deleteVare = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(409, 397);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(539, 415);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // btn_createVare
            // 
            btn_createVare.Location = new Point(12, 364);
            btn_createVare.Name = "btn_createVare";
            btn_createVare.Size = new Size(75, 45);
            btn_createVare.TabIndex = 3;
            btn_createVare.Text = "Create";
            btn_createVare.UseVisualStyleBackColor = true;
            btn_createVare.Click += btn_createVare_Click;
            // 
            // btn_updateVare
            // 
            btn_updateVare.Location = new Point(149, 364);
            btn_updateVare.Name = "btn_updateVare";
            btn_updateVare.Size = new Size(75, 45);
            btn_updateVare.TabIndex = 4;
            btn_updateVare.Text = "Update";
            btn_updateVare.UseVisualStyleBackColor = true;
            // 
            // btn_deleteVare
            // 
            btn_deleteVare.Location = new Point(298, 364);
            btn_deleteVare.Name = "btn_deleteVare";
            btn_deleteVare.Size = new Size(75, 45);
            btn_deleteVare.TabIndex = 5;
            btn_deleteVare.Text = "Delete";
            btn_deleteVare.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 7;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 23);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 232);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(124, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(249, 23);
            textBox5.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(btn_deleteVare);
            Controls.Add(btn_updateVare);
            Controls.Add(btn_createVare);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Button btn_createVare;
        private Button btn_updateVare;
        private Button btn_deleteVare;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}