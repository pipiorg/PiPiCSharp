// <copyright file="PiPiCSharpManageFieldException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Exceptions
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The manage PDF field exception.
    /// </summary>
    public class PiPiCSharpManageFieldException : Exception
    {
        /// <summary>
        /// The manage PDF field exception code map.
        /// </summary>
        public static readonly Dictionary<PiPiCSharpManageExceptionCode, string> PiPiCSharpManageExceptionCodeMap = new Dictionary<PiPiCSharpManageExceptionCode, string>()
        {
            { PiPiCSharpManageExceptionCode.InvalidPdfFieldType, "Invalid PDF field type" },
            { PiPiCSharpManageExceptionCode.InvalidRestrictFieldOperation, "Invalid restrict field operation" },
            { PiPiCSharpManageExceptionCode.InvalidRealStatus, "Invalid real status" },
            { PiPiCSharpManageExceptionCode.InvalidPageIndex, "Invalid page index" },
            { PiPiCSharpManageExceptionCode.DuplicateFieldExists, "Duplicate field exists" },
            { PiPiCSharpManageExceptionCode.UnsupportRemoveFakeField, "Unsupport remove fake field" },
            { PiPiCSharpManageExceptionCode.UnsupportRenameFakeField, "Unsupport rename fake field" },
            { PiPiCSharpManageExceptionCode.InvalidPdfFieldObject, "Invalid PDF field object" },
            { PiPiCSharpManageExceptionCode.Unknown, "Unknown error" },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpManageFieldException"/> class.
        /// </summary>
        /// <param name="code">The manage PDF field exception code.</param>
        public PiPiCSharpManageFieldException(PiPiCSharpManageExceptionCode code)
            : base(PiPiCSharpManageExceptionCodeMap[code])
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpManageFieldException"/> class.
        /// </summary>
        /// <param name="code">The manage PDF field exception code.</param>
        /// <param name="innerException">The inner exception.</param>
        public PiPiCSharpManageFieldException(PiPiCSharpManageExceptionCode code, Exception innerException)
            : base(PiPiCSharpManageExceptionCodeMap[code], innerException)
        {
            this.Code = code;
        }

        /// <summary>
        /// The manage PDF field exception code.
        /// </summary>
        public enum PiPiCSharpManageExceptionCode
        {
            /// <summary>
            /// Invalid PDF field type.
            /// </summary>
            InvalidPdfFieldType = 1,

            /// <summary>
            /// Invalid restrict field operation.
            /// </summary>
            InvalidRestrictFieldOperation = 2,

            /// <summary>
            /// Invalid real status.
            /// </summary>
            InvalidRealStatus = 3,

            /// <summary>
            /// Invalid page index.
            /// </summary>
            InvalidPageIndex = 4,

            /// <summary>
            /// Duplicate field exists.
            /// </summary>
            DuplicateFieldExists = 5,

            /// <summary>
            /// Unsupport remove fake field.
            /// </summary>
            UnsupportRemoveFakeField = 6,

            /// <summary>
            /// Unsupport rename fake field.
            /// </summary>
            UnsupportRenameFakeField = 7,

            /// <summary>
            /// Invalid PDF field object.
            /// </summary>
            InvalidPdfFieldObject = 8,

            /// <summary>
            /// Unknown.
            /// </summary>
            Unknown = 0,
        }

        /// <summary>
        /// Gets the manage PDF field exception code.
        /// </summary>
        public PiPiCSharpManageExceptionCode Code { get; private set; }
    }
}
