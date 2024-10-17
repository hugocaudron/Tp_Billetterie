using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Billetterie.Classes
{
    public class Adresse
    {
        public string Rue {  get; set; }

        public string Ville { get; set; }


        #region constructor
        public Adresse (string rue, string ville)
        {
            Rue = rue;
            Ville = ville;
        }

        #endregion

    }
}
