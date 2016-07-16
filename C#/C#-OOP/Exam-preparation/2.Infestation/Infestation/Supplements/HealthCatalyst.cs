namespace Infestation.Supplements
{
    public class HealthCatalyst : Supplement, ISupplement
    {
        public const int HealthEffectValue = 3;

        public override int HealthEffect
        {
            get
            {
                return HealthEffectValue;
            }
        }
    }
}