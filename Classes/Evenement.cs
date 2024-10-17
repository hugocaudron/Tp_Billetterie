using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Billetterie.Classes
{
    public class Evenement
    {
        public string Nom {  get; set; }

        public Lieu Lieu { get; set; }

        public DateTime Date { get; set; }

        public int Heure { get; set; }  

        public int NombrePlace { get; set; }

        public List<Billet> ListeBillet { get; set; }

        #region constructor
        public Evenement(string nom, Lieu lieu, DateTime date, int heure, int nombrePlace, List<Billet> listeBillet)
        {
            Nom = nom;
            Lieu = lieu;
            Date = date;
            Heure = heure;
            NombrePlace = nombrePlace;
            ListeBillet = listeBillet;
        }

        #endregion

        #region Methode

        public void RecupererBillets()
        {
          foreach(Billet billet in ListeBillet)
            {
                Console.WriteLine($"Billet : {billet}");
            }
        }


        #endregion
    }
}
