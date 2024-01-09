// <copyright file="PiPiCSharpOperateException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The operate PDF exception.
    /// </summary>
    public class PiPiCSharpOperateException : Exception
    {
        /// <summary>
        /// The operate PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpOperateExceptionCode, string> PiPiCSharpOperateExceptionCodeMap = new Dictionary<PiPiCSharpOperateExceptionCode, string>()
        {
            { PiPiCSharpOperateExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperateException"/> class.
        /// </summary>
        /// <param name="code">The operate PDF exception code.</param>
        public PiPiCSharpOperateException(PiPiCSharpOperateExceptionCode code)
            : base(PiPiCSharpOperateExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperateException"/> class.
        /// </summary>
        /// <param name="code">The operate PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpOperateException(PiPiCSharpOperateExceptionCode code, Exception innerException)
            : base(PiPiCSharpOperateExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The operate PDF exception code.
        /// </summary>
        public enum PiPiCSharpOperateExceptionCode
        {
            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the operate PDF exception code.
        /// </summary>
        public PiPiCSharpOperateExceptionCode Code { get; set; }
    }
}
