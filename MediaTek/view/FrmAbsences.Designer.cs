
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
            this.lblNom = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjoutAbs = new System.Windows.Forms.Button();
            this.btnModifAbs = new System.Windows.Forms.Button();
            this.btnSuppAbs = new System.Windows.Forms.Button();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnAnnAbs = new System.Windows.Forms.Button();
            this.btnEnregAbs = new System.Windows.Forms.Button();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbAction.SuspendLayout();
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
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.SystemColors.Control;
            this.lblNom.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(180, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(119, 24);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "prenom nom";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(16, 71);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(463, 221);
            this.dgvAbsences.TabIndex = 4;
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
            // grbAction
            // 
            this.grbAction.Controls.Add(this.cboMotif);
            this.grbAction.Controls.Add(this.dtpFin);
            this.grbAction.Controls.Add(this.btnAnnAbs);
            this.grbAction.Controls.Add(this.btnEnregAbs);
            this.grbAction.Controls.Add(this.dtpDebut);
            this.grbAction.Controls.Add(this.label7);
            this.grbAction.Controls.Add(this.label4);
            this.grbAction.Controls.Add(this.label3);
            this.grbAction.Controls.Add(this.lblAction);
            this.grbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAction.Location = new System.Drawing.Point(16, 343);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(463, 171);
            this.grbAction.TabIndex = 8;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Actions";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(152, 93);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(200, 21);
            this.cboMotif.TabIndex = 15;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(152, 67);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 14;
            // 
            // btnAnnAbs
            // 
            this.btnAnnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnAbs.Location = new System.Drawing.Point(234, 130);
            this.btnAnnAbs.Name = "btnAnnAbs";
            this.btnAnnAbs.Size = new System.Drawing.Size(75, 23);
            this.btnAnnAbs.TabIndex = 12;
            this.btnAnnAbs.Text = "Annuler";
            this.btnAnnAbs.UseVisualStyleBackColor = true;
            // 
            // btnEnregAbs
            // 
            this.btnEnregAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregAbs.Location = new System.Drawing.Point(143, 130);
            this.btnEnregAbs.Name = "btnEnregAbs";
            this.btnEnregAbs.Size = new System.Drawing.Size(75, 23);
            this.btnEnregAbs.TabIndex = 11;
            this.btnEnregAbs.Text = "Enregistrer";
            this.btnEnregAbs.UseVisualStyleBackColor = true;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(152, 43);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 13;
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
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(7, 20);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(127, 15);
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = "Ajouter une absence :";
            // 
            // FrmAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 543);
            this.Controls.Add(this.btnSuppAbs);
            this.Controls.Add(this.btnModifAbs);
            this.Controls.Add(this.btnAjoutAbs);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbAction);
            this.Name = "FrmAbsences";
            this.Text = "FrmAbsences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbAction.ResumeLayout(false);
            this.grbAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjoutAbs;
        private System.Windows.Forms.Button btnModifAbs;
        private System.Windows.Forms.Button btnSuppAbs;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button btnAnnAbs;
        private System.Windows.Forms.Button btnEnregAbs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cboMotif;
    }
}