// <copyright file="PiPiCSharpDelegateInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Utils
{
    using System;
    using PiPiCSharp.Exceptions;

    /// <summary>
    /// Delegate invoker.
    /// </summary>
    internal static class PiPiCSharpDelegateInvoker
    {
        /// <summary>
        /// Invoke void result delegate.
        /// </summary>
        /// <param name="func">The result delegate.</param>
        /// <exception cref="PiPiCSharpUnknownException">The unknown exception.</exception>
        internal static void Invoke(PiPiCSharpVoidResultDelegate func)
        {
            int code = 0;
            int exCode = -1;
            int exSubCode = -1;

            try
            {
                func(ref code, ref exCode, ref exSubCode);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpUnknownException("Unknown exception", e);
            }

            PiPiCSharpExceptionDispatcher.Dispatch(code, exCode, exSubCode);
        }

        /// <summary>
        /// Invoke result delegate.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <param name="func">The result delegate.</param>
        /// <returns>The return value of the result delegate.</returns>
        /// <exception cref="PiPiCSharpUnknownException">The unknown exception.</exception>
        internal static TResult Invoke<TResult>(PiPiCSharpResultDelegate<TResult> func)
        {
            int code = 0;
            int exCode = -1;
            int exSubCode = -1;

            TResult result;

            try
            {
                result = func(ref code, ref exCode, ref exSubCode);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpUnknownException("Unknown exception", e);
            }

            PiPiCSharpExceptionDispatcher.Dispatch(code, exCode, exSubCode);

            return result;
        }
    }
}
