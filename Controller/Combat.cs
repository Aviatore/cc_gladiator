using System;
using Gladiator.Model.Gladiators;
using Gladiator.Utils;

namespace Gladiator.Controller
{
    public class Combat
    {
        public static BaseGladiator Simulate(BaseGladiator gladiator1, BaseGladiator gladiator2)
        {
            if (gladiator1 == null && gladiator2 == null)
            {
                return null;
            }

            if (gladiator1 == null || gladiator2 == null)
            {
                return gladiator1 ?? gladiator2;
            }
            
            BaseGladiator attacker = gladiator1;
            BaseGladiator defender = gladiator2;

            bool loop = true;

            while (loop)
            {
                attacker = attacker.Equals(gladiator1) ? gladiator2 : gladiator1;
                defender = defender.Equals(gladiator1) ? gladiator2 : gladiator1;
                
                int hitChance = Math.Clamp((int) (attacker.DexMax - defender.DexMax), 10, 100);

                if (Extentions.Random.Next(1, 101) <= hitChance)
                {
                    double damage = attacker.SpMax * (Extentions.Random.Next(1, 6) / 10f);

                    defender.DecreaseHpBy(damage);
                    //Console.WriteLine($"{attacker.FullName}[{attacker.GetHashCode()}] deals {damage:0.0} damage");

                    if (defender.IsDead)
                    {
                        loop = false;
                        attacker.LevelUp();
                        Console.WriteLine($"{defender.FullName}[{defender.GetHashCode()}] died, {attacker.FullName}[{attacker.GetHashCode()}] wins!");
                    }
                }
                else
                {
                    //Console.WriteLine($"{attacker.FullName}[{attacker.GetHashCode()}] missed!");
                }
            }
            
            return attacker;
        }
    }
}