using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public string AdresseClient { get; set; }
        public string Email { get; set; }

        // Relations
        public ICollection<Configuration> Configurations { get; set; }
    }
}
