using System;
using System.Collections.Generic;
using MediaTek.bddmanager;

namespace MediaTek.dal
{
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
    }
}
