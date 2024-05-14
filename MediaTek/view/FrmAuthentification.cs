using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek.controleur;

namespace MediaTek.view
{
    /// <summary>
    /// Fenêtre d'authentification
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Instance de la classe controle 
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="controle"></param>
        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Procédure évenementielle du bouton de connexion 
        /// il faut d'abord vérifier que les identifiants sont corrects 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.Authentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte.", "Alerte");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Alerte");
            }

        }
    }
}
