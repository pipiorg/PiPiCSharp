// <copyright file="PiPiCSharpEditAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Wrappers;

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
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adatper instance.</returns>
        internal PiPiCSharpEditAdapter AddField(string fieldName, PiPiCSharpFieldType type, ushort pageIndex, double x, double y, double width, double height)
        {
            try
            {
                ushort cType = PiPiCSharpConstants.FieldTypeMap[type];
                PiPiEditWrapper.PiPiEditorAddField(this.cEditor, fieldName, cType, pageIndex, x, y, width, height);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Flatten all field.
        /// </summary>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter Flatten()
        {
            try
            {
                PiPiEditWrapper.PiPiEditorFlatten(this.cEditor);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            try
            {
                return PiPiEditWrapper.PiPiEditorIsOperable(this.cEditor);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorRemoveField(this.cEditor, fieldName);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName, int pageIndex)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorRemoveField(this.cEditor, fieldName, pageIndex);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Remove field.
        /// </summary>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName, int pageIndex, double x, double y)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorRemoveField(this.cEditor, fieldName, pageIndex, x, y);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
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
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RemoveField(string fieldName, int pageIndex, double x, double y, double width, double height)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorRemoveField(this.cEditor, fieldName, pageIndex, x, y, width, height);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Rename field.
        /// </summary>
        /// <param name="oldFieldName">The old field name.</param>
        /// <param name="newFieldName">The new field name.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter RenameField(string oldFieldName, string newFieldName)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorRenameField(this.cEditor, oldFieldName, newFieldName);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field background color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBackgroundColor(string fieldName, float red, float green, float blue)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorSetFieldBackgroundColor(this.cEditor, fieldName, red, green, blue);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field border color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldBorderColor(string fieldName, float red, float green, float blue)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorSetFieldBorderColor(this.cEditor, fieldName, red, green, blue);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field color.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldColor(string fieldName, float red, float green, float blue)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorSetFieldColor(this.cEditor, fieldName, red, green, blue);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field font name.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="fontName">The font name.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontName(string fieldName, string fontName)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorSetFieldFontName(this.cEditor, fieldName, fontName);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field font size.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="fontSize">The font size.</param>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldFontSize(string fieldName, float fontSize)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorSetFieldFontSize(this.cEditor, fieldName, fontSize);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field multiline.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="multiline">The multiline status.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldMultiline(string fieldName, bool multiline)
        {
            try
            {
                PiPiEditWrapper.PiPiEditorSetFieldMultiline(this.cEditor, fieldName, multiline);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Set field text horizontal alignment.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="alignment">The text horiontal alignment.</param>
        /// <exception cref="PiPiCSharpEditException">Edit exception.</exception>
        /// <returns>The current PDF edit adapter instance.</returns>
        internal PiPiCSharpEditAdapter SetFieldTextHorizontalAlignment(string fieldName, PiPiCSharpTextHorizontalAlignment alignment)
        {
            try
            {
                ushort cAlignment = PiPiCSharpConstants.TextHorizontalAlignmentMap[alignment];
                PiPiEditWrapper.PiPiEditorSetFieldTextHorizontalAlignment(this.cEditor, fieldName, cAlignment);
                return this;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpEditException(PiPiCSharpEditException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
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
                    PiPiEditWrapper.DeletePiPiEditor(this.cEditor);
                }

                this.disposedValue = true;
            }
        }
    }
}
