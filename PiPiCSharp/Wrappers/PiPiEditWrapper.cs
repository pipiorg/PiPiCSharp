// <copyright file="PiPiEditWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiEditor.
    /// </summary>
    internal static class PiPiEditWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiEditor destructor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiEditor")]
        internal static extern void DeletePiPiEditor(IntPtr cEditor);

        /// <summary>
        /// Invoke c++ PiPiEditor AddField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="type">The added field type.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <param name="width">The added field width.</param>
        /// <param name="height">The added field height.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorAddField")]
        internal static extern void PiPiEditorAddField(IntPtr cEditor, string fieldName, ushort type, ushort pageIndex, double x, double y, double width, double height);

        /// <summary>
        /// Invoke c++ PiPiEditor Flatten.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorFlatten")]
        internal static extern void PiPiEditorFlatten(IntPtr cEditor);

        /// <summary>
        /// Invoke c++ PiPiEditor IsOperable.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <returns>Operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorIsOperable")]
        internal static extern bool PiPiEditorIsOperable(IntPtr cEditor);

        /// <summary>
        /// Invoke c++ PiPiEditor RemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorRemoveField")]
        internal static extern void PiPiEditorRemoveField(IntPtr cEditor, string fieldName);

        /// <summary>
        /// Invoke c++ PiPiEditor RemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorRemoveFieldInPage")]
        internal static extern void PiPiEditorRemoveField(IntPtr cEditor, string fieldName, int pageIndex);

        /// <summary>
        /// Invoke c++ PiPiEditor RemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorRemoveFieldAtPosition")]
        internal static extern void PiPiEditorRemoveField(IntPtr cEditor, string fieldName, int pageIndex, double x, double y);

        /// <summary>
        /// Invoke c++ PiPiEditor RemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <param name="width">The added field width.</param>
        /// <param name="height">The added field height.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorRemoveFieldExact")]
        internal static extern void PiPiEditorRemoveField(IntPtr cEditor, string fieldName, int pageIndex, double x, double y, double width, double height);

        /// <summary>
        /// Invoke c++ PiPiEditor RenameField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="oldFieldName">The old field name.</param>
        /// <param name="newFieldName">The new field name.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorRenameField")]
        internal static extern void PiPiEditorRenameField(IntPtr cEditor, string oldFieldName, string newFieldName);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldBackgroundColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldBackgroundColor")]
        internal static extern void PiPiEditorSetFieldBackgroundColor(IntPtr cEditor, string fieldname, float red, float green, float blue);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldBorderColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldBorderColor")]
        internal static extern void PiPiEditorSetFieldBorderColor(IntPtr cEditor, string fieldname, float red, float green, float blue);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldColor")]
        internal static extern void PiPiEditorSetFieldColor(IntPtr cEditor, string fieldname, float red, float green, float blue);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldFontName.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="fontName">The font name.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldFontName")]
        internal static extern void PiPiEditorSetFieldFontName(IntPtr cEditor, string fieldname, string fontName);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldFontSize.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="fontSize">The font size.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldFontSize")]
        internal static extern void PiPiEditorSetFieldFontSize(IntPtr cEditor, string fieldname, float fontSize);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldMultiline.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="multiline">The multi line value.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldMultiline")]
        internal static extern void PiPiEditorSetFieldMultiline(IntPtr cEditor, string fieldname, bool multiline);

        /// <summary>
        /// Invoke c++ PiPiEditor SetFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="alignment">The horizontal alignment.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiEditorSetFieldTextHorizontalAlignment")]
        internal static extern void PiPiEditorSetFieldTextHorizontalAlignment(IntPtr cEditor, string fieldname, ushort alignment);
    }
}