using System;
using System.Collections.Generic;
using Gladiator.Model.Gladiators;

namespace Gladiator.Controller
{
    public class Tournament
    {
        public Tournament LeftNode;
        public Tournament RightNode;
        public BaseGladiator Value;
        private bool _left = true;

        public Tournament()
        {
            
        }
        public void Add(BaseGladiator gladiator)
        {
            if (Value == null)
            {
                if (LeftNode == null)
                {
                    Value = gladiator;
                    // Console.WriteLine($"T {gladiator.FullName} {gladiator.GetHashCode().ToString()}");
                }
                else
                {
                    if (_left)
                    {
                        LeftNode.Add(gladiator);
                    }
                    else
                    {
                        RightNode.Add(gladiator);
                    }

                    _left ^= true;
                }
            }
            else
            {
                LeftNode = new Tournament();
                LeftNode.Add(Value);
                Value = null;
                
                RightNode = new Tournament();
                RightNode.Add(gladiator);
            }
        }

        public void AddAll(IEnumerable<BaseGladiator> gladiators)
        {
            foreach (var gladiator in gladiators)
            {
                Add(gladiator);
            }
        }
    }
}