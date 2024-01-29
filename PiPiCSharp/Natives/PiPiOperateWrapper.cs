// <copyright file="PiPiOperateWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Natives
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiOperator.
    /// </summary>
    internal static class PiPiOperateWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiOperator constructor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        /// <param name="pdfSize">The pdf binary size.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "CreatePiPiOperator")]
        internal static extern IntPtr CreatePiPiOperator(ref int code, ref int exCode, ref int exSubCode, byte[] pdfBytes, uint pdfSize);

        /// <summary>
        /// Invoke c++ PiPiOperator destructor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="op">PiPiOperator instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiOperator")]
        internal static extern void DeletePiPiOperator(ref int code, ref int exCode, ref int exSubCode, IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator Finalize bytes getter.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        /// <param name="newPdfBytes">The finalize binary bytes.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorCopyFinalize")]
        internal static extern void PiPiOperatorCopyFinalize(ref int code, ref int exCode, ref int exSubCode, IntPtr output, byte[] newPdfBytes);

        /// <summary>
        /// Invoke c++ PiPiOperator Release Finalize.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorDeleteFinalize")]
        internal static extern void PiPiOperatorDeleteFinalize(ref int code, ref int exCode, ref int exSubCode, IntPtr output);

        /// <summary>
        /// Invoke c++ PiPiOperator Finalize.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>The output PDF binary c++ pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorFinalize")]
        internal static extern IntPtr PiPiOperatorFinalize(ref int code, ref int exCode, ref int exSubCode, IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetEditor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiEditor instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetEditor")]
        internal static extern IntPtr PiPiOperatorGetEditor(ref int code, ref int exCode, ref int exSubCode, IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetFiller.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFiller instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetFiller")]
        internal static extern IntPtr PiPiOperatorGetFiller(ref int code, ref int exCode, ref int exSubCode, IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetExtractor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiExtractor instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetExtractor")]
        internal static extern IntPtr PiPiOperatorGetPiPiExtractor(ref int code, ref int exCode, ref int exSubCode, IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetFontRegister.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFontRegister instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetFontRegister")]
        internal static extern IntPtr PiPiOperatorGetPiPiFontRegister(ref int code, ref int exCode, ref int exSubCode, IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator Finalize size getter.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        /// <returns>The finalize binary size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorMeasureFinalize")]
        internal static extern uint PiPiOperatorMeasureFinalize(ref int code, ref int exCode, ref int exSubCode, IntPtr output);
    }
}
