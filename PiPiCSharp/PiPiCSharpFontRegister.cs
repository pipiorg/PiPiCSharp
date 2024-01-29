// <copyright file="PiPiCSharpFontRegister.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// The PDF font manager.
    /// </summary>
    public class PiPiCSharpFontRegister : IDisposable
    {
        private readonly PiPiCSharpFontRegisterAdapter adapter;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontRegister"/> class.
        /// </summary>
        /// <param name="adapter">The filler adapter.</param>
        internal PiPiCSharpFontRegister(PiPiCSharpFontRegisterAdapter adapter)
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
        /// Get operable status.
        /// </summary>
        /// <returns>The operable status.</returns>
        public bool IsOperable()
        {
            return this.adapter.IsOperable();
        }

        /// <summary>
        /// Register font.
        /// </summary>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <returns>The current font manage instance.</returns>
        public string RegisterFont(byte[] fontBytes)
        {
            return this.adapter.RegisterFont(fontBytes);
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
