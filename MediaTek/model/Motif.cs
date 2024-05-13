using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek.model
{
    public class Motif
    {
        public int idMotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Constructeur du Motif
        /// </summary>
        /// <param name="idmotif">id du motif</param>
        /// <param name="libelle">libellé du motif</param>
        public Motif(int idmotif, string libelle)
        {
            this.idMotif = idmotif;
            this.Libelle = libelle; 
        }

        /// <summary>
        /// Définit l'information à afficher
        /// </summary>
        /// <returns>libellé du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
