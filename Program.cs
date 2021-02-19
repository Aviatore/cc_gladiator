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
            colosseum.GenerateGladiators(4);
            BaseGladiator winner = colosseum.SimulateCombat(colosseum.SplitGladiatorsIntoPairs());
            Console.WriteLine($"Winner: {winner.FullName}");
        }
    }
}