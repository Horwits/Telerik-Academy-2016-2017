namespace Euclidian3DSpace.Models
{
    using System;
    using System.Text;

    public struct Point3D
    {
        public static readonly Point3D Origin = new Point3D()
        {
            X = 0,
            Y = 0,
            Z = 0
        };

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public double Z
        {
            get;
            set;
        }

        public static Point3D Parse(string currentLine)
        {
            var pointToBeReturned = new Point3D();

            var indexOfComma = currentLine.IndexOf(',');
            if (indexOfComma == -1)
            {
                throw new ArgumentException("The line is in wrong format");
            }

            var splitted = 
                currentLine.Split(
                    new char[] { ',', ' ', '{', '}', '(', ')' },
                    StringSplitOptions.RemoveEmptyEntries);

            var currentX = double.Parse(splitted[0]);
            var currentY = double.Parse(splitted[1]);
            var currentZ = double.Parse(splitted[2]);

            pointToBeReturned.X = currentX;
            pointToBeReturned.Y = currentY;
            pointToBeReturned.Z = currentZ;

            return pointToBeReturned;
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
