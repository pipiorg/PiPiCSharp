// <copyright file="PiPiExtractWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Natives
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiExtractor.
    /// </summary>
    internal static class PiPiExtractWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiExtractor destructor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractor")]
        internal static extern void DeletePiPiExtractor(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractor);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted field.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedField")]
        internal static extern void DeletePiPiExtractorExtractedField(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted fields.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedFields")]
        internal static extern void DeletePiPiExtractorExtractedFields(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedFields);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted page.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedPage")]
        internal static extern void DeletePiPiExtractorExtractedPage(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedPage);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted pages.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedPages")]
        internal static extern void DeletePiPiExtractorExtractedPages(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedPages);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted fields size.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <returns>>The extracted fields size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractedFieldsSize")]
        internal static extern uint PiPiExtractorExtractedFieldsSize(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedFields);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted pages size.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <returns>The extracted pages size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractedPagesSize")]
        internal static extern uint PiPiExtractorExtractedPagesSize(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedPages);

        /// <summary>
        /// Invoke c++ PiPiExtractor ExtractField.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted field pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractField")]
        internal static extern IntPtr PiPiExtractorExtractField(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractor);

        /// <summary>
        /// Invoke c++ PiPiExtractor ExtractPage.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted page pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractPage")]
        internal static extern IntPtr PiPiExtractorExtractPage(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractor);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field from extracted fields.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <param name="index">The index of extracted field.</param>
        /// <returns>The extracted field pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedField")]
        internal static extern IntPtr PiPiExtractorGetExtractedField(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedFields, uint index);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field background color blue.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background color blue.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBackgroundColorBlue")]
        internal static extern float PiPiExtractorGetExtractedFieldBackgroundColorBlue(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field background color green.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background color green.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBackgroundColorGreen")]
        internal static extern float PiPiExtractorGetExtractedFieldBackgroundColorGreen(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field background color red.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background color red.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBackgroundColorRed")]
        internal static extern float PiPiExtractorGetExtractedFieldBackgroundColorRed(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field background exists.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background exists.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBackgroundExists")]
        internal static extern bool PiPiExtractorGetExtractedFieldBackgroundExists(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field border color blue.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border color blue.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBorderColorBlue")]
        internal static extern float PiPiExtractorGetExtractedFieldBorderColorBlue(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field border color green.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border color green.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBorderColorGreen")]
        internal static extern float PiPiExtractorGetExtractedFieldBorderColorGreen(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field border color red.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border color red.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBorderColorRed")]
        internal static extern float PiPiExtractorGetExtractedFieldBorderColorRed(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field border exists.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border exists.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBorderExists")]
        internal static extern bool PiPiExtractorGetExtractedFieldBorderExists(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field height.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field height.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldBorderWidth")]
        internal static extern double PiPiExtractorGetExtractedFieldBorderWidth(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field color blue.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field color blue.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldColorBlue")]
        internal static extern float PiPiExtractorGetExtractedFieldColorBlue(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field color green.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field color green.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldColorGreen")]
        internal static extern float PiPiExtractorGetExtractedFieldColorGreen(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field color red.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field color red.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldColorRed")]
        internal static extern float PiPiExtractorGetExtractedFieldColorRed(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field default value.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field default value.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldDefaultValue")]
        internal static extern IntPtr PiPiExtractorGetExtractedFieldDefaultValue(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field font name.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font name.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldFontName")]
        internal static extern IntPtr PiPiExtractorGetExtractedFieldFontName(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field font size.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldFontSize")]
        internal static extern float PiPiExtractorGetExtractedFieldFontSize(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field height.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field height.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldHeight")]
        internal static extern double PiPiExtractorGetExtractedFieldHeight(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field multiline.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field multiline.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldMultiline")]
        internal static extern bool PiPiExtractorGetExtractedFieldMultiline(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field name.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field name.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldName")]
        internal static extern IntPtr PiPiExtractorGetExtractedFieldName(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field page index.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field page index.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldPageIndex")]
        internal static extern uint PiPiExtractorGetExtractedFieldPageIndex(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field text horizontal alignment.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field text horizontal alignment.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldTextHorizontalAlignment")]
        internal static extern uint PiPiExtractorGetExtractedFieldTextHorizontalAlignment(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field type.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field type.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldType")]
        internal static extern uint PiPiExtractorGetExtractedFieldType(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field width.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field width.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldWidth")]
        internal static extern double PiPiExtractorGetExtractedFieldWidth(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field x.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field x.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldX")]
        internal static extern double PiPiExtractorGetExtractedFieldX(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field y.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field y.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldY")]
        internal static extern double PiPiExtractorGetExtractedFieldY(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted page from extracted pages.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <param name="index">The index of extracted page.</param>
        /// <returns>The extracted page pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedPage")]
        internal static extern IntPtr PiPiExtractorGetExtractedPage(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedPages, uint index);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted page height.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page height.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedPageHeight")]
        internal static extern double PiPiExtractorGetExtractedPageHeight(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedPage);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted page width.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page width.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedPageWidth")]
        internal static extern double PiPiExtractorGetExtractedPageWidth(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractedPage);

        /// <summary>
        /// Invoke c++ PiPiExtractor IsOperable.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorIsOperable")]
        internal static extern bool PiPiExtractorIsOperable(ref int code, ref int exCode, ref int exSubCode, IntPtr cExtractor);
    }
}
