using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_Billetterie.Classes.Enum;

namespace Tp_Billetterie.Classes
{
    public class Billet
    {
        public int NumeroPlace {  get; set; }

        public Client Client {  get; set; }

        public Evenement Evenement {  get; set; }

        public IEnumPlace TypePlace { get; set; }


        #region constructor
        public Billet(int numeroPlace, Client client, Evenement evenement, IEnumPlace typePlace)
        {
            NumeroPlace = numeroPlace;
            Client = client;
            Evenement = evenement;
            TypePlace = typePlace;
        }

        #endregion

        #region Methode
        


        public override string ToString()
        {
            return $"Ce billet appartient à {Client.Nom}, {Client.Prenom} pour l'évènement {Evenement.Nom} qui se déroulera le {Evenement.Date}";
        }
        #endregion
    }
}
