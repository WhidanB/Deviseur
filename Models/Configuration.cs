using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Configuration
    {
        public int IdConfiguration { get; set; }
        public string NomConfiguration { get; set; }
        public DateTime DateConfiguration { get; set; }
        public int MontantConfiguration { get; set; }

        // FK
        public int IdClient { get; set; }
        public Client Client { get; set; }
        public int IdUtilisateur { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int IdModele { get; set; }
        public Modele Modele { get; set; }

        // Relations Devis
        public ICollection<Devis> Devis { get; set; }
    }

}
