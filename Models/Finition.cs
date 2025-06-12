using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Finition
    {
        public int IdFinition { get; set; }
        public string NomFinition { get; set; }
        public string PhotoFinition { get; set; }
        public int PrixFinition { get; set; }

        // Relations (n-n avec Modele)
        public ICollection<ModeleFinition> ModeleFinitions { get; set; }
    }
}
