using MediaTek.controleur;
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
    /// Formulaire d'affichage des informations des personnels
    /// </summary>
    public partial class FrmMediaTek : Form
    {
        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée 
        /// </summary>
        private Boolean enCoursDeModif = false;
        /// <summary>
        /// Objet pour gérer la liste des personnels 
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services 
        /// </summary>
        private BindingSource bdgService = new BindingSource();


        /// <summary>
        /// Initialisation des composants graphiques
        /// </summary>
        /// <param name="controle"></param>
        public FrmMediaTek(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Remplissage des listes 
        /// </summary>
        private void Init()
        {
            RemplirDGVPersonnels();
            RemplirCBOServices();
            EnCoursModif(false);
        }

        /// <summary>
        /// Affiche les personnels 
        /// </summary>
        private void RemplirDGVPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idPersonnel"].Visible = false;
            dgvPersonnels.Columns["idService"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Initialisations : 
        /// Remplissage du combo
        /// </summary>
        private void RemplirCBOServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cboService.DataSource = bdgService;
        }

 

        /// <summary>
        /// Modification de l'affichage suivant si on est en cours de modification ou non
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModif(Boolean modif)
        {
            enCoursDeModif = modif;
            grbAction.Enabled = modif;
            if (modif)
            {
                lblAction.Text = "Modifier un personnel :";
            }
            else
            {
                grbAction.Enabled = !modif;
                lblAction.Text = "Ajouter un personnel : ";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
                cboService.SelectedIndex = -1;
                txtNom.Focus();
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                EnCoursModif(true);
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
            }
            else
            {
                MessageBox.Show("Une ligne correspondant à un personnel doit être sélectionnée.", "Information");
            }
        }


        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPers_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                int idPersonnel = 0;

                if (enCoursDeModif)
                {
                    Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTel.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.idService = service.idService;
                    personnel.Service = service.Nom;
                    controle.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(idPersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.idService, service.Nom);
                    controle.AddPersonnel(personnel);
                }
                RemplirDGVPersonnels();
                EnCoursModif(false);
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un développeur 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnPers_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModif(false);
            }
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppPers_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel);
                    RemplirDGVPersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
