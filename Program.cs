using System;
using Microsoft.VisualBasic;
using Gladiator;
using Gladiator.Controller;
using Gladiator.Model.Gladiators;

namespace Gladiator
{
    public static class Program
    {
        public static void Main()
        {
            // Start the program here
            Colosseum colosseum = new Colosseum();
            colosseum.GenerateGladiators(32);
            BaseGladiator winner = colosseum.SimulateCombat(colosseum.SplitGladiatorsIntoPairs(), 0);
            Console.WriteLine($"Winner: {winner.FullName}[{winner.GetHashCode()}] lvl: {winner.GetLevel()}");
        }
    }
}