// <copyright file="PiPiMultiOperateWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiMultiOperator.
    /// </summary>
    internal static class PiPiMultiOperateWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiMultiOperator constructor.
        /// </summary>
        /// <returns>PiPiMultiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "CreatePiPiMultiOperator")]
        internal static extern IntPtr CreatePiPiMultiOperator();

        /// <summary>
        /// Invoke c++ PiPiMultiOperator destructor.
        /// </summary
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiMultiOperator")]
        internal static extern void DeletePiPiMultiOperator(IntPtr cMultiOp);

        /// <summary>
        /// Invoke c++ PiPiMultiOperator Add.
        /// </summary
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <param name="pdfBytes">The PDF binary bytes.</param>
        /// <param name="pdfSize">The PDF binary size.</param>
        /// <returns>The index of PDF.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiMultiOperatorAdd")]
        internal static extern int PiPiMultiOperatorAdd(IntPtr cMultiOp, byte[] pdfBytes, int pdfSize);

        /// <summary>
        /// Invoke c++ PiPiMultiOperator GetPointer.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <param name="index">The index of PDF.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiMultiOperatorGetOperator")]
        internal static extern IntPtr PiPiMultiOperatorGetOperator(IntPtr cMultiOp, int index);

        /// <summary>
        /// Invoke c++ PiPiMultiOperator GetPager.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <returns>PiPiPager instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiMultiOperatorGetPager")]
        internal static extern IntPtr PiPiMultiOperatorGetPager(IntPtr cMultiOp);
    }
}