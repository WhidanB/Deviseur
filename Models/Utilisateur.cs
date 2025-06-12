using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Utilisateur
    {
        public int IdUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string Email { get; set; }  
        public bool Admin { get; set; }
        public string PasswordUtilisateur { get; set; }

        // Relations
        public ICollection<Configuration> Configurations { get; set; }
    }

}
