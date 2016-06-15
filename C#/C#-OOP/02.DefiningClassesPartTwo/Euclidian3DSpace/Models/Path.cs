namespace Euclidian3DSpace.Models
{
    using System.Collections.Generic;

    public class Path
    {
        private IList<Point3D> sequenceOfPoints;

        public Path()
        {
            this.sequenceOfPoints = new List<Point3D>();
        }

        public IList<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
        }

        public void Add(Point3D point)
        {
            this.sequenceOfPoints.Add(point);
        }
    }   
}
