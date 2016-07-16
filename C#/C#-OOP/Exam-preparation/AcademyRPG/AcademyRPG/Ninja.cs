namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ninja : FightingCharacter, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner) 
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            //this.IsDestroyed = false;
        }

        public override int AttackPoints
        {
            get
            {
                return 0;
            }
        }

        public override int DefensePoints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone || resource.Type == ResourceType.Lumber)
            {
                
            }

            return false;
        }
    }
}