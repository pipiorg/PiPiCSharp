// <copyright file="PiPiCSharpFillWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Wrapper for PiPiFillWrapper.
    /// </summary>
    internal static class PiPiCSharpFillWrapper
    {
        /// <summary>
        /// Invoke PiPiFillWrapper DeletePiPiFiller.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        internal static void DeletePiPiFiller(IntPtr cFiller)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiFillWrapper.DeletePiPiFiller, cFiller);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerFillEllipsisValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <param name="ellipsis">The ellipsis.</param>
        internal static void PiPiFillerFillEllipsisValue(IntPtr cFiller, string fieldName, string value, bool ellipsis)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, string, bool>(PiPiFillWrapper.PiPiFillerFillEllipsisValue, cFiller, fieldName, value, ellipsis);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerFillImage.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="imageBytes">The image binary bytes.</param>
        /// <param name="imageSize">The image binary size.</param>
        internal static void PiPiFillerFillImage(IntPtr cFiller, string fieldName, byte[] imageBytes, int imageSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, byte[], int>(PiPiFillWrapper.PiPiFillerFillImage, cFiller, fieldName, imageBytes, imageSize);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerFillValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        internal static void PiPiFillerFillValue(IntPtr cFiller, string fieldName, string value)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr, string, string>(PiPiFillWrapper.PiPiFillerFillValue, cFiller, fieldName, value);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerIsOperable.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool PiPiFillerIsOperable(IntPtr cFiller)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<bool, IntPtr>(PiPiFillWrapper.PiPiFillerIsOperable, cFiller);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
