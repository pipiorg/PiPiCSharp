// <copyright file="PiPiCSharpMultiOperateInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiMultiOperateWrapper.
    /// </summary>
    internal static class PiPiCSharpMultiOperateInvoker
    {
        /// <summary>
        /// Invoke PiPiMultiOperateWrapper CreatePiPiMultiOperator.
        /// </summary>
        /// <returns>PiPiMultiOperator instance pointer.</returns>
        internal static IntPtr InvokeCreatePiPiMultiOperator()
        {
            return PiPiCSharpDelegateInvoker.Invoke(PiPiMultiOperateWrapper.CreatePiPiMultiOperator);
        }

        /// <summary>
        /// Invoke PiPiMultiOperateWrapper DeletePiPiMultiOperator.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        internal static void InvokeDeletePiPiMultiOperator(IntPtr cMultiOp)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiMultiOperateWrapper.DeletePiPiMultiOperator, cMultiOp);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiMultiOperateWrapper PiPiMultiOperatorAdd.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <param name="pdfBytes">The PDF binary bytes.</param>
        /// <param name="pdfSize">The PDF binary size.</param>
        /// <returns>The index of PDF.</returns>
        internal static uint InvokePiPiMultiOperatorAdd(IntPtr cMultiOp, byte[] pdfBytes, uint pdfSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiMultiOperateWrapper.PiPiMultiOperatorAdd, cMultiOp, pdfBytes, pdfSize);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiMultiOperateWrapper PiPiMultiOperatorGetOperator.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <param name="index">The index of PDF.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        internal static IntPtr InvokePiPiMultiOperatorGetOperator(IntPtr cMultiOp, uint index)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiMultiOperateWrapper.PiPiMultiOperatorGetOperator, cMultiOp, index);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiMultiOperateWrapper PiPiMultiOperatorGetPager.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <returns>PiPiPager instance pointer.</returns>
        internal static IntPtr InvokePiPiMultiOperatorGetPager(IntPtr cMultiOp)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiMultiOperateWrapper.PiPiMultiOperatorGetPager, cMultiOp);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
