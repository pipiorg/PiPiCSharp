// <copyright file="PiPiCSharpPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    /// <summary>
    /// The page model object.
    /// </summary>
    public class PiPiCSharpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpPage"/> class.
        /// </summary>
        /// <param name="width">The width of the page.</param>
        /// <param name="height">The height of the page.</param>
        public PiPiCSharpPage(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets the height of the page.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets the width of the page.
        /// </summary>
        public double Width { get; set; }
    }
}
