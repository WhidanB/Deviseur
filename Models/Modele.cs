using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Modele
    {
        public int IdModele { get; set; }
        public string NomModele { get; set; }
        public int PrixModele { get; set; }

        // FK
        public int IdMarque { get; set; }
        public Marque Marque { get; set; }

        // Relations n-n
        public ICollection<ModeleMoteur> ModeleMoteurs { get; set; }
        public ICollection<ModeleCategorie> ModeleCategories { get; set; }
        public ICollection<ModeleColoris> ModeleColoris { get; set; }
        public ICollection<ModeleFinition> ModeleFinitions { get; set; }
        public ICollection<ModeleOption> ModeleOptions { get; set; }

        // Relations Configuration (s’il y a un lien direct)
        public ICollection<Configuration> Configurations { get; set; }
    }

}
