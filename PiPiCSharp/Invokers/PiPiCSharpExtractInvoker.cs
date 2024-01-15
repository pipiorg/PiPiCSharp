// <copyright file="PiPiCSharpExtractInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiExtractWrapper.
    /// </summary>
    internal static class PiPiCSharpExtractInvoker
    {
        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractor.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        internal static void InvokeDeletePiPiExtractor(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiExtractWrapper.DeletePiPiExtractor, cExtractor);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedField.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        internal static void InvokeDeletePiPiExtractorExtractedField(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiExtractWrapper.DeletePiPiExtractorExtractedField, cExtractedField);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedFields.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        internal static void InvokeDeletePiPiExtractorExtractedFields(IntPtr cExtractedFields)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiExtractWrapper.DeletePiPiExtractorExtractedFields, cExtractedFields);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedPage.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        internal static void InvokeDeletePiPiExtractorExtractedPage(IntPtr cExtractedPage)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiExtractWrapper.DeletePiPiExtractorExtractedPage, cExtractedPage);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedPages.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        internal static void InvokeDeletePiPiExtractorExtractedPages(IntPtr cExtractedPages)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiExtractWrapper.DeletePiPiExtractorExtractedPages, cExtractedPages);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractedFieldsSize.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <returns>>The extracted fields size.</returns>
        internal static uint InvokePiPiExtractorExtractedFieldsSize(IntPtr cExtractedFields)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorExtractedFieldsSize, cExtractedFields);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractedPagesSize.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <returns>The extracted pages size.</returns>
        internal static uint InvokePiPiExtractorExtractedPagesSize(IntPtr cExtractedPages)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorExtractedPagesSize, cExtractedPages);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractField.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted field pointer.</returns>
        internal static IntPtr InvokePiPiExtractorExtractField(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorExtractField, cExtractor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractPage.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted page pointer.</returns>
        internal static IntPtr InvokePiPiExtractorExtractPage(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorExtractPage, cExtractor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedField.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <param name="index">The index of extracted field.</param>
        /// <returns>The extracted field pointer.</returns>
        internal static IntPtr InvokePiPiExtractorGetExtractedField(IntPtr cExtractedFields, uint index)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedField, cExtractedFields, index);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBackgroundColorBlue.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background color blue.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldBackgroundColorBlue(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBackgroundColorBlue, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBackgroundColorGreen.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background color green.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldBackgroundColorGreen(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBackgroundColorGreen, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBackgroundColorRed.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background color red.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldBackgroundColorRed(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBackgroundColorRed, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBackgroundExists.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field background exists.</returns>
        internal static bool InvokePiPiExtractorGetExtractedFieldBackgroundExists(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBackgroundExists, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBorderColorBlue.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border color blue.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldBorderdColorBlue(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBorderColorBlue, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBorderColorGreen.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border color green.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldBorderdColorGreen(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBorderColorGreen, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBorderColorRed.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border color red.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldBorderdColorRed(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBorderColorRed, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBorderExists.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field border exists.</returns>
        internal static bool InvokePiPiExtractorGetExtractedFieldBorderExists(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBorderExists, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldBorderWidth.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field borderWidth.</returns>
        internal static double InvokePiPiExtractorGetExtractedFieldBorderWidth(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldBorderWidth, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldColorBlue.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field color blue.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldColorBlue(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldColorBlue, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldColorGreen.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field color green.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldColorGreen(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldColorGreen, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldColorRed.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field color red.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldColorRed(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldColorRed, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldDefaultValue.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field default value.</returns>
        internal static IntPtr InvokePiPiExtractorGetExtractedFieldDefaultValue(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldDefaultValue, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldFontName.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font name.</returns>
        internal static IntPtr InvokePiPiExtractorGetExtractedFieldFontName(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldFontName, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldFontSize.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font size.</returns>
        internal static float InvokePiPiExtractorGetExtractedFieldFontSize(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldFontSize, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldHeight.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field height.</returns>
        internal static double InvokePiPiExtractorGetExtractedFieldHeight(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldHeight, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldMultiline.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field multiline.</returns>
        internal static bool InvokePiPiExtractorGetExtractedFieldMultiline(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldMultiline, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldName.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field name.</returns>
        internal static IntPtr InvokePiPiExtractorGetExtractedFieldName(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldName, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldPageIndex.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field page index.</returns>
        internal static uint InvokePiPiExtractorGetExtractedFieldPageIndex(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldPageIndex, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldTextHorizontalAlignment.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field text horizontal alignment.</returns>
        internal static uint InvokePiPiExtractorGetExtractedFieldTextHorizontalAlignment(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldTextHorizontalAlignment, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldType.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field type.</returns>
        internal static uint InvokePiPiExtractorGetExtractedFieldType(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldType, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldWidth.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field width.</returns>
        internal static double InvokePiPiExtractorGetExtractedFieldWidth(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldWidth, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldX.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field x.</returns>
        internal static double InvokePiPiExtractorGetExtractedFieldX(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldX, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldY.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field y.</returns>
        internal static double InvokePiPiExtractorGetExtractedFieldY(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldY, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedPage.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <param name="index">The index of extracted page.</param>
        /// <returns>The extracted page pointer.</returns>
        internal static IntPtr InvokePiPiExtractorGetExtractedPage(IntPtr cExtractedPages, uint index)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedPage, cExtractedPages, index);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedPageHeight.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page height.</returns>
        internal static double InvokePiPiExtractorGetExtractedPageHeight(IntPtr cExtractedPage)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedPageHeight, cExtractedPage);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedPageWidth.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page width.</returns>
        internal static double InvokePiPiExtractorGetExtractedPageWidth(IntPtr cExtractedPage)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorGetExtractedPageWidth, cExtractedPage);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorIsOperable.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool InvokePiPiExtractorIsOperable(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiExtractWrapper.PiPiExtractorIsOperable, cExtractor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
