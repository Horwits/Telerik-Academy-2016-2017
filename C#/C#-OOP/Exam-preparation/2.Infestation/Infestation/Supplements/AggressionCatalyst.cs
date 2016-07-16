namespace Infestation.Supplements
{
    public class AggressionCatalyst : Supplement, ISupplement
    {
        public const int AggressionEffectValue = 3;

        public override int AggressionEffect
        {
            get
            {
                return AggressionEffectValue;
            }
        }
    }
}