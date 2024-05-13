using MediaTek.dal;
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
        private FrmAuthentification frmAuthentification;
        
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
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


    }
}
