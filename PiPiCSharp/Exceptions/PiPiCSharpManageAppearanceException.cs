// <copyright file="PiPiCSharpManageAppearanceException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The generate PDF appearance exception.
    /// </summary>
    public class PiPiCSharpManageAppearanceException : Exception
    {
        /// <summary>
        /// The generate PDF appearance exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpManageAppearanceExceptionCode, string> PiPiCSharpManageAppearanceExceptionCodeMap = new Dictionary<PiPiCSharpManageAppearanceExceptionCode, string>()
        {
            { PiPiCSharpManageAppearanceExceptionCode.UnsupportedFieldType, "Unsupported field type" },
            { PiPiCSharpManageAppearanceExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpManageAppearanceException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        public PiPiCSharpManageAppearanceException(PiPiCSharpManageAppearanceExceptionCode code)
            : base(PiPiCSharpManageAppearanceExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpManageAppearanceException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpManageAppearanceException(PiPiCSharpManageAppearanceExceptionCode code, Exception innerException)
            : base(PiPiCSharpManageAppearanceExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The generate PDF appearance exception code.
        /// </summary>
        public enum PiPiCSharpManageAppearanceExceptionCode
        {
            /// <summary>
            /// Unsupported field type.
            /// </summary>
            UnsupportedFieldType = 1,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the generate PDF appearance exception code.
        /// </summary>
        public PiPiCSharpManageAppearanceExceptionCode Code { get; set; }
    }
}
