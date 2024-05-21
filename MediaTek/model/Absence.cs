using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    /// <summary>
    /// Classe qui permet de gérer les absences
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Getter sur l'idpersonnel
        /// </summary>
        public int IdPersonnel { get; set; }
        /// <summary>
        /// Getter sur l'idmotif
        /// </summary>
        public int IdMotif { get; set; }
        /// <summary>
        /// Getter sur la date de début 
        /// </summary>
        public DateTime dateDebut { get; set; }
        /// <summary>
        /// Getter sur la date de fin 
        /// </summary>
        public DateTime dateFin { get; set; }
        /// <summary>
        /// Getter sur le motif 
        /// </summary>
        public string Motif { get; set; }
        
        /// <summary>
        /// Constructeur de l'absence
        /// </summary>
        /// <param name="idpersonnel">Id du personnel</param>
        /// <param name="idmotif">Id du motif de l'absence</param>
        /// <param name="datedebut">Date de début de l'absence</param>
        /// <param name="datefin">Date de fin de l'absence</param>
        /// <param name="motif">Motif de l'absence</param>
        public Absence(int idpersonnel, int idmotif, DateTime datedebut, DateTime datefin, string motif)
        {
            this.IdPersonnel = idpersonnel;
            this.IdMotif = idmotif;
            this.dateDebut = datedebut;
            this.dateFin = datefin;
            this.Motif = motif;
        }
    }
}
