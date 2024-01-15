// <copyright file="PiPiCSharpField.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System.Drawing;

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
        /// <param name="defaultValue">The default value.</param>
        /// <param name="textHorizontalAlignment">The text horizontal alignment.</param>
        /// <param name="multiline">The multiline.</param>
        /// <param name="fontName">The field font name.</param>
        /// <param name="fontSize">The field font size.</param>
        /// <param name="color">The field text color.</param>
        /// <param name="borderColor">The field border color.</param>
        /// <param name="borderWidth">The field border width.</param>
        /// <param name="backgroundColor">The field background color.</param>
        public PiPiCSharpField(
            string name,
            PiPiCSharpFieldType type,
            int pageIndex,
            double x,
            double y,
            double width,
            double height,
            string defaultValue,
            PiPiCSharpTextHorizontalAlignment textHorizontalAlignment,
            bool multiline,
            string fontName,
            float fontSize,
            Color color,
            Color backgroundColor,
            double borderWidth,
            Color borderColor)
        {
            this.Name = name;
            this.Type = type;
            this.PageIndex = pageIndex;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.DefaultValue = defaultValue;
            this.TextHorizontalAlignment = textHorizontalAlignment;
            this.Multiline = multiline;
            this.FontName = fontName;
            this.FontSize = fontSize;
            this.Color = color;
            this.BackgroundColor = backgroundColor;
            this.BorderWidth = borderWidth;
            this.BorderColor = borderColor;
        }

        /// <summary>
        /// Gets or sets the field background color.
        /// </summary>
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the field border color.
        /// </summary>
        public Color BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the field border width.
        /// </summary>
        public double BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the field text color.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the field default value.
        /// </summary>
        public string DefaultValue { get; set; }

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
        /// Gets or sets a value indicating whether the field multiline.
        /// </summary>
        public bool Multiline { get; set; }

        /// <summary>
        /// Gets or sets the field name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the field page index.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the field text horizontal alignment.
        /// </summary>
        public PiPiCSharpTextHorizontalAlignment TextHorizontalAlignment { get; set; }

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
