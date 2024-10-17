using Tp_Billetterie.Classes;
using Tp_Billetterie.Classes.Enum;

Lieu lieu = new Lieu(500, "ruee", "vilee");
DateTime eventDate = new DateTime(2024, 10, 17);
Evenement partybeach = new Evenement("plage", lieu, eventDate, 12, 400, new());
Evenement partybeer = new Evenement("biere", lieu, eventDate, 12, 400, new());

Adresse adresse = new Adresse("70b rue dl'hesdin", "Blangy sur ternoise");
Client noa = new Client("Gosselin", "Noa", adresse, 18, "0647238164", new());
Client hugo = new Client("caudron", "hugo", adresse, 19, "0647238164", new());
Client paul = new Client("mérandon", "paul", adresse, 24, "0647238164", new());
Client titouan = new Client("laude", "titouan", adresse, 19, "0647238164", new());


noa.ReserverBillet(1, partybeer, IEnumPlace.gold);
hugo.ReserverBillet(2, partybeer, IEnumPlace.gold);
paul.ReserverBillet(3, partybeach, IEnumPlace.Stadar);
titouan.ReserverBillet(4, partybeach, IEnumPlace.gold);


partybeach.RecupererBillets();
partybeer.RecupererBillets();


IHM ihm = new IHM();
ihm.InterfaceIHM();