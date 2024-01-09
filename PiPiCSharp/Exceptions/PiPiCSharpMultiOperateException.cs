// <copyright file="PiPiCSharpMultiOperateException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The multi operate PDF exception.
    /// </summary>
    public class PiPiCSharpMultiOperateException : Exception
    {
        /// <summary>
        /// The multi operate PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpEditExceptionCode, string> PiPiCSharpEditExceptionCodeMap = new Dictionary<PiPiCSharpEditExceptionCode, string>()
        {
            { PiPiCSharpEditExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpMultiOperateException"/> class.
        /// </summary>
        /// <param name="code">The multi operate PDF exception code.</param>
        public PiPiCSharpMultiOperateException(PiPiCSharpEditExceptionCode code)
            : base(PiPiCSharpEditExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpMultiOperateException"/> class.
        /// </summary>
        /// <param name="code">The multi operate PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpMultiOperateException(PiPiCSharpEditExceptionCode code, Exception innerException)
            : base(PiPiCSharpEditExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The multi operate PDF exception code.
        /// </summary>
        public enum PiPiCSharpEditExceptionCode
        {
            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the multi operate PDF exception code.
        /// </summary>
        public PiPiCSharpEditExceptionCode Code { get; set; }
    }
}
