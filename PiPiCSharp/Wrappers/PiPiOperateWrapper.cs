// <copyright file="PiPiOperateWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
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
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        /// <param name="pdfSize">The pdf binary size.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "CreatePiPiOperator")]
        internal static extern IntPtr CreatePiPiOperator(byte[] pdfBytes, int pdfSize);

        /// <summary>
        /// Invoke c++ PiPiOperator destructor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiOperator")]
        internal static extern void DeletePiPiOperator(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator Finalize bytes getter.
        /// </summary>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        /// <param name="newPdfBytes">The finalize binary bytes.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorCopyFinalize")]
        internal static extern void PiPiOperatorCopyFinalize(IntPtr output, byte[] newPdfBytes);

        /// <summary>
        /// Invoke c++ PiPiOperator Release Finalize.
        /// </summary>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorDeleteFinalize")]
        internal static extern void PiPiOperatorDeleteFinalize(IntPtr output);

        /// <summary>
        /// Invoke c++ PiPiOperator Finalize.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>The output PDF binary c++ pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorFinalize")]
        internal static extern IntPtr PiPiOperatorFinalize(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetEditor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiEditor instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetEditor")]
        internal static extern IntPtr PiPiOperatorGetEditor(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetFiller.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFiller instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetFiller")]
        internal static extern IntPtr PiPiOperatorGetFiller(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetExtractor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiExtractor instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetExtractor")]
        internal static extern IntPtr PiPiOperatorGetPiPiExtractor(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetFontManager.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFontManager instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetFontManager")]
        internal static extern IntPtr PiPiOperatorGetPiPiFontManager(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator Finalize size getter.
        /// </summary>
        /// <param name="output">The c++ finalize binary bytes pointer.</param>
        /// <returns>The finalize binary size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorMeasureFinalize")]
        internal static extern int PiPiOperatorMeasureFinalize(IntPtr output);
    }
}
