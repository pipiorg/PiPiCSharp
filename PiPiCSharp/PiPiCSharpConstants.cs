// <copyright file="PiPiCSharpConstants.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Contants.
    /// </summary>
    internal static class PiPiCSharpConstants
    {
        /// <summary>
        /// The pipi dll calling convention define.
        /// </summary>
        internal const CallingConvention CC = CallingConvention.Cdecl;

        /// <summary>
        /// The pipi dll char set define.
        /// </summary>
        internal const CharSet CS = CharSet.Unicode;

        /// <summary>
        /// The pipi dll name define.
        /// </summary>
        internal const string DllName = "PiPiCSharpWrapper.dll";
    }
}
