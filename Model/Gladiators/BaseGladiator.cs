namespace Gladiator.Model.Gladiators
{
    public enum StatisticMultiplier : byte
    {
        Easy,
        Medium,
        High
    }
    public abstract class BaseGladiator
    {
        public string Name { get; }
        protected int Level { get; set; }
        public double HpCurrent { get; protected set; }
        public double SpCurrent { get; protected set; }
        public double DexCurrent { get; protected set; }
        protected int HpBase { get; set; }
        protected int SpBase { get; set; }
        protected int DexBase { get; set; }
        public double HpMax => HpBase * HpMult * Level;
        public double SpMax => SpBase * SpMult * Level;
        public double DexMax => DexBase * DexMult * Level;
        protected abstract double HpMult { get; }
        protected abstract double SpMult { get; }
        protected abstract double DexMult { get; }
        public abstract string FullName { get; }

        public void LevelUp()
        {
            Level++;
        }

        public BaseGladiator(string name, int hpBase, int spBase, int dexBase, int lvl)
        {
            Name = name;
            HpBase = hpBase;
            SpBase = spBase;
            DexBase = dexBase;
            Level = lvl;
        }

        public void DecreaseHpBy(double hp)
        {
            HpCurrent = (HpCurrent - hp) >= 0 ? HpCurrent - hp : 0;
        }

        public bool IsDead => HpCurrent == 0;

        public void HealUp()
        {
            HpCurrent = HpMax;
        }
    }
}