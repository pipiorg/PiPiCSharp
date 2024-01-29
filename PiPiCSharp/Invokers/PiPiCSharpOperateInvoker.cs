// <copyright file="PiPiCSharpOperateInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiOperateWrapper.
    /// </summary>
    internal static class PiPiCSharpOperateInvoker
    {
        /// <summary>
        /// Invoke PiPiOperateWrapper CreatePiPiOperator.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        /// <param name="pdfSize">The pdf binary size.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        internal static IntPtr InvokeCreatePiPiOperator(byte[] pdfBytes, uint pdfSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.CreatePiPiOperator, pdfBytes, pdfSize);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper DeletePiPiOperator.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        internal static void InvokeDeletePiPiOperator(IntPtr op)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiOperateWrapper.DeletePiPiOperator, op);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorCopyFinalize.
        /// </summary>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        /// <param name="newPdfBytes">The finalize binary bytes.</param>
        internal static void InvokePiPiOperatorCopyFinalize(IntPtr output, byte[] newPdfBytes)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiOperateWrapper.PiPiOperatorCopyFinalize, output, newPdfBytes);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorDeleteFinalize.
        /// </summary>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        internal static void InvokePiPiOperatorDeleteFinalize(IntPtr output)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiOperateWrapper.PiPiOperatorDeleteFinalize, output);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorFinalize.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>The output PDF binary c++ pointer.</returns>
        internal static IntPtr InvokePiPiOperatorFinalize(IntPtr op)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.PiPiOperatorFinalize, op);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorGetEditor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiEditor instance pointer.</returns>
        internal static IntPtr InvokePiPiOperatorGetEditor(IntPtr op)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.PiPiOperatorGetEditor, op);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorGetFiller.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFiller instance pointer.</returns>
        internal static IntPtr InvokePiPiOperatorGetFiller(IntPtr op)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.PiPiOperatorGetFiller, op);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorGetPiPiExtractor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiExtractor instance pointer.</returns>
        internal static IntPtr InvokePiPiOperatorGetPiPiExtractor(IntPtr op)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.PiPiOperatorGetPiPiExtractor, op);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorGetPiPiFontRegister.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFontRegister instance pointer.</returns>
        internal static IntPtr InvokePiPiOperatorGetPiPiFontRegister(IntPtr op)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.PiPiOperatorGetPiPiFontRegister, op);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiOperateWrapper PiPiOperatorMeasureFinalize.
        /// </summary>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        /// <returns>The finalize binary size.</returns>
        internal static uint InvokePiPiOperatorMeasureFinalize(IntPtr output)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiOperateWrapper.PiPiOperatorMeasureFinalize, output);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
