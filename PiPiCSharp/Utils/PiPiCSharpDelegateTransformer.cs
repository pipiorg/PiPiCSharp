// <copyright file="PiPiCSharpDelegateTransformer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Utils
{
    /// <summary>
    /// Partail utils.
    /// </summary>
    internal static class PiPiCSharpDelegateTransformer
    {
        /// <summary>
        /// Partial result with 11 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <typeparam name="T9">The type of argument 9.</typeparam>
        /// <typeparam name="T10">The type of argument 10.</typeparam>
        /// <typeparam name="T11">The type of argument 11.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The argument 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The argument 8.</param>
        /// <param name="arg9">The argument 9.</param>
        /// <param name="arg10">The argument 10.</param>
        /// <param name="arg11">The argument 11.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Partial result with 10 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <typeparam name="T9">The type of argument 9.</typeparam>
        /// <typeparam name="T10">The type of argument 10.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The argument 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The argument 8.</param>
        /// <param name="arg9">The argument 9.</param>
        /// <param name="arg10">The argument 10.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Partial result with 9 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <typeparam name="T9">The type of argument 9.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The argument 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The argument 8.</param>
        /// <param name="arg9">The argument 9.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7, T8, T9> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Partial result with 8 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The argument 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The argument 8.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5, T6, T7, T8>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7, T8> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Partial result with 7 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The argument 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5, T6, T7>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Partial result with 6 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The argument 6.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5, T6>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Partial result with 5 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4, T5>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Partial result with 4 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The argument 4.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3, T4>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Partial result with 3 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2, T3>(PiPiCSharpParamsDelegate<TResult, T1, T2, T3> func, T1 arg1, T2 arg2, T3 arg3)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3);
        }

        /// <summary>
        /// Partial result with 2 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The argument 2.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1, T2>(PiPiCSharpParamsDelegate<TResult, T1, T2> func, T1 arg1, T2 arg2)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2);
        }

        /// <summary>
        /// Partial result with 1 arguments.
        /// </summary>
        /// <typeparam name="TResult">The type of result.</typeparam>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpResultDelegate<TResult> TransformParamsToResult<TResult, T1>(PiPiCSharpParamsDelegate<TResult, T1> func, T1 arg1)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1);
        }

        /// <summary>
        /// Partial void result with 11 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <typeparam name="T9">The type of argument 9.</typeparam>
        /// <typeparam name="T10">The type of argument 10.</typeparam>
        /// <typeparam name="T11">The type of argument 11.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The arguemnt 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The arguemnt 8.</param>
        /// <param name="arg9">The arguemnt 9.</param>
        /// <param name="arg10">The argument 10.</param>
        /// <param name="arg11">The arguemnt 11.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Partial void result with 10 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <typeparam name="T9">The type of argument 9.</typeparam>
        /// <typeparam name="T10">The type of argument 10.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The arguemnt 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The arguemnt 8.</param>
        /// <param name="arg9">The arguemnt 9.</param>
        /// <param name="arg10">The argument 10.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Partial void result with 9 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <typeparam name="T9">The type of argument 9.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The arguemnt 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The arguemnt 8.</param>
        /// <param name="arg9">The arguemnt 9.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5, T6, T7, T8, T9>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7, T8, T9> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Partial void result with 8 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <typeparam name="T8">The type of argument 8.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The arguemnt 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <param name="arg8">The arguemnt 8.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5, T6, T7, T8>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7, T8> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Partial void result with 7 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <typeparam name="T7">The type of argument 7.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The arguemnt 6.</param>
        /// <param name="arg7">The argument 7.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5, T6, T7>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Partial void result with 6 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <typeparam name="T6">The type of argument 6.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <param name="arg6">The arguemnt 6.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5, T6>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Partial void result with 5 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <typeparam name="T5">The type of argument 5.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <param name="arg5">The argument 5.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4, T5>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Partial void result with 4 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <typeparam name="T4">The type of argument 4.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <param name="arg4">The arguemnt 4.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3, T4>(PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Partial void result with 3 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <typeparam name="T3">The type of argument 3.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <param name="arg3">The argument 3.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2, T3>(PiPiCSharpVoidParamsDelegate<T1, T2, T3> func, T1 arg1, T2 arg2, T3 arg3)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2, arg3);
        }

        /// <summary>
        /// Partial void result with 2 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <typeparam name="T2">The type of argument 2.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <param name="arg2">The arguemnt 2.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1, T2>(PiPiCSharpVoidParamsDelegate<T1, T2> func, T1 arg1, T2 arg2)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1, arg2);
        }

        /// <summary>
        /// Partial void result with 1 arguments.
        /// </summary>
        /// <typeparam name="T1">The type of argument 1.</typeparam>
        /// <param name="func">The function.</param>
        /// <param name="arg1">The argument 1.</param>
        /// <returns>The result delegate.</returns>
        internal static PiPiCSharpVoidResultDelegate TransformParamsToVoidResult<T1>(PiPiCSharpVoidParamsDelegate<T1> func, T1 arg1)
        {
            return (ref int code, ref int exCode, ref int exSubCode) => func(ref code, ref exCode, ref exSubCode, arg1);
        }
    }
}
