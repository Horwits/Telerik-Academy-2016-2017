//-----------------------------------------------------------------------
// <copyright file="Size.cs" company="Telerik">
//      Copyright (c) Telerik.
// </copyright>
//-----------------------------------------------------------------------
namespace Homework
{
    using System;

    /// <summary>
    /// Size of a Figure.
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Size" /> class.
        /// </summary>
        /// <param name="width"> Represents the given width. </param>
        /// <param name="height"> Represents the given height. </param>
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the figure.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the figure.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Calculates the rotated size of the figure.
        /// </summary>
        /// <param name="size"> Given size of figure that will be rotated. </param>
        /// <param name="angleOfTheFigureThatWillBeRotated"> The angle of rotation. </param>
        /// <returns> New object of type Size, representing it's new coordinates after the rotation. </returns>
        public static Size GetRotatedSize(
            Size size,
            double angleOfTheFigureThatWillBeRotated)
        {
            var width = Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotated)) * size.Width;
            var height = Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotated)) * size.Height;

            var rotatedSizeWidth = width + height;
            var rotatedSizeHeight = width + height;
            var rotatedSize = new Size(rotatedSizeWidth, rotatedSizeHeight);

            return rotatedSize;
        }
    }
}