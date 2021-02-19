using Gladiator.Utils;

namespace Gladiator.Model.Gladiators
{
    public class Brutal : BaseGladiator
    {
        protected override double HpMult => StatisticMultiplier.High.Value();
        protected override double SpMult => StatisticMultiplier.High.Value();
        protected override double DexMult => StatisticMultiplier.Easy.Value();
        public override string FullName => $"{typeof(Brutal)} {Name}";

        public Brutal(string name, int hpBase, int spBase, int dexBase, int lvl) : base(name, hpBase, spBase, dexBase, lvl)
        {
        }
    }
}