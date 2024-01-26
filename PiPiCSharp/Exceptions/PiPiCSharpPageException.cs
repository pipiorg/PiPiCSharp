// <copyright file="PiPiCSharpPageException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The page PDF exception.
    /// </summary>
    public class PiPiCSharpPageException : Exception
    {
        /// <summary>
        /// The page PDF exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpPageExceptionCode, string> PiPiCSharpEditExceptionCodeMap = new Dictionary<PiPiCSharpPageExceptionCode, string>()
        {
            { PiPiCSharpPageExceptionCode.InOperable, "In operable" },
            { PiPiCSharpPageExceptionCode.InvalidSplitInstruction, "Invalid split instruction" },
            { PiPiCSharpPageExceptionCode.IndexOutOfRange, "Index out of range" },
            { PiPiCSharpPageExceptionCode.MergeFieldConflict, "Merge field conflict" },
            { PiPiCSharpPageExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpPageException"/> class.
        /// </summary>
        /// <param name="code">The page PDF exception code.</param>
        public PiPiCSharpPageException(PiPiCSharpPageExceptionCode code)
            : base(PiPiCSharpEditExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpPageException"/> class.
        /// </summary>
        /// <param name="code">The page PDF exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpPageException(PiPiCSharpPageExceptionCode code, Exception innerException)
            : base(PiPiCSharpEditExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The page PDF exception code.
        /// </summary>
        public enum PiPiCSharpPageExceptionCode
        {
            /// <summary>
            /// In operable.
            /// </summary>
            InOperable = 1,

            /// <summary>
            /// Invalid split instruction.
            /// </summary>
            InvalidSplitInstruction = 2,

            /// <summary>
            /// Index out of range.
            /// </summary>
            IndexOutOfRange = 3,

            /// <summary>
            /// Merge field conflict
            /// </summary>
            MergeFieldConflict = 4,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets the page PDF exception code.
        /// </summary>
        public PiPiCSharpPageExceptionCode Code { get; private set; }
    }
}
