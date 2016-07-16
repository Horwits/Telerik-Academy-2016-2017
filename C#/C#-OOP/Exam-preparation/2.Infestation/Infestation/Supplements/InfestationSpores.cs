namespace Infestation.Supplements
{
    public class InfestationSpores : Supplement, ISupplement
    {
        private const int PowerEffectValue = -1;
        private const int AggressionEffectValue = 20;

        private int powerEffect = InfestationSpores.PowerEffectValue;
        private int aggressionEffect = InfestationSpores.AggressionEffectValue;

        // TODO: give all the values in a constructor

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
            if (otherSupplement is InfestationSpores)
            {
                this.aggressionEffect = MinAggressionEffectValue;
                this.powerEffect = MinPowerEffectValue;
            }
        }
    }
}