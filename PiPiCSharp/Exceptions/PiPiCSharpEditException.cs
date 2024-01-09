// <copyright file="PiPiCSharpEditException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The edit PDF exception.
    /// </summary>
    public class PiPiCSharpEditException : Exception
    {
        /// <summary>
        /// The edit PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpEditExceptionCode, string> PiPiCSharpEditExceptionCodeMap = new Dictionary<PiPiCSharpEditExceptionCode, string>()
        {
            { PiPiCSharpEditExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditException"/> class.
        /// </summary>
        /// <param name="code">The edit PDF exception code.</param>
        public PiPiCSharpEditException(PiPiCSharpEditExceptionCode code)
            : base(PiPiCSharpEditExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditException"/> class.
        /// </summary>
        /// <param name="code">The edit PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpEditException(PiPiCSharpEditExceptionCode code, Exception innerException)
            : base(PiPiCSharpEditExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The edit PDF exception code.
        /// </summary>
        public enum PiPiCSharpEditExceptionCode
        {
            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the edit PDF exception code.
        /// </summary>
        public PiPiCSharpEditExceptionCode Code { get; set; }
    }
}
