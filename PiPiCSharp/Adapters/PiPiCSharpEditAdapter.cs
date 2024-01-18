// <copyright file="PiPiCSharpEditAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Invokers;

    /// <summary>
    /// PDF edit adapter.
    /// </summary>
    internal class PiPiCSharpEditAdapter : IDisposable
    {
        private readonly IntPtr cEditor;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditAdapter"/> class.
        /// </summary>
        /// <param name="cEditor">The PiPiEditor instance pointer.</param>
        internal PiPiCSharpEditAdapter(IntPtr cEditor)
        {
            this.cEditor = cEditor;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
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
        /// <exception cref="PiPiCSharpEditFieldException">Edit exception.</exception>
        /// <returns>The current PDF edit adatper instance.</returns>
        internal PiPiCSharpEditAdapter AddField(string fieldName, PiPiCSharpFieldType type, int pageIndex, double x, double y, double width, double height)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);
            uint cType = PiPiCSharpConstants.FieldTypeMap[type];

            PiPiCSharpEditInvoker.InvokePiPiEditorAddField(this.cEditor, fieldName, cType, uPageIndex, x, y, width, height);

            return this;
        }

        /// <summary>
        /// Flatten all field.
        /// </summary>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter Flatten()
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorFlatten(this.cEditor);
            return this;
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            return PiPiCSharpEditInvoker.InvokePiPiEditorIsOperable(this.cEditor);
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorRemoveField(this.cEditor, fieldName);
            return this;
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName, int pageIndex)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorRemoveField(this.cEditor, fieldName, uPageIndex);
            return this;
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName, int pageIndex, double x, double y)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorRemoveField(this.cEditor, fieldName, uPageIndex, x, y);
            return this;
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
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName, int pageIndex, double x, double y, double width, double height)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorRemoveField(this.cEditor, fieldName, uPageIndex, x, y, width, height);
            return this;
        }

        /// <summary>
        /// Rename field.
        /// </summary>
        /// <param name="oldFieldName">The old field name.</param>
        /// <param name="newFieldName">The new field name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RenameField(string oldFieldName, string newFieldName)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorRenameField(this.cEditor, oldFieldName, newFieldName);
            return this;
        }

        /// <summary>
        /// Set field background color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBackgroundColor(string fieldName, float red, float green, float blue)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBackgroundColor(this.cEditor, fieldName, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field background color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBackgroundColor(string fieldName, int pageIndex, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBackgroundColor(this.cEditor, fieldName, uPageIndex, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field background color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBackgroundColor(string fieldName, int pageIndex, double x, double y, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBackgroundColor(this.cEditor, fieldName, uPageIndex, x, y, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field background color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBackgroundColor(string fieldName, int pageIndex, double x, double y, double width, double height, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBackgroundColor(this.cEditor, fieldName, uPageIndex, x, y, width, height, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field border color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderColor(string fieldName, float red, float green, float blue)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderColor(this.cEditor, fieldName, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field border color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderColor(string fieldName, int pageIndex, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderColor(this.cEditor, fieldName, uPageIndex, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field border color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderColor(string fieldName, int pageIndex, double x, double y, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderColor(this.cEditor, fieldName, uPageIndex, x, y, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field border color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderColor(string fieldName, int pageIndex, double x, double y, double width, double height, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderColor(this.cEditor, fieldName, uPageIndex, x, y, width, height, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field border width.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="borderWidth">The border width.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderWidth(string fieldName, int pageIndex, double x, double y, double width, double height, double borderWidth)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderWidth(this.cEditor, fieldName, uPageIndex, x, y, width, height, borderWidth);
            return this;
        }

        /// <summary>
        /// Set field border width.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="borderWidth">The border width.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderWidth(string fieldName, int pageIndex, double x, double y, double borderWidth)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderWidth(this.cEditor, fieldName, uPageIndex, x, y, borderWidth);
            return this;
        }

        /// <summary>
        /// Set field border width.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="borderWidth">The border width.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderWidth(string fieldName, int pageIndex, double borderWidth)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderWidth(this.cEditor, fieldName, uPageIndex, borderWidth);
            return this;
        }

        /// <summary>
        /// Set field border width.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="borderWidth">The border width.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderWidth(string fieldName, double borderWidth)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldBorderWidth(this.cEditor, fieldName, borderWidth);
            return this;
        }

        /// <summary>
        /// Set field color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldColor(string fieldName, int pageIndex, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldColor(this.cEditor, fieldName, uPageIndex, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldColor(string fieldName, int pageIndex, double x, double y, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldColor(this.cEditor, fieldName, uPageIndex, x, y, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldColor(string fieldName, int pageIndex, double x, double y, double width, double height, float red, float green, float blue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldColor(this.cEditor, fieldName, uPageIndex, x, y, width, height, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldColor(string fieldName, float red, float green, float blue)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldColor(this.cEditor, fieldName, red, green, blue);
            return this;
        }

        /// <summary>
        /// Set field default value.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldDefaultValue(string fieldName, string defaultValue)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldDefaultValue(this.cEditor, fieldName, defaultValue);
            return this;
        }

        /// <summary>
        /// Set field default value.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldDefaultValue(string fieldName, int pageIndex, string defaultValue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldDefaultValue(this.cEditor, fieldName, uPageIndex, defaultValue);
            return this;
        }

        /// <summary>
        /// Set field default value.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldDefaultValue(string fieldName, int pageIndex, double x, double y, string defaultValue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldDefaultValue(this.cEditor, fieldName, uPageIndex, x, y, defaultValue);
            return this;
        }

        /// <summary>
        /// Set field default value.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldDefaultValue(string fieldName, int pageIndex, double x, double y, double width, double height, string defaultValue)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldDefaultValue(this.cEditor, fieldName, uPageIndex, x, y, width, height, defaultValue);
            return this;
        }

        /// <summary>
        /// Set field font name.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="fontName">The font name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontName(string fieldName, string fontName)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontName(this.cEditor, fieldName, fontName);
            return this;
        }

        /// <summary>
        /// Set field font name.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="fontName">The font name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontName(string fieldName, int pageIndex, string fontName)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontName(this.cEditor, fieldName, uPageIndex, fontName);
            return this;
        }

        /// <summary>
        /// Set field font name.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="fontName">The font name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontName(string fieldName, int pageIndex, double x, double y, string fontName)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontName(this.cEditor, fieldName, uPageIndex, x, y, fontName);
            return this;
        }

        /// <summary>
        /// Set field font name.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fontName">The font name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontName(string fieldName, int pageIndex, double x, double y, double width, double height, string fontName)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontName(this.cEditor, fieldName, uPageIndex, x, y, width, height, fontName);
            return this;
        }

        /// <summary>
        /// Set field font size.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontSize(string fieldName, int pageIndex, double x, double y, double width, double height, float fontSize)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontSize(this.cEditor, fieldName, uPageIndex, x, y, width, height, fontSize);
            return this;
        }

        /// <summary>
        /// Set field font size.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontSize(string fieldName, int pageIndex, float fontSize)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontSize(this.cEditor, fieldName, uPageIndex, fontSize);
            return this;
        }

        /// <summary>
        /// Set field font size.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontSize(string fieldName, int pageIndex, double x, double y, float fontSize)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontSize(this.cEditor, fieldName, uPageIndex, x, y, fontSize);
            return this;
        }

        /// <summary>
        /// Set field font size.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontSize(string fieldName, float fontSize)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldFontSize(this.cEditor, fieldName, fontSize);
            return this;
        }

        /// <summary>
        /// Set field multiline.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="multiline">The multiline status.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldMultiline(string fieldName, bool multiline)
        {
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldMultiline(this.cEditor, fieldName, multiline);
            return this;
        }

        /// <summary>
        /// Set field multiline.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="multiline">The multiline status.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldMultiline(string fieldName, int pageIndex, bool multiline)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldMultiline(this.cEditor, fieldName, uPageIndex, multiline);
            return this;
        }

        /// <summary>
        /// Set field multiline.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="multiline">The multiline status.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldMultiline(string fieldName, int pageIndex, double x, double y, bool multiline)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldMultiline(this.cEditor, fieldName, uPageIndex, x, y, multiline);
            return this;
        }

        /// <summary>
        /// Set field multiline.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="multiline">The multiline status.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldMultiline(string fieldName, int pageIndex, double x, double y, double width, double height, bool multiline)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldMultiline(this.cEditor, fieldName, uPageIndex, x, y, width, height, multiline);
            return this;
        }

        /// <summary>
        /// Set field text horizontal alignment.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="alignment">The text horiontal alignment.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldTextHorizontalAlignment(string fieldName, PiPiCSharpTextHorizontalAlignment alignment)
        {
            uint cAlignment = PiPiCSharpConstants.TextHorizontalAlignmentMap[alignment];
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldTextHorizontalAlignment(this.cEditor, fieldName, cAlignment);
            return this;
        }

        /// <summary>
        /// Set field text horizontal alignment.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="alignment">The text horiontal alignment.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldTextHorizontalAlignment(string fieldName, int pageIndex, PiPiCSharpTextHorizontalAlignment alignment)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            uint cAlignment = PiPiCSharpConstants.TextHorizontalAlignmentMap[alignment];
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldTextHorizontalAlignment(this.cEditor, fieldName, uPageIndex, cAlignment);
            return this;
        }

        /// <summary>
        /// Set field text horizontal alignment.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="alignment">The text horiontal alignment.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldTextHorizontalAlignment(string fieldName, int pageIndex, double x, double y, PiPiCSharpTextHorizontalAlignment alignment)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            uint cAlignment = PiPiCSharpConstants.TextHorizontalAlignmentMap[alignment];
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldTextHorizontalAlignment(this.cEditor, fieldName, uPageIndex, x, y, cAlignment);
            return this;
        }

        /// <summary>
        /// Set field text horizontal alignment.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="alignment">The text horiontal alignment.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldTextHorizontalAlignment(string fieldName, int pageIndex, double x, double y, double width, double height, PiPiCSharpTextHorizontalAlignment alignment)
        {
            if (pageIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uPageIndex = Convert.ToUInt32(pageIndex);

            uint cAlignment = PiPiCSharpConstants.TextHorizontalAlignmentMap[alignment];
            PiPiCSharpEditInvoker.InvokePiPiEditorSetFieldTextHorizontalAlignment(this.cEditor, fieldName, uPageIndex, x, y, width, height, cAlignment);
            return this;
        }

        /// <summary>
        /// Invoke inner dispose.
        /// </summary>
        /// <param name="disposing">The dispose status.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    PiPiCSharpEditInvoker.InvokeDeletePiPiEditor(this.cEditor);
                }

                this.disposedValue = true;
            }
        }
    }
}
