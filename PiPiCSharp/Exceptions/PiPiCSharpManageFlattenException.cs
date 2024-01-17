// <copyright file="PiPiCSharpManageFlattenException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The generate PDF appearance exception.
    /// </summary>
    public class PiPiCSharpManageFlattenException : Exception
    {
        /// <summary>
        /// The generate PDF appearance exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpManageFlattenExceptionCode, string> PiPiCSharpManageFlattenExceptionCodeMap = new Dictionary<PiPiCSharpManageFlattenExceptionCode, string>()
        {
            { PiPiCSharpManageFlattenExceptionCode.CreateFormObjectFromAppearanceFail, "Create form object from appearance fail" },
            { PiPiCSharpManageFlattenExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpManageFlattenException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        public PiPiCSharpManageFlattenException(PiPiCSharpManageFlattenExceptionCode code)
            : base(PiPiCSharpManageFlattenExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpManageFlattenException"/> class.
        /// </summary>
        /// <param name="code">The generate PDF appearance exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpManageFlattenException(PiPiCSharpManageFlattenExceptionCode code, Exception innerException)
            : base(PiPiCSharpManageFlattenExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The generate PDF appearance exception code.
        /// </summary>
        public enum PiPiCSharpManageFlattenExceptionCode
        {
            /// <summary>
            /// Create form object from appearance fail.
            /// </summary>
            CreateFormObjectFromAppearanceFail = 1,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets or sets the generate PDF appearance exception code.
        /// </summary>
        public PiPiCSharpManageFlattenExceptionCode Code { get; set; }
    }
}
