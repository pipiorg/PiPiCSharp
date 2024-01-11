// <copyright file="PiPiCSharpExtractException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The extract PDF exception.
    /// </summary>
    public class PiPiCSharpExtractException : Exception
    {
        /// <summary>
        /// The extract PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpExtractExceptionCode, string> PiPiCSharpExtractExceptionCodeMap = new Dictionary<PiPiCSharpExtractExceptionCode, string>()
        {
            { PiPiCSharpExtractExceptionCode.InOperable, "In operate" },
            { PiPiCSharpExtractExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpExtractException"/> class.
        /// </summary>
        /// <param name="code">The extract PDF exception code.</param>
        public PiPiCSharpExtractException(PiPiCSharpExtractExceptionCode code)
            : base(PiPiCSharpExtractExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpExtractException"/> class.
        /// </summary>
        /// <param name="code">The extract PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpExtractException(PiPiCSharpExtractExceptionCode code, Exception innerException)
            : base(PiPiCSharpExtractExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The extract PDF exception code.
        /// </summary>
        public enum PiPiCSharpExtractExceptionCode
        {
            /// <summary>
            /// In operate.
            /// </summary>
            InOperable = 1,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the extract PDF exception code.
        /// </summary>
        public PiPiCSharpExtractExceptionCode Code { get; set; }
    }
}
