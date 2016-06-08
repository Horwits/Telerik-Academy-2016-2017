namespace Euclidian3DSpace
{
    using System;
    using System.Text;

    public struct Point3D
    {
        //The name is different from the name of the property, because the names will be the same. 
        //Static Readonly property names has to start with Uppercase letter. 
        private static readonly Point3D CenterOfCoordinateSystem = new Point3D()
        {
            X = 0,
            Y = 0,
            Z = 0
        };

        public static Point3D StartOfTheCoordinateSystem
        {
            get
            {
                return CenterOfCoordinateSystem;
            }
        }

        public decimal X
        {
            get;
            set;
        }

        public decimal Y
        {
            get;
            set;
        }

        public decimal Z
        {
            get;
            set;
        }

        public override string ToString()
        {
            var printOutput = new StringBuilder();
            printOutput.AppendFormat("X = {0}{1}", this.X, Environment.NewLine);
            printOutput.AppendFormat("Y = {0}{1}", this.Y, Environment.NewLine);
            printOutput.AppendFormat("Z = {0}", this.Z);

            return printOutput.ToString();
        }
    }
}
