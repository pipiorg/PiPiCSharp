// <copyright file="PiPiCSharpConstants.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System.Collections.Generic;
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

        /// <summary>
        /// The field type map.
        /// </summary>
        internal static readonly Dictionary<PiPiCSharpFieldType, ushort> FieldTypeMap = new Dictionary<PiPiCSharpFieldType, ushort>()
        {
            { PiPiCSharpFieldType.TextBox, 0 },
            { PiPiCSharpFieldType.CheckBox, 1 },
            { PiPiCSharpFieldType.Unknown, 2 },
        };

        /// <summary>
        /// The text horizontal alignment map.
        /// </summary>
        internal static readonly Dictionary<PiPiCSharpTextHorizontalAlignment, ushort> TextHorizontalAlignmentMap = new Dictionary<PiPiCSharpTextHorizontalAlignment, ushort>()
        {
            { PiPiCSharpTextHorizontalAlignment.Left, 0 },
            { PiPiCSharpTextHorizontalAlignment.Center, 1 },
            { PiPiCSharpTextHorizontalAlignment.Right, 2 },
        };
    }
}
