namespace Euclidian3DSpace
{
    using System;
    using Euclidian3DSpace.Models;

    using IO = System.IO;

    public static class PathStorage
    {
        public static void SavePathFromTextFile(Path path, string fileToSavePath)
        {
            if (path == null || fileToSavePath == null || fileToSavePath == string.Empty)
            {
                throw new ArgumentNullException("Argument cannot be null or empty.");
            }

            if (!IO.File.Exists(fileToSavePath))
            {
                var newFile = IO.File.Create(fileToSavePath);
            }

            var textWriter = new IO.StreamWriter(fileToSavePath);
            using (textWriter)
            {
                foreach (var point in path.SequenceOfPoints)
                {
                    textWriter.WriteLine(point.ToString());
                }
            }
        }

        public static Path LoadPathFromTextFile(string textPath)
        {
            var pathHolder = new Path();
            var textReader = new IO.StreamReader(textPath);

            using (textReader)
            {
                var currentLine = string.Empty;

                while ((currentLine = textReader.ReadLine()) != null)
                {
                    var currentPoint = Point3D.Parse(currentLine);
                    pathHolder.SequenceOfPoints.Add(currentPoint);
                }
            }

            return pathHolder;
        }
    }
}
