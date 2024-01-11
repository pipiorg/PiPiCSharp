// <copyright file="PiPiFontManageWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Natives
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiFontManager.
    /// </summary>
    internal static class PiPiFontManageWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiFontManager destructor.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiFontManager")]
        internal static extern void DeletePiPiFontManager(ref int code, ref int exCode, ref int exSubCode, IntPtr cFontManager);

        /// <summary>
        /// Invoke c++ PiPiFontManager IsOperable.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontManagerIsOperable")]
        internal static extern bool PiPiFontManagerIsOperable(ref int code, ref int exCode, ref int exSubCode, IntPtr cFontManager);

        /// <summary>
        /// Invoke c++ PiPiFontManager RegisterFont.
        /// </summary>
        /// <param name="code">Return code.</param>
        /// <param name="exCode">Return ex code.</param>
        /// <param name="exSubCode">Return ex sub code.</param>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        /// <returns>The registered font name.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontManagerRegisterFont")]
        internal static extern IntPtr PiPiFontManagerRegisterFont(ref int code, ref int exCode, ref int exSubCode, IntPtr cFontManager, byte[] fontBytes, uint fontSize);
    }
}
