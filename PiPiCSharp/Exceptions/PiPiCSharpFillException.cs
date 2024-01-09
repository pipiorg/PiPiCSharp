// <copyright file="PiPiCSharpFillException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The fill PDF exception.
    /// </summary>
    public class PiPiCSharpFillException : Exception
    {
        /// <summary>
        /// The fill PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpFillExceptionCode, string> PiPiCSharpFillExceptionCodeMap = new Dictionary<PiPiCSharpFillExceptionCode, string>()
        {
            { PiPiCSharpFillExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFillException"/> class.
        /// </summary>
        /// <param name="code">The fill PDF exception code.</param>
        public PiPiCSharpFillException(PiPiCSharpFillExceptionCode code)
            : base(PiPiCSharpFillExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFillException"/> class.
        /// </summary>
        /// <param name="code">The fill PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpFillException(PiPiCSharpFillExceptionCode code, Exception innerException)
            : base(PiPiCSharpFillExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The fill PDF exception code.
        /// </summary>
        public enum PiPiCSharpFillExceptionCode
        {
            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the fill PDF exception code.
        /// </summary>
        public PiPiCSharpFillExceptionCode Code { get; set; }
    }
}
