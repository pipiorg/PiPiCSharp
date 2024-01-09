// <copyright file="PiPiCSharpFiller.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// The PDF editor.
    /// </summary>
    public class PiPiCSharpFiller : IDisposable
    {
        private readonly PiPiCSharpFillAdapter adapter;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFiller"/> class.
        /// </summary>
        /// <param name="adapter">The filler adapter.</param>
        internal PiPiCSharpFiller(PiPiCSharpFillAdapter adapter)
        {
            this.adapter = adapter;
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
        /// <returns>The current PDF fill instance.</returns>
        public PiPiCSharpFiller FillImage(string fieldName, byte[] imageBytes)
        {
            this.adapter.FillImage(fieldName, imageBytes);
            return this;
        }

        /// <summary>
        /// Fill value with ellipsis.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <param name="ellipsis">The ellipsis.</param>
        /// <returns>The current PDF fill instance.</returns>
        public PiPiCSharpFiller FillValue(string fieldName, string value, bool ellipsis)
        {
            this.FillValue(fieldName, value, ellipsis);
            return this;
        }

        /// <summary>
        /// Fill value.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="value">The value.</param>
        /// <returns>The current PDF fill instance.</returns>
        public PiPiCSharpFiller FillValue(string fieldName, string value)
        {
            this.FillValue(fieldName, value);
            return this;
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <returns>The operable status.</returns>
        public bool IsOperable()
        {
            return this.adapter.IsOperable();
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
                    this.adapter.Dispose();
                }

                this.disposedValue = true;
            }
        }
    }
}
