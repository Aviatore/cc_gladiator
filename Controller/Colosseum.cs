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
            if ((gladiatorCount / (gladiatorCount / 2)) % 2 == 1)
            {
                throw new ArgumentException("Wrong number of contestants");
            }

            for (int i = 0; i < gladiatorCount; i++)
            {
                _gladiators.Add(GladiatorFactory.GenerateRandomGladiator());
            }
        }

        public Tournament SplitGladiatorsIntoPairs()
        {
            _tournament.AddAll(_gladiators);
            return _tournament;
        }

        public BaseGladiator SimulateCombat(Tournament tournament)
        {
            if (tournament.LeftNode != null && tournament.LeftNode.Value == null)
            {
                return Combat.Simulate(SimulateCombat(tournament.LeftNode), SimulateCombat(tournament.RightNode));
            }
            
            if (tournament.LeftNode?.Value != null)
            {
                return Combat.Simulate(tournament.LeftNode.Value, tournament.RightNode.Value);
            }
            
            return Combat.Simulate(tournament.Value, null);
        }
        
        public BaseGladiator _SimulateCombat(Tournament tournament)
        {
            if (tournament.LeftNode != null && tournament.LeftNode.Value == null)
            {
                return Combat.Simulate(SimulateCombat(tournament.LeftNode), SimulateCombat(tournament.RightNode));
            }
            
            if (tournament.LeftNode?.Value != null)
            {
                return Combat.Simulate(tournament.LeftNode.Value, tournament.RightNode.Value);
            }
            
            return Combat.Simulate(tournament.Value, null);
        }
    }
}