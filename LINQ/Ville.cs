using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    public class Ville
    {
        public string Nom { get; set; }
        public string CodePostal { get; set; }
        public string Departement
        { get { return this.CodePostal.Substring(0, 2); } // on ne prend que les 2 premiers chiffres du Code Postal
        }
    }
}
