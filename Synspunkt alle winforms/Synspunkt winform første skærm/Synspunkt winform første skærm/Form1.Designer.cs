namespace Synspunkt_winform_første_skærm
{
    partial class form_dataValg
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
            label1 = new Label();
            btn_valgVare = new Button();
            btn_valgKunder = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(337, 76);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Velkommen";
            label1.Click += label1_Click;
            // 
            // btn_valgVare
            // 
            btn_valgVare.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_valgVare.Location = new Point(153, 295);
            btn_valgVare.Name = "btn_valgVare";
            btn_valgVare.Size = new Size(139, 71);
            btn_valgVare.TabIndex = 1;
            btn_valgVare.Text = "Vare";
            btn_valgVare.UseVisualStyleBackColor = true;
            // 
            // btn_valgKunder
            // 
            btn_valgKunder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_valgKunder.Location = new Point(510, 295);
            btn_valgKunder.Name = "btn_valgKunder";
            btn_valgKunder.Size = new Size(139, 71);
            btn_valgKunder.TabIndex = 2;
            btn_valgKunder.Text = "Kunder";
            btn_valgKunder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 194);
            label2.Name = "label2";
            label2.Size = new Size(370, 20);
            label2.TabIndex = 3;
            label2.Text = "Hvilken database kunne du tænke dig at arbejde med?";
            // 
            // form_dataValg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btn_valgKunder);
            Controls.Add(btn_valgVare);
            Controls.Add(label1);
            Name = "form_dataValg";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_valgVare;
        private Button btn_valgKunder;
        private Label label2;
    }
}