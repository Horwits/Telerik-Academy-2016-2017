namespace Infestation.Supplements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PowerCatalyst : Supplement, ISupplement
    {
        public const int PowerEffectValue = 3;

        public override int PowerEffect
        {
            get
            {
                return PowerEffectValue;
            }
        }
    }
}