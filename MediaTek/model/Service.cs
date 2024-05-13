using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    public class Service
    {
        public int idService { get; }
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
