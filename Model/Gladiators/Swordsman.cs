using Gladiator.Utils;

namespace Gladiator.Model.Gladiators
{
    public class Swordsman : BaseGladiator
    {
        protected override double HpMult => StatisticMultiplier.Medium.Value();
        protected override double SpMult => StatisticMultiplier.Medium.Value();
        protected override double DexMult => StatisticMultiplier.Medium.Value();
        public override string FullName => $"{typeof(Swordsman)} {Name}";

        public Swordsman(string name, int hpBase, int spBase, int dexBase, int lvl) : base(name, hpBase, spBase, dexBase, lvl)
        {
            HpCurrent = HpMax;
        }
    }
}