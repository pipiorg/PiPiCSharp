// <copyright file="PiPiCSharpDelegate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Utils
{
    /// <summary>
    /// Params delegate with 8 arguments.
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
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <param name="arg6">argument 6.</param>
    /// <param name="arg7">argument 7.</param>
    /// <param name="arg8">argument 8.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7, T8>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

    /// <summary>
    /// Params delegate with 7 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <typeparam name="T6">The type of argument 6.</typeparam>
    /// <typeparam name="T7">The type of argument 7.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <param name="arg6">argument 6.</param>
    /// <param name="arg7">argument 7.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6, T7>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    /// <summary>
    /// Params delegate with 6 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <typeparam name="T6">The type of argument 6.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <param name="arg6">argument 6.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5, T6>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    /// <summary>
    /// Params delegate with 5 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4, T5>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    /// <summary>
    /// Params delegate with 4 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2, T3, T4>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    /// <summary>
    /// Params delegate with 3 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2, T3>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3);

    /// <summary>
    /// Params delegate with 2 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1, T2>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2);

    /// <summary>
    /// Params delegate with 1 arguments.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpParamsDelegate<TResult, T1>(ref int code, ref int exCode, ref int exSubCode, T1 arg1);

    /// <summary>
    /// Result delegate.
    /// </summary>
    /// <typeparam name="TResult">The type of result.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <returns>The result.</returns>
    internal delegate TResult PiPiCSharpResultDelegate<TResult>(ref int code, ref int exCode, ref int exSubCode);

    /// <summary>
    /// Void params delegate with 8 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <typeparam name="T6">The type of argument 6.</typeparam>
    /// <typeparam name="T7">The type of argument 7.</typeparam>
    /// <typeparam name="T8">The type of argument 8.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <param name="arg6">argument 6.</param>
    /// <param name="arg7">argument 7.</param>
    /// <param name="arg8">argument 8.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7, T8>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

    /// <summary>
    /// Void params delegate with 7 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <typeparam name="T6">The type of argument 6.</typeparam>
    /// <typeparam name="T7">The type of argument 7.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <param name="arg6">argument 6.</param>
    /// <param name="arg7">argument 7.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6, T7>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    /// <summary>
    /// Void params delegate with 6 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <typeparam name="T6">The type of argument 6.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    /// <param name="arg6">argument 6.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5, T6>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    /// <summary>
    /// Void params delegate with 5 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <typeparam name="T5">The type of argument 5.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    /// <param name="arg5">argument 5.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4, T5>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    /// <summary>
    /// Void params delegate with 4 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <typeparam name="T4">The type of argument 4.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    /// <param name="arg4">argument 4.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2, T3, T4>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    /// <summary>
    /// Void params delegate with 3 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <typeparam name="T3">The type of argument 3.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    /// <param name="arg3">argument 3.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2, T3>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2, T3 arg3);

    /// <summary>
    /// Void params delegate with 2 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <typeparam name="T2">The type of argument 2.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    /// <param name="arg2">argument 2.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1, T2>(ref int code, ref int exCode, ref int exSubCode, T1 arg1, T2 arg2);

    /// <summary>
    /// Void params delegate with 1 arguments.
    /// </summary>
    /// <typeparam name="T1">The type of argument 1.</typeparam>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    /// <param name="arg1">argument 1.</param>
    internal delegate void PiPiCSharpVoidParamsDelegate<T1>(ref int code, ref int exCode, ref int exSubCode, T1 arg1);

    /// <summary>
    /// Void result delegate.
    /// </summary>
    /// <param name="code">The return code.</param>
    /// <param name="exCode">The exception code.</param>
    /// <param name="exSubCode">The exception sub code.</param>
    internal delegate void PiPiCSharpVoidResultDelegate(ref int code, ref int exCode, ref int exSubCode);
}
