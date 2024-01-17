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
        internal const string DllName = "PiPiCSharpWrapper";

        /// <summary>
        /// The field type map.
        /// </summary>
        internal static readonly Dictionary<uint, PiPiCSharpFieldType> FieldTypeInvertMap = new Dictionary<uint, PiPiCSharpFieldType>()
        {
            { 0, PiPiCSharpFieldType.TextBox },
            { 1, PiPiCSharpFieldType.CheckBox },
            { 2, PiPiCSharpFieldType.Unknown },
        };

        /// <summary>
        /// The field type map.
        /// </summary>
        internal static readonly Dictionary<PiPiCSharpFieldType, uint> FieldTypeMap = new Dictionary<PiPiCSharpFieldType, uint>()
        {
            { PiPiCSharpFieldType.TextBox, 0 },
            { PiPiCSharpFieldType.CheckBox, 1 },
            { PiPiCSharpFieldType.Unknown, 2 },
        };

        /// <summary>
        /// The text horizontal alignment invert map.
        /// </summary>
        internal static readonly Dictionary<uint, PiPiCSharpTextHorizontalAlignment> TextHorizontalAlignmentInvertMap = new Dictionary<uint, PiPiCSharpTextHorizontalAlignment>()
        {
            { 0, PiPiCSharpTextHorizontalAlignment.Left },
            { 1, PiPiCSharpTextHorizontalAlignment.Center },
            { 2, PiPiCSharpTextHorizontalAlignment.Right },
        };

        /// <summary>
        /// The text horizontal alignment map.
        /// </summary>
        internal static readonly Dictionary<PiPiCSharpTextHorizontalAlignment, uint> TextHorizontalAlignmentMap = new Dictionary<PiPiCSharpTextHorizontalAlignment, uint>()
        {
            { PiPiCSharpTextHorizontalAlignment.Left, 0 },
            { PiPiCSharpTextHorizontalAlignment.Center, 1 },
            { PiPiCSharpTextHorizontalAlignment.Right, 2 },
        };
    }
}
