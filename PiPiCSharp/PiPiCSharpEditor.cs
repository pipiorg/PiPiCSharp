// <copyright file="PiPiCSharpEditor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// The PDF editor.
    /// </summary>
    public class PiPiCSharpEditor : IDisposable
    {
        private readonly PiPiCSharpEditAdapter adapter;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditor"/> class.
        /// </summary>
        /// <param name="adapter">The edit adapter.</param>
        internal PiPiCSharpEditor(PiPiCSharpEditAdapter adapter)
        {
            this.adapter = adapter;
        }

        /// <summary>
        /// Add field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="type">The added field type.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <param name="width">The added field width.</param>
        /// <param name="height">The added field height.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor AddField(string fieldName, PiPiCSharpFieldType type, ushort pageIndex, double x, double y, double width, double height)
        {
            this.adapter.AddField(fieldName, type, pageIndex, x, y, width, height);
            return this;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Invoke inner dispose.
        /// </summary>
        /// <param name="disposing">The dispose status.</param>
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.adapter.Dispose();
                }

                this.disposedValue = true;
            }
        }

        /// <summary>
        /// Flatten all field.
        /// </summary>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor Flatten()
        {
            this.adapter.Flatten();
            return this;
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <returns>The operable status.</returns>
        public bool IsOperable()
        {
            return this.adapter.IsOperable();
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <param name="width">The added field width.</param>
        /// <param name="height">The added field height.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor RemoveField(string fieldName, int pageIndex, double x, double y, double width, double height)
        {
            this.adapter.RemoveField(fieldName, pageIndex, x, y, width, height);
            return this;
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor RemoveField(string fieldName, int pageIndex)
        {
            this.adapter.RemoveField(fieldName, pageIndex);
            return this;
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor RemoveField(string fieldName, int pageIndex, double x, double y)
        {
            this.adapter.RemoveField(fieldName, pageIndex, x, y);
            return this;
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor RemoveField(string fieldName)
        {
            this.adapter.RemoveField(fieldName);
            return this;
        }

        /// <summary>
        /// Rename field.
        /// </summary>
        /// <param name="oldFieldName">The old field name.</param>
        /// <param name="newFieldName">The new field name.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor RenameField(string oldFieldName, string newFieldName)
        {
            this.adapter.RenameField(oldFieldName, newFieldName);
            return this;
        }

        /// <summary>
        /// Set field background color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldBackgroundColor(string fieldName, float red, float green, float blue)
        {
            this.adapter.SetFieldBackgroundColor(fieldName, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field border color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldBorderColor(string fieldName, float red, float green, float blue)
        {
            this.adapter.SetFieldBorderColor(fieldName, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldColor(string fieldName, float red, float green, float blue)
        {
            this.adapter.SetFieldColor(fieldName, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field font name.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="fontName">The font name.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldFontName(string fieldName, string fontName)
        {
            this.SetFieldFontName(fieldName, fontName);
            return this;
        }

        /// <summary>
        /// Set field font size.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldFontSize(string fieldName, float fontSize)
        {
            this.SetFieldFontSize(fieldName, fontSize);
            return this;
        }

        /// <summary>
        /// Set field multiline.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="multiline">The multiline status.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldMultiline(string fieldName, bool multiline)
        {
            this.SetFieldMultiline(fieldName, multiline);
            return this;
        }

        /// <summary>
        /// Set field text horizontal alignment.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="alignment">The text horiontal alignment.</param>
        /// <returns>The current PDF edit instance.</returns>
        public PiPiCSharpEditor SetFieldTextHorizontalAlignment(string fieldName, PiPiCSharpTextHorizontalAlignment alignment)
        {
            this.SetFieldTextHorizontalAlignment(fieldName, alignment);
            return this;
        }
    }
}
