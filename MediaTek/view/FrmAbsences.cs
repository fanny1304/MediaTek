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
            //RemplirCBOMotifs();
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


    }
}
