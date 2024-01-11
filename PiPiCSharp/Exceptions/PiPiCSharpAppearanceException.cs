// <copyright file="PiPiCSharpAppearanceException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The generate PDF appearance exception.
    /// </summary>
    public class PiPiCSharpAppearanceException : Exception
    {
        /// <summary>
        /// The generate PDF appearance exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpAppearanceExceptionCode, string> PiPiCSharpAppearanceExceptionCodeMap = new Dictionary<PiPiCSharpAppearanceExceptionCode, string>()
        {
            { PiPiCSharpAppearanceExceptionCode.CreateFormObjectFromAppearanceFail, "Create form object from appearance fail" },
            { PiPiCSharpAppearanceExceptionCode.UnsupportedFieldType, "Unsupported field type" },
            { PiPiCSharpAppearanceExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpAppearanceException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        public PiPiCSharpAppearanceException(PiPiCSharpAppearanceExceptionCode code)
            : base(PiPiCSharpAppearanceExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpAppearanceException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpAppearanceException(PiPiCSharpAppearanceExceptionCode code, Exception innerException)
            : base(PiPiCSharpAppearanceExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The generate PDF appearance exception code.
        /// </summary>
        public enum PiPiCSharpAppearanceExceptionCode
        {
            /// <summary>
            /// Create form object from appearance fail.
            /// </summary>
            CreateFormObjectFromAppearanceFail = 0,

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
        public PiPiCSharpAppearanceExceptionCode Code { get; set; }
    }
}
