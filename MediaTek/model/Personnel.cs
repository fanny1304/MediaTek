using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    /// <summary>
    /// Classe qui permet de gérer les personnels
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Getter sur l'id du personnel
        /// </summary>
        public int idPersonnel { get; }
        /// <summary>
        /// Getter sur le nom du personnel
        /// </summary>
        public string Nom { get; }
        /// <summary>
        /// Getter sur le prenom du personnel
        /// </summary>
        public string Prenom { get; }
        /// <summary>
        /// Getter sur le tel du personnel
        /// </summary>
        public string Tel { get; }
        /// <summary>
        /// Getter sur le mail du personnel
        /// </summary>
        public string Mail { get; }
        /// <summary>
        /// Getter sur l'id du service associé au personnel
        /// </summary>
        public int idService { get; }
        /// <summary>
        /// Getter sur le nom du service associé au personnel
        /// </summary>
        public string Service { get; }
        
        /// <summary>
        /// Constructeur de Personnel
        /// </summary>
        /// <param name="idpersonnel">id du personnel</param>
        /// <param name="nom">nom du personnel</param>
        /// <param name="prenom">prenom du personnel</param>
        /// <param name="tel">tel du personnel </param>
        /// <param name="mail">mail du personnel</param>
        /// <param name="idservice">id du service du personnel</param>*
        /// <param name="service">service associé au personnel</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.idPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.idService = idservice;
            this.Service = service;
        }
    }
}
