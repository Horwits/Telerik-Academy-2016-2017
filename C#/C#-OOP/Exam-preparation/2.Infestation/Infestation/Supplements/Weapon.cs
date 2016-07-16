namespace Infestation.Supplements
{
    public class Weapon : Supplement, ISupplement
    {
        private const int MaxPowerEffectValue = 10;
        private const int MaxAggressionEffectValue = 3;

        private int powerEffect = Weapon.MaxPowerEffectValue;
        private int aggressionEffect = Weapon.MaxAggressionEffectValue;

        public override int PowerEffect
        {
            get
            {
                return this.powerEffect;
            }
        }

        public override int AggressionEffect
        {
            get
            {
                return this.aggressionEffect;
            }
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (!(otherSupplement is WeaponrySkill))
            {
                this.aggressionEffect = MinAggressionEffectValue;
                this.powerEffect = MinPowerEffectValue;
            }
        }
    }
}