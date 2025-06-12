using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Categorie
    {
        public int IdCategorie { get; set; }
        public string NomCategorie { get; set; }

        // Relations (n-n avec Modele)
        public ICollection<ModeleCategorie> ModeleCategories { get; set; }
    }
}
