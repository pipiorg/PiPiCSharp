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
            try
            {
                int code = 0;
                int exCode = -1;
                int exSubCode = -1;

                func(ref code, ref exCode, ref exSubCode);

                if (code != 0)
                {
                    return;
                }

                switch (exCode)
                {
                    default:
                        throw new PiPiCSharpUnknownException("Unknown exception");
                }
            }
            catch (Exception e)
            {
                throw new PiPiCSharpUnknownException("Unknown exception", e);
            }
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
            try
            {
                int code = 0;
                int exCode = -1;
                int exSubCode = -1;

                TResult result = func(ref code, ref exCode, ref exSubCode);

                if (code != 0)
                {
                    return result;
                }

                switch (exCode)
                {
                    default:
                        throw new PiPiCSharpUnknownException("Unknown exception");
                }
            }
            catch (Exception e)
            {
                throw new PiPiCSharpUnknownException("Unknown exception", e);
            }
        }
    }
}
