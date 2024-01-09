// <copyright file="PiPiCSharpFillAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;

    /// <summary>
    /// PDF fill adapter.
    /// </summary>
    internal class PiPiCSharpFillAdapter : IDisposable
    {
        private readonly IntPtr cFiller;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFillAdapter"/> class.
        /// </summary>
        /// <param name="cFiller">The PiPiFiller instance pointer.</param>
        internal PiPiCSharpFillAdapter(IntPtr cFiller)
        {
            this.cFiller = cFiller;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

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
        internal static extern void PiPiFillerFillEllipsisValue(IntPtr cFiller, string fieldName, string value, bool ellipsis);

        /// <summary>
        /// Invoke c++ PiPiFiller FillImage.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="imageBytes">The image binary bytes.</param>
        /// <param name="imageSize">The image binary size.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerFillImage")]
        internal static extern void PiPiFillerFillImage(IntPtr cFiller, string fieldName, byte[] imageBytes, int imageSize);

        /// <summary>
        /// Invoke c++ PiPiFiller FillValue.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerFillValue")]
        internal static extern void PiPiFillerFillValue(IntPtr cFiller, string fieldName, string value);

        /// <summary>
        /// Invoke c++ PiPiFiller IsOperable.
        /// </summary>
        /// <param name="cFiller">PiPiFiller instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFillerIsOperable")]
        internal static extern bool PiPiFillerIsOperable(IntPtr cFiller);

        /// <summary>
        /// Fill image.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="imageBytes">The value.</param>
        /// <exception cref="PiPiCSharpFillException">Fill exception.</exception>
        internal void FillImage(string fieldName, byte[] imageBytes)
        {
            try
            {
                PiPiFillerFillImage(this.cFiller, fieldName, imageBytes, imageBytes.Length);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpFillException(PiPiCSharpFillException.PiPiCSharpFillExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Fill value with ellipsis.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <param name="ellipsis">The ellipsis.</param>
        /// <exception cref="PiPiCSharpFillException">Fill exception.</exception>
        internal void FillValue(string fieldName, string value, bool ellipsis)
        {
            try
            {
                PiPiFillerFillEllipsisValue(this.cFiller, fieldName, value, ellipsis);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpFillException(PiPiCSharpFillException.PiPiCSharpFillExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Fill value.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="PiPiCSharpFillException">Fill exception.</exception>
        internal void FillValue(string fieldName, string value)
        {
            try
            {
                PiPiFillerFillValue(this.cFiller, fieldName, value);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpFillException(PiPiCSharpFillException.PiPiCSharpFillExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <exception cref="PiPiCSharpFillException">Fill exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            try
            {
                return PiPiFillerIsOperable(this.cFiller);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpFillException(PiPiCSharpFillException.PiPiCSharpFillExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Invoke inner dispose.
        /// </summary>
        /// <param name="disposing">The dispose status.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    DeletePiPiFiller(this.cFiller);
                }

                this.disposedValue = true;
            }
        }
    }
}
