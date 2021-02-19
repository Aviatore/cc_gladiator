using System.Xml.Linq;
using Gladiator.Utils;

namespace Gladiator.Model.Gladiators
{
    public class GladiatorFactory
    {
        private static string[] _gladiatorNames = new []
        {
            "Secundus Cantius Muco",
            "Nonus Messienus Priscus",
            "Cassius Caesetius Evodius",
            "Caius Septimius Trailus",
            "Lucius Babudius Pompolussa",
            "Aulus Pinarius Luccius",
            "Mamercus Popidius Alypius",
            "Vopiscus Gavius Glabrio",
            "Decimus Pisentius Calatinus",
            "Spurius Atrius Trenico"
        };

        public static BaseGladiator GenerateRandomGladiator()
        {
            int hpBase = Utils.Extentions.Random.Next(25, 101);
            int spBase = Utils.Extentions.Random.Next(25, 101);
            int dexBase = Utils.Extentions.Random.Next(25, 101);
            int lvl = Utils.Extentions.Random.Next(1, 6);
            int randomGladiator = Extentions.Random.Next(0, 125);

            if (randomGladiator <= 50)
                return new Swordsman(_gladiatorNames.Rand(), hpBase, spBase, dexBase, lvl);
            
            if (randomGladiator <= 75)
                return new Archer(_gladiatorNames.Rand(), hpBase, spBase, dexBase, lvl);
                
            if (randomGladiator <= 100)
                return new Brutal(_gladiatorNames.Rand(), hpBase, spBase, dexBase, lvl);
                
            return new Assassin(_gladiatorNames.Rand(), hpBase, spBase, dexBase, lvl);
        }
    }
}