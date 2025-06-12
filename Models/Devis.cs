using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class Devis
    {
        public int IdDevis { get; set; }
        public DateTime DateDevis { get; set; }
        public int MontantDevis { get; set; }

        // FK
        public int IdConfiguration { get; set; }
        public Configuration Configuration { get; set; }
    }

}
