using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    public class Personnel
    {
        public int idPersonnel { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public string Tel { get; }
        public string Mail { get; }
        public int idService { get; }
        
        /// <summary>
        /// Constructeur de Personnel
        /// </summary>
        /// <param name="idpersonnel">id du personnel</param>
        /// <param name="nom">nom du personnel</param>
        /// <param name="prenom">prenom du personnel</param>
        /// <param name="tel">tel du personnel </param>
        /// <param name="mail">mail du personnel</param>
        /// <param name="idservice">id du service du personnel</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            this.idPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.idService = idservice;
        }
    }
}
