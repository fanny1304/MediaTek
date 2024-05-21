using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek.controleur;
using MediaTek.view;

/// <summary>
/// Application MediaTek
/// </summary>
namespace MediaTek
{
    /// <summary>
    /// Programme MediaTek
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Controle(); 
        }
    }
}
