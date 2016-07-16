namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Giant : FightingCharacter, IFighter, IGatherer
    {
        private bool isGathered;
        private int attackPoints;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.isGathered = false;
            this.attackPoints = 150;
            this.HitPoints = 200;
        }

        public override int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
        }

        public override int DefensePoints
        {
            get
            {
                return 80;
            }
        }

        public override int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource is Stone != true)
            {
                this.attackPoints += 100;
                this.isGathered = true;
                return true;
            }

            this.isGathered = false;
            return false;
        }
    }
}