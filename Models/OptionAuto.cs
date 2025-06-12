using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Deviseur.Models
{
    public class OptionAuto
    {
        public int IdOption { get; set; }
        public string NomOption { get; set; }
        public string PhotoOption { get; set; }
        public int PrixOption { get; set; }

        // Relations (n-n avec Modele)
        public ICollection<ModeleOption> ModeleOptions { get; set; }
    }
}
