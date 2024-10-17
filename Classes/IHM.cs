using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Billetterie.Classes
{
    public class IHM
    {
        

        public void InterfaceIHM()
        {
            Console.Clear();
            Console.WriteLine($"=== Que voulais vous faire ? === \n" +
                $"1 -- Client \n" +
                $"2 -- Evenement \n" +
                $"3 -- Billet \n" +
                $"4 -- Quitter \n");
            Console.Write("Entrez votre choix :");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "4":
                    Environment.Exit(0);
                    break;
            }
                

        }
    }
}
