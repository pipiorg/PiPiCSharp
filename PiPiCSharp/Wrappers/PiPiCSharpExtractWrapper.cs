// <copyright file="PiPiCSharpExtractWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Wrapper for PiPiExtractWrapper.
    /// </summary>
    internal static class PiPiCSharpExtractWrapper
    {
        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedField.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        internal static void DeletePiPiExtractorExtractedField(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiExtractWrapper.DeletePiPiExtractorExtractedField, cExtractedField);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedFields.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        internal static void DeletePiPiExtractorExtractedFields(IntPtr cExtractedFields)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiExtractWrapper.DeletePiPiExtractorExtractedFields, cExtractedFields);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedPage.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        internal static void DeletePiPiExtractorExtractedPage(IntPtr cExtractedPage)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiExtractWrapper.DeletePiPiExtractorExtractedPage, cExtractedPage);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper DeletePiPiExtractorExtractedPages.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        internal static void DeletePiPiExtractorExtractedPages(IntPtr cExtractedPages)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiExtractWrapper.DeletePiPiExtractorExtractedPages, cExtractedPages);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractedFieldsSize.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <returns>>The extracted fields size.</returns>
        internal static ushort PiPiExtractorExtractedFieldsSize(IntPtr cExtractedFields)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<ushort, IntPtr>(PiPiExtractWrapper.PiPiExtractorExtractedFieldsSize, cExtractedFields);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractedPagesSize.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <returns>The extracted pages size.</returns>
        internal static ushort PiPiExtractorExtractedPagesSize(IntPtr cExtractedPages)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<ushort, IntPtr>(PiPiExtractWrapper.PiPiExtractorExtractedPagesSize, cExtractedPages);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractField.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted field pointer.</returns>
        internal static IntPtr PiPiExtractorExtractField(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr>(PiPiExtractWrapper.PiPiExtractorExtractField, cExtractor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorExtractPage.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted page pointer.</returns>
        internal static IntPtr PiPiExtractorExtractPage(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr>(PiPiExtractWrapper.PiPiExtractorExtractPage, cExtractor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedField.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <param name="index">The index of extracted field.</param>
        /// <returns>The extracted field pointer.</returns>
        internal static IntPtr PiPiExtractorGetExtractedField(IntPtr cExtractedFields, int index)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr, int>(PiPiExtractWrapper.PiPiExtractorGetExtractedField, cExtractedFields, index);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldFontName.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font name.</returns>
        internal static IntPtr PiPiExtractorGetExtractedFieldFontName(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldFontName, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldFontSize.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font size.</returns>
        internal static float PiPiExtractorGetExtractedFieldFontSize(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<float, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldFontSize, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldHeight.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field height.</returns>
        internal static double PiPiExtractorGetExtractedFieldHeight(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<double, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldHeight, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldName.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field name.</returns>
        internal static IntPtr PiPiExtractorGetExtractedFieldName(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldName, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldPageIndex.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field page index.</returns>
        internal static ushort PiPiExtractorGetExtractedFieldPageIndex(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<ushort, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldPageIndex, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldType.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field type.</returns>
        internal static ushort PiPiExtractorGetExtractedFieldType(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<ushort, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldType, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldWidth.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field width.</returns>
        internal static double PiPiExtractorGetExtractedFieldWidth(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<double, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldWidth, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldX.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field x.</returns>
        internal static double PiPiExtractorGetExtractedFieldX(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<double, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldX, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedFieldY.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field y.</returns>
        internal static double PiPiExtractorGetExtractedFieldY(IntPtr cExtractedField)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<double, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedFieldY, cExtractedField);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedPage.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <param name="index">The index of extracted page.</param>
        /// <returns>The extracted page pointer.</returns>
        internal static IntPtr PiPiExtractorGetExtractedPage(IntPtr cExtractedPages, int index)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr, int>(PiPiExtractWrapper.PiPiExtractorGetExtractedPage, cExtractedPages, index);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedPageHeight.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page height.</returns>
        internal static double PiPiExtractorGetExtractedPageHeight(IntPtr cExtractedPage)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<double, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedPageHeight, cExtractedPage);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorGetExtractedPageWidth.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page width.</returns>
        internal static double PiPiExtractorGetExtractedPageWidth(IntPtr cExtractedPage)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<double, IntPtr>(PiPiExtractWrapper.PiPiExtractorGetExtractedPageWidth, cExtractedPage);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiEditWrapper PiPiExtractorIsOperable.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool PiPiExtractorIsOperable(IntPtr cExtractor)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<bool, IntPtr>(PiPiExtractWrapper.PiPiExtractorIsOperable, cExtractor);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
