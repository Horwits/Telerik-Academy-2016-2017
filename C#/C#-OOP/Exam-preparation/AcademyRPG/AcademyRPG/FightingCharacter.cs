namespace AcademyRPG
{
    using System.Collections.Generic;

    public abstract class FightingCharacter : Character, IFighter
    {
        protected FightingCharacter(string name, Point position, int owner)
            : base(name, position, owner)
        {
        }

        public abstract int AttackPoints { get; }

        public abstract int DefensePoints { get; }

        public virtual int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}