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

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.Authentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information");
            }
        }
    }
}
