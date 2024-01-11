// <copyright file="PiPiCSharpFieldCompatibilityException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The patch field compatibility exception.
    /// </summary>
    public class PiPiCSharpFieldCompatibilityException : Exception
    {
        /// <summary>
        /// The patch field compatibility exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpFieldCompatibilityExceptionCode, string> PiPiCSharpFieldCompatibilityExceptionCodeMap = new Dictionary<PiPiCSharpFieldCompatibilityExceptionCode, string>()
        {
            { PiPiCSharpFieldCompatibilityExceptionCode.FixDotFieldFail, "Fix dot field fail" },
            { PiPiCSharpFieldCompatibilityExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFieldCompatibilityException"/> class.
        /// </summary>
        /// <param name="code">The patch field compatibility exception code.</param>
        public PiPiCSharpFieldCompatibilityException(PiPiCSharpFieldCompatibilityExceptionCode code)
            : base(PiPiCSharpFieldCompatibilityExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFieldCompatibilityException"/> class.
        /// </summary>
        /// <param name="code">The patch field compatibility exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpFieldCompatibilityException(PiPiCSharpFieldCompatibilityExceptionCode code, Exception innerException)
            : base(PiPiCSharpFieldCompatibilityExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The patch field compatibility exception code.
        /// </summary>
        public enum PiPiCSharpFieldCompatibilityExceptionCode
        {
            /// <summary>
            /// Fix dot field fail.
            /// </summary>
            FixDotFieldFail = 1,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the patch field compatibility exception code.
        /// </summary>
        public PiPiCSharpFieldCompatibilityExceptionCode Code { get; set; }
    }
}
