// <copyright file="PiPiCSharpFontManageWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Wrapper for PiPiFontManageWrapper.
    /// </summary>
    internal static class PiPiCSharpFontManageWrapper
    {
        /// <summary>
        /// Invoke PiPiFontManageWrapper DeletePiPiFontManager.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        internal static void DeletePiPiFontManager(IntPtr cFontManager)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult<IntPtr>(PiPiFontManageWrapper.DeletePiPiFontManager, cFontManager);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontManageWrapper PiPiFontManagerIsOperable.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool PiPiFontManagerIsOperable(IntPtr cFontManager)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<bool, IntPtr>(PiPiFontManageWrapper.PiPiFontManagerIsOperable, cFontManager);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontManageWrapper PiPiFontManagerRegisterFont.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        /// <returns>The registered font name.</returns>
        internal static IntPtr PiPiFontManagerRegisterFont(IntPtr cFontManager, byte[] fontBytes, int fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult<IntPtr, IntPtr, byte[], int>(PiPiFontManageWrapper.PiPiFontManagerRegisterFont, cFontManager, fontBytes, fontSize);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
