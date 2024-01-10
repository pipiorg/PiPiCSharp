// <copyright file="PiPiFillWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiFiller.
    /// </summary>
    internal static class PiPiFillWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiFiller destructor.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiFiller")]
        internal static extern void DeletePiPiFiller(IntPtr cFiller);

        /// <summary>
        /// Invoke c++ PiPiFiller FillValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <param name="ellipsis">The ellipsis.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerFillEllipsisValue")]
        internal static extern void PiPiFillerFillEllipsisValue(IntPtr cFiller, [MarshalAs(UnmanagedType.LPStr)] string fieldName, [MarshalAs(UnmanagedType.LPStr)] string value, bool ellipsis);

        /// <summary>
        /// Invoke c++ PiPiFiller FillImage.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="imageBytes">The image binary bytes.</param>
        /// <param name="imageSize">The image binary size.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerFillImage")]
        internal static extern void PiPiFillerFillImage(IntPtr cFiller, [MarshalAs(UnmanagedType.LPStr)] string fieldName, byte[] imageBytes, int imageSize);

        /// <summary>
        /// Invoke c++ PiPiFiller FillValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerFillValue")]
        internal static extern void PiPiFillerFillValue(IntPtr cFiller, [MarshalAs(UnmanagedType.LPStr)] string fieldName, [MarshalAs(UnmanagedType.LPStr)] string value);

        /// <summary>
        /// Invoke c++ PiPiFiller IsOperable.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerIsOperable")]
        internal static extern bool PiPiFillerIsOperable(IntPtr cFiller);
    }
}
