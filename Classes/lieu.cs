using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Billetterie.Classes
{
    public class Lieu : Adresse
    {
        public int Capacite { get; set; }


        #region constructor
        public Lieu(int capacite, string rue, string ville ) : base(rue, ville)
        {
            Capacite = capacite;
        }

        #endregion
    }
}
