using MediaTek.controleur;
using MediaTek.dal;
using MediaTek.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek.view
{
    /// <summary>
    /// Formulaire de gestion des absences 
    /// </summary>
    public partial class FrmAbsences : Form
    {

        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Booléan pour savoir si une modification est en cours
        /// </summary>
        private Boolean enCoursDeModif = false;
        /// <summary>
        /// Initialisation de la variable idpersonnel 
        /// </summary>
        public int idpersonnelSelect;
        /// <summary>
        /// Objet pour gérer la liste des personnels 
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services 
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// </summary>
        /// <param name="controle"></param>
        public FrmAbsences(Controle controle, int idPersonnel, string nom, string prenom)
        {
            InitializeComponent();
            this.controle = controle;
            this.idpersonnelSelect = idPersonnel;
            lblNom.Text = prenom + " " + nom ;
            Init();
        }


        /// <summary>
        /// Initialisation de la fenêtre
        /// </summary>
        public void Init()
        {
            RemplirDGVAbsences(idpersonnelSelect);
            RemplirCBOMotifs();
            EnCoursModif(false);
        }

        /// <summary>
        /// Modification de l'affichage suivant si on est en cours de modification ou non
        /// </summary>
        /// <param name="modif">booléen</param>
        private void EnCoursModif(Boolean modif)
        {
            enCoursDeModif = modif;
            grbAction.Enabled = modif;
            if (modif)
            {
                lblAction.Text = "Modifier une absence : ";
            }
            else
            {
                grbAction.Enabled = !modif;
                lblAction.Text = "Ajouter une absence : ";
                dtpDebut.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now;
                cboMotif.SelectedIndex = -1;
                dtpDebut.Focus();
            }
        }
        /// <summary>
        /// Affiche les absences
        /// </summary>
        /// <param name="idpersonnelSelect">Id du personnel sélectionné</param>
        private void RemplirDGVAbsences(int idpersonnelSelect)
        {
            List<Absence> lesAbsences = controle.getLesAbsences(idpersonnelSelect);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idPersonnel"].Visible = false;
            dgvAbsences.Columns["idMotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// Initialisations : remplissage du combo
        /// </summary>
        private void RemplirCBOMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursModif(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDebut.Value = absence.dateDebut;
                dtpFin.Value = absence.dateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif);
            }
            else
            {
                MessageBox.Show("Une ligne correspondant à une absence doit être sélectionnée", "Information");
            }
        }
        
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregAbs_Click(object sender, EventArgs e)
        {
            if (!dtpDebut.Value.Equals("") && !dtpFin.Value.Equals("") && cboMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                Absence absAvModif = (Absence)bdgAbsences.List[bdgAbsences.Position];
                DateTime dateDebutSelect = absAvModif.dateDebut;
                int idPersonnelSelect = idpersonnelSelect;

                if (enCoursDeModif)
                {
                    if (dtpFin.Value > dtpDebut.Value)
                    {
                        Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                        
                        absence.dateDebut = dtpDebut.Value;
                        absence.dateFin = dtpFin.Value;
                        absence.IdMotif = motif.idMotif;
                        absence.Motif = motif.Libelle;
                        controle.updateAbsence(absence, idPersonnelSelect, dateDebutSelect);

                    }
                    else
                    {
                        MessageBox.Show("La date de fin de l'absence ne peut pas avoir lieu avant la date de début de l'absence", "Alerte");
                    }
                }
                else
                {
                    if (dtpFin.Value > dtpDebut.Value)
                    {
                        Absence absence = new Absence(idPersonnelSelect, motif.idMotif, dtpDebut.Value, dtpFin.Value, motif.Libelle);
                        controle.AddAbsence(absence, idpersonnelSelect);
                    }
                    else
                    {
                        MessageBox.Show("La date de fin de l'absence ne peut pas avoir lieu avant la date de début de l'absence", "Alerte");
                    }
                }
                RemplirDGVAbsences(idPersonnelSelect);
                EnCoursModif(false);
            }
            else
            {
                MessageBox.Show("Toutes les cases doivent être remplies", "Information");
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnAbs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModif(false);
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence allant du " + absence.dateDebut + " au " + absence.dateFin + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsence(absence, idpersonnelSelect);
                    RemplirDGVAbsences(idpersonnelSelect);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Alerte");
            }
        }
    }
}
