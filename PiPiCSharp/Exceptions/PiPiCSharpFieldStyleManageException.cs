// <copyright file="PiPiCSharpManageFieldStyleException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The generate PDF appearance exception.
    /// </summary>
    public class PiPiCSharpFieldStyleManageException : Exception
    {
        /// <summary>
        /// The generate PDF appearance exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpFieldStyleManageExceptionCode, string> PiPiCSharpFieldStyleManageExceptionCodeMap = new Dictionary<PiPiCSharpFieldStyleManageExceptionCode, string>()
        {
            { PiPiCSharpFieldStyleManageExceptionCode.NotRegisterFont, "Not register font" },
            { PiPiCSharpFieldStyleManageExceptionCode.InvalidColor, "Invalid color" },
            { PiPiCSharpFieldStyleManageExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFieldStyleManageException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        public PiPiCSharpFieldStyleManageException(PiPiCSharpFieldStyleManageExceptionCode code)
            : base(PiPiCSharpFieldStyleManageExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFieldStyleManageException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpFieldStyleManageException(PiPiCSharpFieldStyleManageExceptionCode code, Exception innerException)
            : base(PiPiCSharpFieldStyleManageExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The generate PDF appearance exception code.
        /// </summary>
        public enum PiPiCSharpFieldStyleManageExceptionCode
        {
            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// Multiline not supported.
            /// </summary>
            MultilineNotSupported = 1,

            /// <summary>
            /// Not register font.
            /// </summary>
            NotRegisterFont = 2,

            /// <summary>
            /// Invalid color.
            /// </summary>
            InvalidColor = 3,
        }

        /// <summary>
        /// Gets or sets the generate PDF appearance exception code.
        /// </summary>
        public PiPiCSharpFieldStyleManageExceptionCode Code { get; set; }
    }
}
