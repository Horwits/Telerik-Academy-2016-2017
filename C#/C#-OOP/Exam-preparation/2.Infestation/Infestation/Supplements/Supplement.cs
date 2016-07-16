namespace Infestation.Supplements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Supplement : ISupplement
    {
        public const int MinHealthEffectValue = 0;
        public const int MinAggressionEffectValue = 0;
        public const int MinPowerEffectValue = 0;

        public virtual int AggressionEffect
        {
            get
            {
               return MinAggressionEffectValue;
            }
        }

        public virtual int HealthEffect
        {
            get
            {
                return MinHealthEffectValue;
            }
        }

        public virtual int PowerEffect
        {
            get
            {
                return MinPowerEffectValue;
            }
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            //throw new NotImplementedException();
        }
    }
}