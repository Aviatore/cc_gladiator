using System;
using System.Collections.Generic;
using Gladiator.Model.Gladiators;

namespace Gladiator.Controller
{
    public class Colosseum
    {
        private Tournament _tournament;
        private List<BaseGladiator> _gladiators = new List<BaseGladiator>();

        public Colosseum()
        {
            _tournament = new Tournament();
        }
        
        public void GenerateGladiators(int gladiatorCount)
        {
            var div = (gladiatorCount / 2.0f);
            if (div % 2 != 0 || (gladiatorCount / (div)) % 2 != 0)
            {
                throw new ArgumentException("Wrong number of contestants");
            }

            for (int i = 0; i < gladiatorCount; i++)
            {
                BaseGladiator gladiator = GladiatorFactory.GenerateRandomGladiator();
                Console.WriteLine($"G {gladiator.FullName}[{gladiator.GetHashCode().ToString()}] hp: {gladiator.GetHpBase()} {gladiator.GetLevel()} {gladiator.GetHpMult()} {gladiator.GetHpMax()} {gladiator.HpCurrent}");
                _gladiators.Add(gladiator);
            }
        }

        public Tournament SplitGladiatorsIntoPairs()
        {
            _tournament.AddAll(_gladiators);
            return _tournament;
        }

        public BaseGladiator SimulateCombat(Tournament tournament, int lvl)
        {
            if (tournament.LeftNode.Value == null)
            {
                BaseGladiator gladiator1 = SimulateCombat(tournament.LeftNode, lvl + 1);
                BaseGladiator gladiator2 = SimulateCombat(tournament.RightNode, lvl + 1);
                Console.WriteLine($"ALvl {lvl.ToString()} {gladiator1.GetHashCode()} vs. {gladiator2.GetHashCode()}");
                return Combat.Simulate(gladiator1, gladiator2);
            }
            
            Console.WriteLine($"BLvl {lvl.ToString()} {tournament.LeftNode.Value.GetHashCode()} vs. {tournament.RightNode.Value.GetHashCode()}");
            return Combat.Simulate(tournament.LeftNode.Value, tournament.RightNode.Value);
        }
    }
}