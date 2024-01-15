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
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBackgroundColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldBackgroundColor(IntPtr cEditor, string fieldname, uint pageIndex, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBackgroundColor, cEditor, fieldname, pageIndex, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBackgroundColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldBackgroundColor(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBackgroundColor, cEditor, fieldname, pageIndex, x, y, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBackgroundColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldBackgroundColor(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBackgroundColor, cEditor, fieldname, pageIndex, x, y, width, height, red, green, blue);
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
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldBorderColor(IntPtr cEditor, string fieldname, uint pageIndex, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderColor, cEditor, fieldname, pageIndex, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldBorderColor(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderColor, cEditor, fieldname, pageIndex, x, y, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldBorderColor(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderColor, cEditor, fieldname, pageIndex, x, y, width, height, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderWidth.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="borderWidth">The border width.</param>
        internal static void InvokePiPiEditorSetFieldBorderWidth(IntPtr cEditor, string fieldname, double borderWidth)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderWidth, cEditor, fieldname, borderWidth);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderWidth.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="borderWidth">The border width.</param>
        internal static void InvokePiPiEditorSetFieldBorderWidth(IntPtr cEditor, string fieldname, uint pageIndex, double borderWidth)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderWidth, cEditor, fieldname, pageIndex, borderWidth);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderWidth.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="borderWidth">The border width.</param>
        internal static void InvokePiPiEditorSetFieldBorderWidth(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double borderWidth)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderWidth, cEditor, fieldname, pageIndex, x, y, borderWidth);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldBorderWidth.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="borderWidth">The border width.</param>
        internal static void InvokePiPiEditorSetFieldBorderWidth(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, double borderWidth)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldBorderWidth, cEditor, fieldname, pageIndex, x, y, width, height, borderWidth);
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
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldColor(IntPtr cEditor, string fieldname, uint pageIndex, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldColor, cEditor, fieldname, pageIndex, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldColor(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldColor, cEditor, fieldname, pageIndex, x, y, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldColor.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="red">The red value between 0.0 to 1.0.</param>
        /// <param name="green">The green value between 0.0 to 1.0.</param>
        /// <param name="blue">The blue value between 0.0 to 1.0.</param>
        internal static void InvokePiPiEditorSetFieldColor(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, float red, float green, float blue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldColor, cEditor, fieldname, pageIndex, x, y, width, height, red, green, blue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldDefaultValue.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="defaultValue">The default value.</param>
        internal static void InvokePiPiEditorSetFieldDefaultValue(IntPtr cEditor, string fieldname, string defaultValue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldDefaultValue, cEditor, fieldname, defaultValue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldDefaultValue.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="defaultValue">The default value.</param>
        internal static void InvokePiPiEditorSetFieldDefaultValue(IntPtr cEditor, string fieldname, uint pageIndex, string defaultValue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldDefaultValue, cEditor, fieldname, pageIndex, defaultValue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldDefaultValue.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="defaultValue">The default value.</param>
        internal static void InvokePiPiEditorSetFieldDefaultValue(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, string defaultValue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldDefaultValue, cEditor, fieldname, pageIndex, x, y, defaultValue);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldDefaultValue.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="defaultValue">The default value.</param>
        internal static void InvokePiPiEditorSetFieldDefaultValue(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, string defaultValue)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldDefaultValue, cEditor, fieldname, pageIndex, x, y, width, height, defaultValue);
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
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontName.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="fontName">The font name.</param>
        internal static void InvokePiPiEditorSetFieldFontName(IntPtr cEditor, string fieldname, uint pageIndex, string fontName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontName, cEditor, fieldname, pageIndex, fontName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontName.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="fontName">The font name.</param>
        internal static void InvokePiPiEditorSetFieldFontName(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, string fontName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontName, cEditor, fieldname, pageIndex, x, y, fontName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontName.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fontName">The font name.</param>
        internal static void InvokePiPiEditorSetFieldFontName(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, string fontName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontName, cEditor, fieldname, pageIndex, x, y, width, height, fontName);
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
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontSize.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="fontSize">The font size.</param>
        internal static void InvokePiPiEditorSetFieldFontSize(IntPtr cEditor, string fieldname, uint pageIndex, float fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontSize, cEditor, fieldname, pageIndex, fontSize);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontSize.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="fontSize">The font size.</param>
        internal static void InvokePiPiEditorSetFieldFontSize(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, float fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontSize, cEditor, fieldname, pageIndex, x, y, fontSize);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldFontSize.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fontSize">The font size.</param>
        internal static void InvokePiPiEditorSetFieldFontSize(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, float fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldFontSize, cEditor, fieldname, pageIndex, x, y, width, height, fontSize);
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
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldMultiline.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="multiline">The multi line value.</param>
        internal static void InvokePiPiEditorSetFieldMultiline(IntPtr cEditor, string fieldname, uint pageIndex, bool multiline)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldMultiline, cEditor, fieldname, pageIndex, multiline);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldMultiline.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="multiline">The multi line value.</param>
        internal static void InvokePiPiEditorSetFieldMultiline(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, bool multiline)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldMultiline, cEditor, fieldname, pageIndex, x, y, multiline);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldMultiline.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="multiline">The multi line value.</param>
        internal static void InvokePiPiEditorSetFieldMultiline(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, bool multiline)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldMultiline, cEditor, fieldname, pageIndex, x, y, width, height, multiline);
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

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="alignment">The horizontal alignment.</param>
        internal static void InvokePiPiEditorSetFieldTextHorizontalAlignment(IntPtr cEditor, string fieldname, uint pageIndex, uint alignment)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldTextHorizontalAlignment, cEditor, fieldname, pageIndex, alignment);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="alignment">The horizontal alignment.</param>
        internal static void InvokePiPiEditorSetFieldTextHorizontalAlignment(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, uint alignment)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldTextHorizontalAlignment, cEditor, fieldname, pageIndex, x, y, alignment);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiEditorSetFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cEditor">PiPiEditor instance pointer.</param>
        /// <param name="fieldname">The field name.</param>
        /// <param name="pageIndex">The page index.</param>
        /// <param name="x">The x position.</param>
        /// <param name="y">The y position.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="alignment">The horizontal alignment.</param>
        internal static void InvokePiPiEditorSetFieldTextHorizontalAlignment(IntPtr cEditor, string fieldname, uint pageIndex, double x, double y, double width, double height, uint alignment)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiEditWrapper.PiPiEditorSetFieldTextHorizontalAlignment, cEditor, fieldname, pageIndex, x, y, width, height, alignment);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
