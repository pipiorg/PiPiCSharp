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