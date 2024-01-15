// <copyright file="PiPiCSharpEditFieldException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The edit PDF field exception.
    /// </summary>
    public class PiPiCSharpEditFieldException : Exception
    {
        /// <summary>
        /// The edit PDF field exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpEditFieldExceptionCode, string> PiPiCSharpEditFieldExceptionCodeMap = new Dictionary<PiPiCSharpEditFieldExceptionCode, string>()
        {
            { PiPiCSharpEditFieldExceptionCode.InOperable, "In operable." },
            { PiPiCSharpEditFieldExceptionCode.NotImplementate, "Not implementate" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditFieldException"/> class.
        /// </summary>
        /// <param name="code">The edit PDF field exception code.</param>
        public PiPiCSharpEditFieldException(PiPiCSharpEditFieldExceptionCode code)
            : base(PiPiCSharpEditFieldExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditFieldException"/> class.
        /// </summary>
        /// <param name="code">The edit PDF field exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpEditFieldException(PiPiCSharpEditFieldExceptionCode code, Exception innerException)
            : base(PiPiCSharpEditFieldExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The edit PDF field exception code.
        /// </summary>
        public enum PiPiCSharpEditFieldExceptionCode
        {
            /// <summary>
            /// In operable.
            /// </summary>
            InOperable = 1,

            /// <summary>
            /// Not implementate.
            /// </summary>
            NotImplementate = 2,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the edit PDF field exception code.
        /// </summary>
        public PiPiCSharpEditFieldExceptionCode Code { get; set; }
    }
}
