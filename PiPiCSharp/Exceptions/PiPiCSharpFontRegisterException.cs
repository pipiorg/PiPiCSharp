// <copyright file="PiPiCSharpFontRegisterException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The font manage PDF exception.
    /// </summary>
    public class PiPiCSharpFontRegisterException : Exception
    {
        /// <summary>
        /// The font manage PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpFontRegisterExceptionCode, string> PiPiCSharpFontRegisterExceptionCodeMap = new Dictionary<PiPiCSharpFontRegisterExceptionCode, string>()
        {
            { PiPiCSharpFontRegisterExceptionCode.InOperable, "In operable" },
            { PiPiCSharpFontRegisterExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontRegisterException"/> class.
        /// </summary>
        /// <param name="code">The font manage PDF exception code.</param>
        public PiPiCSharpFontRegisterException(PiPiCSharpFontRegisterExceptionCode code)
            : base(PiPiCSharpFontRegisterExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontRegisterException"/> class.
        /// </summary>
        /// <param name="code">The font manage PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpFontRegisterException(PiPiCSharpFontRegisterExceptionCode code, Exception innerException)
            : base(PiPiCSharpFontRegisterExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The font manage PDF exception code.
        /// </summary>
        public enum PiPiCSharpFontRegisterExceptionCode
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
        /// Gets the font manage PDF exception code.
        /// </summary>
        public PiPiCSharpFontRegisterExceptionCode Code { get; private set; }
    }
}
