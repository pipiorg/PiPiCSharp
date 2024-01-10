// <copyright file="PiPiCSharpFillAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Wrappers;

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
        /// Fill image.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="imageBytes">The value.</param>
        /// <exception cref="PiPiCSharpFillException">Fill exception.</exception>
        /// <returns>The current PDF fill adapter instance.</returns>
        internal PiPiCSharpFillAdapter FillImage(string fieldName, byte[] imageBytes)
        {
            try
            {
                PiPiFillWrapper.PiPiFillerFillImage(this.cFiller, fieldName, imageBytes, imageBytes.Length);
                return this;
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
        /// <returns>The current PDF fill adapter instance.</returns>
        internal PiPiCSharpFillAdapter FillValue(string fieldName, string value, bool ellipsis)
        {
            try
            {
                PiPiFillWrapper.PiPiFillerFillEllipsisValue(this.cFiller, fieldName, value, ellipsis);
                return this;
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
        /// <returns>The current PDF fill adapter instance.</returns>
        internal PiPiCSharpFillAdapter FillValue(string fieldName, string value)
        {
            try
            {
                PiPiFillWrapper.PiPiFillerFillValue(this.cFiller, fieldName, value);
                return this;
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
                return PiPiFillWrapper.PiPiFillerIsOperable(this.cFiller);
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
                    PiPiFillWrapper.DeletePiPiFiller(this.cFiller);
                }

                this.disposedValue = true;
            }
        }
    }
}
