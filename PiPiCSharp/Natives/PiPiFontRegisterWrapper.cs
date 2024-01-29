// <copyright file="PiPiFontRegisterWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Natives
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiFontRegister.
    /// </summary>
    internal static class PiPiFontRegisterWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiFontRegister destructor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cFontRegister">PiPiFontRegister instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiFontRegister")]
        internal static extern void DeletePiPiFontRegister(ref int code, ref int exCode, ref int exSubCode, IntPtr cFontRegister);

        /// <summary>
        /// Invoke c++ PiPiFontRegister IsOperable.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cFontRegister">PiPiFontRegister instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontRegisterIsOperable")]
        internal static extern bool PiPiFontRegisterIsOperable(ref int code, ref int exCode, ref int exSubCode, IntPtr cFontRegister);

        /// <summary>
        /// Invoke c++ PiPiFontRegister RegisterFont.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cFontRegister">PiPiFontRegister instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        /// <returns>The registered font name.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontRegisterRegisterFont")]
        internal static extern IntPtr PiPiFontRegisterRegisterFont(ref int code, ref int exCode, ref int exSubCode, IntPtr cFontRegister, byte[] fontBytes, uint fontSize);
    }
}
