// <copyright file="PiPiCSharpEditWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Wrapper for PiPiEditWrapper.
    /// </summary>
    internal static class PiPiCSharpEditWrapper
    {
        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiEditor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        internal static void DeletePiPiEditor(IntPtr cEditor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiEditWrapper.DeletePiPiEditor, cEditor);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorAddField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="type">The added field type.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <param name="width">The added field width.</param>
        /// <param name="height">The added field height.</param>
        internal static void PiPiEditorAddField(IntPtr cEditor, string fieldName, ushort type, ushort pageIndex, double x, double y, double width, double height)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, ushort, ushort, double, double, double, double>(PiPiEditWrapper.PiPiEditorAddField, cEditor, fieldName, type, pageIndex, x, y, width, height);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorFlatten.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        internal static void PiPiEditorFlatten(IntPtr cEditor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiEditWrapper.PiPiEditorFlatten, cEditor);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorIsOperable.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool PiPiEditorIsOperable(IntPtr cEditor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<bool, IntPtr>(PiPiEditWrapper.PiPiEditorIsOperable, cEditor);
            bool operable = PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
            return false;
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        internal static void PiPiEditorRemoveField(IntPtr cEditor, string fieldName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string>(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        internal static void PiPiEditorRemoveField(IntPtr cEditor, string fieldName, int pageIndex)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, int>(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName, pageIndex);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        internal static void PiPiEditorRemoveField(IntPtr cEditor, string fieldName, int pageIndex, double x, double y)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, int, double, double>(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName, pageIndex, x, y);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        /// <param name="x">The added field x position.</param>
        /// <param name="y">The added field y position.</param>
        /// <param name="width">The added field width.</param>
        /// <param name="height">The added field height.</param>
        internal static void PiPiEditorRemoveField(IntPtr cEditor, string fieldName, int pageIndex, double x, double y, double width, double height)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, int, double, double, double, double>(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName, pageIndex, x, y, width, height);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRenameField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="oldFieldName">The old field name.</param>
        /// <param name="newFieldName">The new field name.</param>
        internal static void PiPiEditorRenameField(IntPtr cEditor, string oldFieldName, string newFieldName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, string>(PiPiEditWrapper.PiPiEditorRenameField, cEditor, oldFieldName, newFieldName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBackgroundColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void PiPiEditorSetFieldBackgroundColor(IntPtr cEditor, string fieldname, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, float, float, float>(PiPiEditWrapper.PiPiEditorSetFieldBackgroundColor, cEditor, fieldname, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void PiPiEditorSetFieldBorderColor(IntPtr cEditor, string fieldname, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, float, float, float>(PiPiEditWrapper.PiPiEditorSetFieldBorderColor, cEditor, fieldname, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void PiPiEditorSetFieldColor(IntPtr cEditor, string fieldname, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, float, float, float>(PiPiEditWrapper.PiPiEditorSetFieldColor, cEditor, fieldname, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontName.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="fontName">The font name.</param>
        internal static void PiPiEditorSetFieldFontName(IntPtr cEditor, string fieldname, string fontName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, string>(PiPiEditWrapper.PiPiEditorSetFieldFontName, cEditor, fieldname, fontName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontSize.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="fontSize">The font size.</param>
        internal static void PiPiEditorSetFieldFontSize(IntPtr cEditor, string fieldname, float fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, float>(PiPiEditWrapper.PiPiEditorSetFieldFontSize, cEditor, fieldname, fontSize);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldMultiline.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="multiline">The multi line value.</param>
        internal static void PiPiEditorSetFieldMultiline(IntPtr cEditor, string fieldname, bool multiline)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, bool>(PiPiEditWrapper.PiPiEditorSetFieldMultiline, cEditor, fieldname, multiline);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="alignment">The horizontal alignment.</param>
        internal static void PiPiEditorSetFieldTextHorizontalAlignment(IntPtr cEditor, string fieldname, ushort alignment)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, ushort>(PiPiEditWrapper.PiPiEditorSetFieldTextHorizontalAlignment, cEditor, fieldname, alignment);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
