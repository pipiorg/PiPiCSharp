// <copyright file="PiPiCSharpFontManageInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiFontManageWrapper.
    /// </summary>
    internal static class PiPiCSharpFontManageInvoker
    {
        /// <summary>
        /// Invoke PiPiFontManageWrapper DeletePiPiFontManager.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        internal static void InvokeDeletePiPiFontManager(IntPtr cFontManager)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFontManageWrapper.DeletePiPiFontManager, cFontManager);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontManageWrapper PiPiFontManagerIsOperable.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool InvokePiPiFontManagerIsOperable(IntPtr cFontManager)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiFontManageWrapper.PiPiFontManagerIsOperable, cFontManager);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontManageWrapper PiPiFontManagerRegisterFont.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        /// <returns>The registered font name.</returns>
        internal static IntPtr InvokePiPiFontManagerRegisterFont(IntPtr cFontManager, byte[] fontBytes, uint fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiFontManageWrapper.PiPiFontManagerRegisterFont, cFontManager, fontBytes, fontSize);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
