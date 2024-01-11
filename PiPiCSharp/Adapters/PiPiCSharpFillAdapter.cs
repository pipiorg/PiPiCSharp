// <copyright file="PiPiCSharpFillAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Invokers;

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
            PiPiCSharpFillInvoker.InvokePiPiFillerFillImage(this.cFiller, fieldName, imageBytes, Convert.ToUInt32(imageBytes.Length));
            return this;
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
            PiPiCSharpFillInvoker.InvokePiPiFillerFillEllipsisValue(this.cFiller, fieldName, value, ellipsis);
            return this;
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
            PiPiCSharpFillInvoker.InvokePiPiFillerFillValue(this.cFiller, fieldName, value);
            return this;
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <exception cref="PiPiCSharpFillException">Fill exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            return PiPiCSharpFillInvoker.InvokePiPiFillerIsOperable(this.cFiller);
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
                    PiPiCSharpFillInvoker.InvokeDeletePiPiFiller(this.cFiller);
                }

                this.disposedValue = true;
            }
        }
    }
}
