// <copyright file="PiPiFontManageWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
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
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiFontManager")]
        internal static extern void DeletePiPiFontManager(IntPtr cFontManager);

        /// <summary>
        /// Invoke c++ PiPiFontManager IsOperable.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontManagerIsOperable")]
        internal static extern bool PiPiFontManagerIsOperable(IntPtr cFontManager);

        /// <summary>
        /// Invoke c++ PiPiFontManager RegisterFont.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontManagerRegisterFont")]
        internal static extern void PiPiFontManagerRegisterFont(IntPtr cFontManager, byte[] fontBytes, int fontSize);

    }
}
