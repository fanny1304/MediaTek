using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    public class Absence
    {
        public int IdPersonnel { get; }
        public int IdMotif { get; }
        public DateTime dateDebut { get; }
        public DateTime dateFin { get; }
        
        /// <summary>
        /// Constructeur de l'absence
        /// </summary>
        /// <param name="idpersonnel">Id du personnel</param>
        /// <param name="idmotif">Id du motif de l'absence</param>
        /// <param name="datedebut">Date de début de l'absence</param>
        /// <param name="datefin">Date de fin de l'absence</param>
        public Absence(int idpersonnel, int idmotif, DateTime datedebut, DateTime datefin)
        {
            this.IdPersonnel = idpersonnel;
            this.IdMotif = idmotif;
            this.dateDebut = datedebut;
            this.dateFin = datefin;
        }
    }
}
