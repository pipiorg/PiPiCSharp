// <copyright file="PiPiCSharpFillFieldException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The fill PDF field exception.
    /// </summary>
    public class PiPiCSharpFillFieldException : Exception
    {
        /// <summary>
        /// The fill PDF field exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpFillFieldExceptionCode, string> PiPiCSharpFillFieldExceptionCodeMap = new Dictionary<PiPiCSharpFillFieldExceptionCode, string>()
        {
            { PiPiCSharpFillFieldExceptionCode.InOperable, "In operable" },
            { PiPiCSharpFillFieldExceptionCode.UnsupportedPdfFieldType, "Unsupported PDF field type" },
            { PiPiCSharpFillFieldExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFillFieldException"/> class.
        /// </summary>
        /// <param name="code">The fill PDF field exception code.</param>
        public PiPiCSharpFillFieldException(PiPiCSharpFillFieldExceptionCode code)
            : base(PiPiCSharpFillFieldExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFillFieldException"/> class.
        /// </summary>
        /// <param name="code">The fill PDF field exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpFillFieldException(PiPiCSharpFillFieldExceptionCode code, Exception innerException)
            : base(PiPiCSharpFillFieldExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The fill PDF field exception code.
        /// </summary>
        public enum PiPiCSharpFillFieldExceptionCode
        {
            /// <summary>
            /// In operable.
            /// </summary>
            InOperable = 1,

            /// <summary>
            /// Unsupported PDF field type.
            /// </summary>
            UnsupportedPdfFieldType = 2,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the fill PDF field exception code.
        /// </summary>
        public PiPiCSharpFillFieldExceptionCode Code { get; set; }
    }
}
