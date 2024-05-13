
namespace MediaTek.view
{
    partial class FrmAbsences
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjoutAbs = new System.Windows.Forms.Button();
            this.btnModifAbs = new System.Windows.Forms.Button();
            this.btnSuppAbs = new System.Windows.Forms.Button();
            this.gpbAction = new System.Windows.Forms.GroupBox();
            this.btnAnnPers = new System.Windows.Forms.Button();
            this.btnEnregPers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cboService = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des absences de :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "prenom nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 221);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAjoutAbs
            // 
            this.btnAjoutAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAjoutAbs.Location = new System.Drawing.Point(28, 298);
            this.btnAjoutAbs.Name = "btnAjoutAbs";
            this.btnAjoutAbs.Size = new System.Drawing.Size(134, 25);
            this.btnAjoutAbs.TabIndex = 5;
            this.btnAjoutAbs.Text = "Ajouter une absence";
            this.btnAjoutAbs.UseVisualStyleBackColor = true;
            // 
            // btnModifAbs
            // 
            this.btnModifAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModifAbs.Location = new System.Drawing.Point(168, 298);
            this.btnModifAbs.Name = "btnModifAbs";
            this.btnModifAbs.Size = new System.Drawing.Size(134, 25);
            this.btnModifAbs.TabIndex = 6;
            this.btnModifAbs.Text = "Modifier une absence";
            this.btnModifAbs.UseVisualStyleBackColor = true;
            // 
            // btnSuppAbs
            // 
            this.btnSuppAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuppAbs.Location = new System.Drawing.Point(308, 298);
            this.btnSuppAbs.Name = "btnSuppAbs";
            this.btnSuppAbs.Size = new System.Drawing.Size(157, 25);
            this.btnSuppAbs.TabIndex = 7;
            this.btnSuppAbs.Text = "Supprimer une absence";
            this.btnSuppAbs.UseVisualStyleBackColor = true;
            // 
            // gpbAction
            // 
            this.gpbAction.Controls.Add(this.cboService);
            this.gpbAction.Controls.Add(this.dateTimePicker2);
            this.gpbAction.Controls.Add(this.btnAnnPers);
            this.gpbAction.Controls.Add(this.btnEnregPers);
            this.gpbAction.Controls.Add(this.dateTimePicker1);
            this.gpbAction.Controls.Add(this.label7);
            this.gpbAction.Controls.Add(this.label4);
            this.gpbAction.Controls.Add(this.label3);
            this.gpbAction.Controls.Add(this.label8);
            this.gpbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAction.Location = new System.Drawing.Point(16, 343);
            this.gpbAction.Name = "gpbAction";
            this.gpbAction.Size = new System.Drawing.Size(463, 171);
            this.gpbAction.TabIndex = 8;
            this.gpbAction.TabStop = false;
            this.gpbAction.Text = "Actions";
            // 
            // btnAnnPers
            // 
            this.btnAnnPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnPers.Location = new System.Drawing.Point(234, 130);
            this.btnAnnPers.Name = "btnAnnPers";
            this.btnAnnPers.Size = new System.Drawing.Size(75, 23);
            this.btnAnnPers.TabIndex = 12;
            this.btnAnnPers.Text = "Annuler";
            this.btnAnnPers.UseVisualStyleBackColor = true;
            // 
            // btnEnregPers
            // 
            this.btnEnregPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregPers.Location = new System.Drawing.Point(143, 130);
            this.btnEnregPers.Name = "btnEnregPers";
            this.btnEnregPers.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPers.TabIndex = 11;
            this.btnEnregPers.Text = "Enregistrer";
            this.btnEnregPers.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Motif :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date de fin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date de début :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ajouter une absence :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(152, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(152, 93);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(200, 21);
            this.cboService.TabIndex = 15;
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 543);
            this.Controls.Add(this.btnSuppAbs);
            this.Controls.Add(this.btnModifAbs);
            this.Controls.Add(this.btnAjoutAbs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbAction);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbAction.ResumeLayout(false);
            this.gpbAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjoutAbs;
        private System.Windows.Forms.Button btnModifAbs;
        private System.Windows.Forms.Button btnSuppAbs;
        private System.Windows.Forms.GroupBox gpbAction;
        private System.Windows.Forms.Button btnAnnPers;
        private System.Windows.Forms.Button btnEnregPers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboService;
    }
}