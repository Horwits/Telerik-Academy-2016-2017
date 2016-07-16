namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Knight : FightingCharacter, IControllable, IFighter
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 100;
        }

        public override int AttackPoints
        {
            get
            {
                return 100; // TODO: Extract constants if had time.
            }
        }

        public override int DefensePoints
        {
            get
            {
                return 100;
            }
        }
    }
}