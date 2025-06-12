using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class ModeleCategorie
    {
        public int IdModele { get; set; }
        public Modele Modele { get; set; }

        public int IdCategorie { get; set; }
        public Categorie Categorie { get; set; }
    }

}
