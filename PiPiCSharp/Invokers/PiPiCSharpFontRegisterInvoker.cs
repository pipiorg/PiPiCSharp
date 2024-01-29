// <copyright file="PiPiCSharpFontRegisterInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiFontRegisterWrapper.
    /// </summary>
    internal static class PiPiCSharpFontRegisterInvoker
    {
        /// <summary>
        /// Invoke PiPiFontRegisterWrapper DeletePiPiFontRegister.
        /// </summary>
        /// <param name="cFontRegister">PiPiFontRegister instance pointer.</param>
        internal static void InvokeDeletePiPiFontRegister(IntPtr cFontRegister)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFontRegisterWrapper.DeletePiPiFontRegister, cFontRegister);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontRegisterWrapper DeletePiPiFontRegisterFontName.
        /// </summary>
        /// <param name="cFontName">Registered font name.</param>
        internal static void InvokeDeletePiPiFontRegisterFontName(IntPtr cFontName)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiFontRegisterWrapper.DeletePiPiFontRegisterFontName, cFontName);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontRegisterWrapper PiPiFontRegisterIsOperable.
        /// </summary>
        /// <param name="cFontRegister">PiPiFontRegister instance pointer.</param>
        /// <returns>The operable status.</returns>
        internal static bool InvokePiPiFontRegisterIsOperable(IntPtr cFontRegister)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiFontRegisterWrapper.PiPiFontRegisterIsOperable, cFontRegister);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiFontRegisterWrapper PiPiFontRegisterRegisterFont.
        /// </summary>
        /// <param name="cFontRegister">PiPiFontRegister instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        /// <returns>The registered font name.</returns>
        internal static IntPtr InvokePiPiFontRegisterRegisterFont(IntPtr cFontRegister, byte[] fontBytes, uint fontSize)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiFontRegisterWrapper.PiPiFontRegisterRegisterFont, cFontRegister, fontBytes, fontSize);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
