// <copyright file="PiPiCSharpFillInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiFillWrapper.
    /// </summary>
    internal static class PiPiCSharpFillInvoker
    {
        /// <summary>
        /// Invoke PiPiFillWrapper DeletePiPiFiller.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        internal static void InvokeDeletePiPiFiller(IntPtr cFiller)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFillWrapper.DeletePiPiFiller, cFiller);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerFillEllipsisValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <param name="ellipsis">The ellipsis.</param>
        internal static void InvokePiPiFillerFillEllipsisValue(IntPtr cFiller, string fieldName, string value, bool ellipsis)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFillWrapper.PiPiFillerFillEllipsisValue, cFiller, fieldName, value, ellipsis);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerFillImage.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="imageBytes">The image binary bytes.</param>
        /// <param name="imageSize">The image binary size.</param>
        internal static void InvokePiPiFillerFillImage(IntPtr cFiller, string fieldName, byte[] imageBytes, uint imageSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFillWrapper.PiPiFillerFillImage, cFiller, fieldName, imageBytes, imageSize);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerFillValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        internal static void InvokePiPiFillerFillValue(IntPtr cFiller, string fieldName, string value)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFillWrapper.PiPiFillerFillValue, cFiller, fieldName, value);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFillWrapper PiPiFillerIsOperable.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool InvokePiPiFillerIsOperable(IntPtr cFiller)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiFillWrapper.PiPiFillerIsOperable, cFiller);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
