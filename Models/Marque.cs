using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Marque
    {
        public int IdMarque { get; set; }
        public string NomMarque { get; set; }
        public string LogoMarque { get; set; }

        // Relations
        public ICollection<Modele> Modeles { get; set; }
    }
}
