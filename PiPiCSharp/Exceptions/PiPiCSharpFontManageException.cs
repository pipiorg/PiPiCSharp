// <copyright file="PiPiCSharpFontManageException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The font manage PDF exception.
    /// </summary>
    public class PiPiCSharpFontManageException : Exception
    {
        /// <summary>
        /// The font manage PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpFontManageExceptionCode, string> PiPiCSharpFontManageExceptionCodeMap = new Dictionary<PiPiCSharpFontManageExceptionCode, string>()
        {
            { PiPiCSharpFontManageExceptionCode.InOperable, "In operable" },
            { PiPiCSharpFontManageExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontManageException"/> class.
        /// </summary>
        /// <param name="code">The font manage PDF exception code.</param>
        public PiPiCSharpFontManageException(PiPiCSharpFontManageExceptionCode code)
            : base(PiPiCSharpFontManageExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontManageException"/> class.
        /// </summary>
        /// <param name="code">The font manage PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpFontManageException(PiPiCSharpFontManageExceptionCode code, Exception innerException)
            : base(PiPiCSharpFontManageExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The font manage PDF exception code.
        /// </summary>
        public enum PiPiCSharpFontManageExceptionCode
        {
            /// <summary>
            /// In operable.
            /// </summary>
            InOperable = 1,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the font manage PDF exception code.
        /// </summary>
        public PiPiCSharpFontManageExceptionCode Code { get; set; }
    }
}
