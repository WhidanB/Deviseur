using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Coloris
    {
        public int IdColoris { get; set; }
        public string NomCouleur { get; set; }
        public string CodeCouleur { get; set; }
        public int PrixCouleur { get; set; }

        // Relations (n-n avec Modele)
        public ICollection<ModeleColoris> ModeleColoris { get; set; }
    }
}
