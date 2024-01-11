// <copyright file="PiPiCSharpEditInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiEditWrapper.
    /// </summary>
    internal static class PiPiCSharpEditInvoker
    {
        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiEditor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        internal static void InvokeDeletePiPiEditor(IntPtr cEditor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.DeletePiPiEditor, cEditor);
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
        internal static void InvokePiPiEditorAddField(IntPtr cEditor, string fieldName, uint type, uint pageIndex, double x, double y, double width, double height)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorAddField, cEditor, fieldName, type, pageIndex, x, y, width, height);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorFlatten.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        internal static void InvokePiPiEditorFlatten(IntPtr cEditor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorFlatten, cEditor);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorIsOperable.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool InvokePiPiEditorIsOperable(IntPtr cEditor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiEditWrapper.PiPiEditorIsOperable, cEditor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        internal static void InvokePiPiEditorRemoveField(IntPtr cEditor, string fieldName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRemoveField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldName">The added field name.</param>
        /// <param name="pageIndex">The added field page located index.</param>
        internal static void InvokePiPiEditorRemoveField(IntPtr cEditor, string fieldName, uint pageIndex)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName, pageIndex);
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
        internal static void InvokePiPiEditorRemoveField(IntPtr cEditor, string fieldName, uint pageIndex, double x, double y)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName, pageIndex, x, y);
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
        internal static void InvokePiPiEditorRemoveField(IntPtr cEditor, string fieldName, uint pageIndex, double x, double y, double width, double height)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorRemoveField, cEditor, fieldName, pageIndex, x, y, width, height);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorRenameField.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="oldFieldName">The old field name.</param>
        /// <param name="newFieldName">The new field name.</param>
        internal static void InvokePiPiEditorRenameField(IntPtr cEditor, string oldFieldName, string newFieldName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorRenameField, cEditor, oldFieldName, newFieldName);
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
        internal static void InvokePiPiEditorSetFieldBackgroundColor(IntPtr cEditor, string fieldname, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBackgroundColor, cEditor, fieldname, red, green, blue);
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
        internal static void InvokePiPiEditorSetFieldBorderColor(IntPtr cEditor, string fieldname, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderColor, cEditor, fieldname, red, green, blue);
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
        internal static void InvokePiPiEditorSetFieldColor(IntPtr cEditor, string fieldname, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldColor, cEditor, fieldname, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontName.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="fontName">The font name.</param>
        internal static void InvokePiPiEditorSetFieldFontName(IntPtr cEditor, string fieldname, string fontName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontName, cEditor, fieldname, fontName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontSize.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="fontSize">The font size.</param>
        internal static void InvokePiPiEditorSetFieldFontSize(IntPtr cEditor, string fieldname, float fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontSize, cEditor, fieldname, fontSize);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldMultiline.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="multiline">The multi line value.</param>
        internal static void InvokePiPiEditorSetFieldMultiline(IntPtr cEditor, string fieldname, bool multiline)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldMultiline, cEditor, fieldname, multiline);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="alignment">The horizontal alignment.</param>
        internal static void InvokePiPiEditorSetFieldTextHorizontalAlignment(IntPtr cEditor, string fieldname, uint alignment)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldTextHorizontalAlignment, cEditor, fieldname, alignment);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
