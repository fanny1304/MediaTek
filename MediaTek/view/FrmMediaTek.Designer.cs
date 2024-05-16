
namespace MediaTek.view
{
    partial class FrmMediaTek
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mediatekDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediatekDataSet = new MediaTek.mediatekDataSet();
            this.btnModifPers = new System.Windows.Forms.Button();
            this.btnSuppPers = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnAnnPers = new System.Windows.Forms.Button();
            this.btnEnregPers = new System.Windows.Forms.Button();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mediatekDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatekDataSet)).BeginInit();
            this.grbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des personnels";
            // 
            // mediatekDataSetBindingSource
            // 
            this.mediatekDataSetBindingSource.DataSource = this.mediatekDataSet;
            this.mediatekDataSetBindingSource.Position = 0;
            // 
            // mediatekDataSet
            // 
            this.mediatekDataSet.DataSetName = "mediatekDataSet";
            this.mediatekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnModifPers
            // 
            this.btnModifPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifPers.Location = new System.Drawing.Point(72, 264);
            this.btnModifPers.Name = "btnModifPers";
            this.btnModifPers.Size = new System.Drawing.Size(134, 25);
            this.btnModifPers.TabIndex = 4;
            this.btnModifPers.Text = "Modifier le personnel";
            this.btnModifPers.UseVisualStyleBackColor = true;
            this.btnModifPers.Click += new System.EventHandler(this.btnModifPers_Click);
            // 
            // btnSuppPers
            // 
            this.btnSuppPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppPers.Location = new System.Drawing.Point(217, 264);
            this.btnSuppPers.Name = "btnSuppPers";
            this.btnSuppPers.Size = new System.Drawing.Size(148, 25);
            this.btnSuppPers.TabIndex = 5;
            this.btnSuppPers.Text = "Supprimer le personnel";
            this.btnSuppPers.UseVisualStyleBackColor = true;
            this.btnSuppPers.Click += new System.EventHandler(this.btnSuppPers_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.Location = new System.Drawing.Point(375, 264);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(136, 25);
            this.btnAbsences.TabIndex = 6;
            this.btnAbsences.Text = "Gérer les absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnAnnPers);
            this.grbAction.Controls.Add(this.btnEnregPers);
            this.grbAction.Controls.Add(this.cboService);
            this.grbAction.Controls.Add(this.label7);
            this.grbAction.Controls.Add(this.txtMail);
            this.grbAction.Controls.Add(this.txtTel);
            this.grbAction.Controls.Add(this.txtPrenom);
            this.grbAction.Controls.Add(this.txtNom);
            this.grbAction.Controls.Add(this.label6);
            this.grbAction.Controls.Add(this.label5);
            this.grbAction.Controls.Add(this.label4);
            this.grbAction.Controls.Add(this.label3);
            this.grbAction.Controls.Add(this.lblAction);
            this.grbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAction.Location = new System.Drawing.Point(14, 306);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(588, 153);
            this.grbAction.TabIndex = 7;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Actions";
            // 
            // btnAnnPers
            // 
            this.btnAnnPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnPers.Location = new System.Drawing.Point(280, 124);
            this.btnAnnPers.Name = "btnAnnPers";
            this.btnAnnPers.Size = new System.Drawing.Size(75, 23);
            this.btnAnnPers.TabIndex = 12;
            this.btnAnnPers.Text = "Annuler";
            this.btnAnnPers.UseVisualStyleBackColor = true;
            this.btnAnnPers.Click += new System.EventHandler(this.btnAnnPers_Click);
            // 
            // btnEnregPers
            // 
            this.btnEnregPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregPers.Location = new System.Drawing.Point(199, 124);
            this.btnEnregPers.Name = "btnEnregPers";
            this.btnEnregPers.Size = new System.Drawing.Size(75, 23);
            this.btnEnregPers.TabIndex = 11;
            this.btnEnregPers.Text = "Enregistrer";
            this.btnEnregPers.UseVisualStyleBackColor = true;
            this.btnEnregPers.Click += new System.EventHandler(this.btnEnregPers_Click);
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(72, 93);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(168, 21);
            this.cboService.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Service :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(349, 67);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(169, 20);
            this.txtMail.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(349, 42);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(169, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(72, 67);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(169, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(72, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 20);
            this.txtNom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "N° Téléphone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom :";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(7, 20);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(131, 15);
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = "Ajouter un personnel :";
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(12, 37);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.Size = new System.Drawing.Size(578, 221);
            this.dgvPersonnels.TabIndex = 8;
            // 
            // FrmMediaTek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 483);
            this.Controls.Add(this.dgvPersonnels);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnSuppPers);
            this.Controls.Add(this.btnModifPers);
            this.Controls.Add(this.label1);
            this.Name = "FrmMediaTek";
            this.Text = " MediaTek";
            ((System.ComponentModel.ISupportInitialize)(this.mediatekDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediatekDataSet)).EndInit();
            this.grbAction.ResumeLayout(false);
            this.grbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource mediatekDataSetBindingSource;
        private mediatekDataSet mediatekDataSet;
        private System.Windows.Forms.Button btnModifPers;
        private System.Windows.Forms.Button btnSuppPers;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Button btnAnnPers;
        private System.Windows.Forms.Button btnEnregPers;
        private System.Windows.Forms.DataGridView dgvPersonnels;
    }
}

