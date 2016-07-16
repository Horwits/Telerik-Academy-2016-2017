namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Stone : StaticObject, IResource
    {
        public Stone(Point position, int owner = 0) 
            : base(position, owner)
        {
        }

        public int Quantity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ResourceType Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}