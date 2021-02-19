using Gladiator.Utils;

namespace Gladiator.Model.Gladiators
{
    public class Assassin : BaseGladiator
    {
        protected override double HpMult => StatisticMultiplier.Easy.Value();
        protected override double SpMult => StatisticMultiplier.High.Value();
        protected override double DexMult => StatisticMultiplier.High.Value();
        public override string FullName => $"{typeof(Assassin)} {Name}";

        public Assassin(string name, int hpBase, int spBase, int dexBase, int lvl) : base(name, hpBase, spBase, dexBase, lvl)
        {
            HpCurrent = HpMax;
        }
    }
}