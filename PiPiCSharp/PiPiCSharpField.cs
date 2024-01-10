// <copyright file="PiPiCSharpField.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    /// <summary>
    /// The field model object.
    /// </summary>
    public class PiPiCSharpField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpField"/> class.
        /// </summary>
        /// <param name="name">The field name.</param>
        /// <param name="type">The field type.</param>
        /// <param name="pageIndex">The field page index.</param>
        /// <param name="x">The field located x.</param>
        /// <param name="y">The field located y.</param>
        /// <param name="width">The field width.</param>
        /// <param name="height">The field height.</param>
        /// <param name="fontName">The field font name.</param>
        /// <param name="fontSize">The field font size.</param>
        public PiPiCSharpField(string name, PiPiCSharpFieldType type, ushort pageIndex, double x, double y, double width, double height, string fontName, float fontSize)
        {
            this.Name = name;
            this.Type = type;
            this.PageIndex = pageIndex;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.FontName = fontName;
            this.FontSize = fontSize;
        }

        /// <summary>
        /// Gets or sets the field font name.
        /// </summary>
        public string FontName { get; set; }

        /// <summary>
        /// Gets or sets the field font size.
        /// </summary>
        public float FontSize { get; set; }

        /// <summary>
        /// Gets or sets the field height.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the field name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the field page index.
        /// </summary>
        public ushort PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the field type.
        /// </summary>
        public PiPiCSharpFieldType Type { get; set; }

        /// <summary>
        /// Gets or sets the field Width.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets the field located x.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the field located y.
        /// </summary>
        public double Y { get; set; }
    }
}
