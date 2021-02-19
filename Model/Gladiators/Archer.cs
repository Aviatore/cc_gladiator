using Gladiator.Utils;

namespace Gladiator.Model.Gladiators
{
    public class Archer : BaseGladiator
    {
        protected override double HpMult => StatisticMultiplier.Medium.Value();
        protected override double SpMult => StatisticMultiplier.Medium.Value();
        protected override double DexMult => StatisticMultiplier.High.Value();
        public override string FullName => $"{typeof(Archer)} {Name}";

        public Archer(string name, int hpBase, int spBase, int dexBase, int lvl) : base(name, hpBase, spBase, dexBase, lvl)
        {
        }
    }
}