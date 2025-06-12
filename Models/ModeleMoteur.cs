using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class ModeleMoteur
    {
        public int IdModele { get; set; }
        public Modele Modele { get; set; }

        public int IdMoteur { get; set; }
        public Moteur Moteur { get; set; }
    }
}
