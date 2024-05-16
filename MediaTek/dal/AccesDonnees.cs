using System;
using System.Collections.Generic;
using MediaTek.bddmanager;
using MediaTek.model;

namespace MediaTek.dal
{
    /// <summary>
    /// Classe permettant l'accès aux données
    /// </summary>
    public class AccesDonnees
    {
        /// <summary>
        /// Chaîne de connexion à la bdd
        /// </summary>
        private static readonly string connectionString = "server=localhost;user id=root;database=mediatek";

        /// <summary>
        /// Vérifie si l'utilisateur a le droit de se connecter
        /// </summary>
        /// <param name="login">Login inséré lors de la tentative de connexion</param>
        /// <param name="pwd">Mot de passe inséré lors de la tentative de connexion</param>
        /// <returns>Vrai si les identifiants correspondent </returns>
        public static Boolean Authentification(string login, string pwd)
        {
            string req = "SELECT * FROM responsable ";
            req += "WHERE login = @login AND pwd = SHA2(@pwd, 256);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);

            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>Liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as service";
            req += " from personnel p join service s on (p.idservice = s.idservice) ";
            req += " order by p.nom, p.prenom;";


            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Personnel personnel = new Personnel(
                    (int)curseur.Field("idpersonnel"), 
                    (string)curseur.Field("nom"), 
                    (string)curseur.Field("prenom"), 
                    (string)curseur.Field("tel"), 
                    (string)curseur.Field("mail"), 
                    (int)curseur.Field("idservice"), 
                    (string)curseur.Field("service"));

                lesPersonnels.Add(personnel);
            }
            curseur.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>Liste des services</returns>       
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();

            // Requête SQL
            string req = "SELECT * FROM service;";
            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);

            while (curseur.Read())
            {
                Service service = new Service(
                    (int)curseur.Field("idservice"),
                    (string)curseur.Field("nom")
                    );
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// Ajouter un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(nom, prenom, tel, mail, idservice)";
            req += "VALUES(@nom, @prenom, @tel, @mail, @idservice); ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.idService);

            BddManager connex = BddManager.GetInstance(connectionString);
            connex.ReqUpdate(req, parameters);
        }
        
        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            string req = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.idPersonnel);
            BddManager conn = BddManager.GetInstance(connectionString);
            conn.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel 
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.idPersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            parameters.Add("@idservice", personnel.idService);

            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqUpdate(req, parameters);


        }

        /// <summary>
        /// Récupère et retourne les absences pour un personnel
        /// </summary>
        /// <param name="idpersonnelSelect">id du personnel dont on récupère les absences</param>
        /// <returns>Liste des absences</returns>
        public static List<Absence> getLesAbsences(int idpersonnelSelect)
        {
            List<Absence> lesAbsences = new List<Absence>();

            string req = "SELECT p.idpersonnel AS personnel, a.datedebut AS datedebut, a.datefin AS datefin, m.idmotif AS idmotif, m.motif AS motif ";
            req += "FROM personnel AS p JOIN absence a ON (p.idpersonnel = a.idpersonnel) JOIN motif m on (a.idmotif = m.idmotif)";
            req += "WHERE p.idpersonnel = @idpersonnelSelect";
            req += "ORDER BY datedebut DESC;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnelSelect", idpersonnelSelect);

            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);
            
            while (curseur.Read())
            {
                Absence absence = new Absence(
                    (int)curseur.Field("idpersonnel"), 
                    (int)curseur.Field("idmotif"),
                    (DateTime)curseur.Field("datedebut"),
                    (DateTime)curseur.Field("datefin"), 
                    (string)curseur.Field("motif")
                    );
                lesAbsences.Add(absence);
            }
            curseur.Close();
            return lesAbsences;
        }

        /// <summary>
        /// Ajouter une absence 
        /// </summary>
        /// <param name="absence">Objet absence à ajouter</param>
        /// <param name="idpersonnelSelec">Id du personnel concerné par l'absence </param>
        public void AddAbsence(Absence absence, int idpersonnelSelec)
        {
            string req = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif)";
            req += "VALUES(@idpersonnelSelec, @datedebut, @datefin, @idmotif);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnelSelec", idpersonnelSelec);
            parameters.Add("@datedebut", absence.dateDebut);
            parameters.Add("@datefin", absence.dateFin);
            parameters.Add("@idmotif", absence.IdMotif);

            BddManager connex = BddManager.GetInstance(connectionString);
            connex.ReqUpdate(req, parameters);
        }

        
        /// <summary>
        /// Supprimer une absence 
        /// </summary>
        /// <param name="absence">Objet absence à supprimer</param>
        /// <param name="idpersonnelSelec">Id du personnel concerné par l'absence</param>
        public void DelAbsence(Absence absence, int idpersonnelSelec)
        {
            string req = "DELETE FROM absence ";
            req += "WHERE datedebut = @datedebut";
            req += "AND idpersonnel = @idpersonnelSelec;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.dateDebut);
            parameters.Add("@idpersonnelSelec", idpersonnelSelec);

            BddManager connex = BddManager.GetInstance(connectionString);
            connex.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'une absence 
        /// </summary>
        /// <param name="absence">Objet absence à modifier</param>
        /// <param name="idpersonnelSelect">id du personnel concerné par l'absence</param>
        /// <param name="dateSelect">date concernée par l'absence </param>
        public void updateAbsence(Absence absence, int idpersonnelSelect, DateTime dateSelect)
        {
            string req = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif";
            req += "WHERE idpersonnel = @idpersonnelSelect AND datedebut = @dateSelect;";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.dateDebut);
            parameters.Add("@datefin", absence.dateFin);
            parameters.Add("@idmotif", absence.IdMotif);
            parameters.Add("@idpersonnelSelect", idpersonnelSelect);
            parameters.Add("@dateSelect", dateSelect);

            BddManager connex = BddManager.GetInstance(connectionString);
            connex.ReqUpdate(req, parameters);

        }

        /// <summary>
        /// Récupère et retourne les motifs de la bdd
        /// </summary>
        /// <returns>liste des motifs</returns>
        public static List<Motif> GetLesMotifs()
        {
            List<Motif> lesMotifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER BY libelle;";

            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif(
                    (int)curseur.Field("idmotif"),
                    (string)curseur.Field("libelle")
                    );
                lesMotifs.Add(motif);
            }
            curseur.Close();
            return lesMotifs;
        }


        /// <summary>
        /// Récupération de l'id du personnel sélectionné
        /// </summary>
        /// <param name="nom">Nom du personnel selectionné</param>
        /// <param name="prenom">Prénom du personnel selectionné</param>
        /// <returns>Id du personnel sélectionné</returns>
        public int recupererIdPersonnel(string nom, string prenom)
        {
            int idpersonnel = 0;
            string req = "SELECT idpersonnel FROM personnel";
            req += "WHERE nom = '" + nom + "' AND prenom = '" + prenom + "';";

            BddManager curseur = BddManager.GetInstance(connectionString);
            curseur.ReqSelect(req, null);

            while (curseur.Read())
            {
                idpersonnel = (int)curseur.Field("idpersonnel");
            }
            return idpersonnel;
        }


    }
}