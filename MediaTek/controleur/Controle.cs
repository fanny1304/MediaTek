using MediaTek.dal;
using MediaTek.model;
using MediaTek.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek.controleur
{
    /// <summary>
    /// gère les interactions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Fenêtre d'authentification
        /// </summary>
        private readonly FrmAuthentification frmAuthentification;
        /// <summary>
        /// Objet faisant le lien avec AccesDonnees
        /// </summary>
        private readonly AccesDonnees accesDonnees;
        
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            accesDonnees = new AccesDonnees();
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        /// <summary>
        /// Demande la vérification de l'authentification
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns>Vérification de l'authentification</returns>
        public Boolean Authentification(string login, string pwd)
        {
            if (AccesDonnees.Authentification(login, pwd))
            {
                // masquer la fenêtre d'authentification
                frmAuthentification.Hide();
                // afficher la fenêtre de gestion du personnel 
                (new FrmMediaTek(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels 
        /// </summary>
        /// <returns>Liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns></returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            accesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            accesDonnees.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à modifier </param>
        public void UpdatePersonnel(Personnel personnel)
        {
            accesDonnees.UpdatePersonnel(personnel);
        }
        

        /// <summary>
        /// Récupère et retourne les absences d'un personnel
        /// </summary>
        /// <param name="idpersonnelSelec">id du personnel concerné</param>
        /// <returns>liste des absences </returns>
        public List<Absence> getLesAbsences(int idpersonnelSelec)
        {
            return AccesDonnees.getLesAbsences(idpersonnelSelec);
        } 

        /// <summary>
        /// Demande d'ajout d'une absence pour un personnel sélectionné
        /// </summary>
        /// <param name="absence">Objet absence à ajouter</param>
        /// <param name="idpersonnelSelec">id du personnel concerné</param>
        public void AddAbsence(Absence absence, int idpersonnelSelec)
        {
            accesDonnees.AddAbsence(absence, idpersonnelSelec);
        }

        /// <summary>
        /// Demande de suppression d'une absence pour un personnel sélectionné
        /// </summary>
        /// <param name="absence">Objet absence à supprimer </param>
        /// <param name="idpersonnelSelec">id du personnel concerné</param>
        public void DelAbsence(Absence absence, int idpersonnelSelec)
        {
            accesDonnees.DelAbsence(absence, idpersonnelSelec);
        }

        /// <summary>
        /// Demande de modification d'une absence pour un personnel sélectionné
        /// </summary>
        /// <param name="absence">Objet absence à modifier </param>
        /// <param name="idpersonnelSelect">id du personnel concerné</param>
        /// <param name="dateSelect">date de début de l'absence</param>
        public void updateAbsence(Absence absence, int idpersonnelSelect, DateTime dateSelect)
        {
            accesDonnees.updateAbsence(absence, idpersonnelSelect, dateSelect);
        }

        /// <summary>
        /// Recupère et retourne la liste des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// La fenêtre de gestion des absences apparaît
        /// </summary>
        /// <param name="nom">Nom du personnel concerné par les absences</param>
        /// <param name="prenom">Prenom du personnel </param>
        /// <returns>Affichage de la fenêtre de getsion des absences </returns>
        public Boolean Absences(int idPersonnel, string nom, string prenom)
        {
            FrmAbsences var = new FrmAbsences(this, idPersonnel, nom, prenom);
            var.ShowDialog();
            return true;
        }


    }
}
