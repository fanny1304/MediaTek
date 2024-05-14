using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    /// <summary>
    /// Classe permettant de gérer les services
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Getter sur l'id du service 
        /// </summary>
        public int idService { get; }
        /// <summary>
        /// Getter sur le nom du service 
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Constructeur de service
        /// </summary>
        /// <param name="idservice">id du service</param>
        /// <param name="nom">nom du service</param>
        public Service(int idservice, string nom)
        {
            this.idService = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }

    }
}
