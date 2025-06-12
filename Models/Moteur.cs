using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Moteur
    {
        public int IdMoteur { get; set; }
        public string NomMoteur { get; set; }
        public bool Thermique { get; set; }
        public bool Hybride { get; set; }
        public bool Electrique { get; set; }

        // Relations (n-n avec Modele)
        public ICollection<ModeleMoteur> ModeleMoteurs { get; set; }
    }
}
