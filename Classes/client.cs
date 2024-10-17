using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_Billetterie.Classes.Enum;

namespace Tp_Billetterie.Classes
{
    public class Client
    {
        public string Nom {  get; set; }    

        public string Prenom { get; set; }

        public Adresse Adresse { get; set; }    

        public int Age { get; set; }    

        public string NumeroTel {  get; set; }

        public List<Billet> Billets { get; set; }


        #region constructor
        public Client(string nom, string prenom, Adresse adresse, int age, string numeroTel, List<Billet> billets)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Age = age;
            NumeroTel = numeroTel;
            Billets = billets;
        }

        #endregion


        #region Methode

        public void ReserverBillet(int numeroPlace, Evenement evenement, IEnumPlace typePlace)
        {
            Billet billet = new Billet(numeroPlace, this, evenement, typePlace);
            Billets.Add(billet);
            evenement.ListeBillet.Add(billet);
            Console.WriteLine($"Vous avez acheté un billet : {billet}");
        }

            
        #endregion
    }
}
