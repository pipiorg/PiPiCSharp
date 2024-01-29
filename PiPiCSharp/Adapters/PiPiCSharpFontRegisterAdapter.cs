// <copyright file="PiPiCSharpFontRegisterAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Invokers;

    /// <summary>
    /// PDF font register adapter.
    /// </summary>
    internal class PiPiCSharpFontRegisterAdapter : IDisposable
    {
        private readonly IntPtr cFontRegister;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontRegisterAdapter"/> class.
        /// </summary>
        /// <param name="cFontRegister">The PiPiFontRegister instance pointer.</param>
        internal PiPiCSharpFontRegisterAdapter(IntPtr cFontRegister)
        {
            this.cFontRegister = cFontRegister;
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
        /// <exception cref="PiPiCSharpFontRegisterException">Font manage exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            return PiPiCSharpFontRegisterInvoker.InvokePiPiFontRegisterIsOperable(this.cFontRegister);
        }

        /// <summary>
        /// Register font.
        /// </summary>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <returns>The current font manage adapter instance.</returns>
        /// <exception cref="PiPiCSharpFontRegisterException">Font manage exception.</exception>
        internal string RegisterFont(byte[] fontBytes)
        {
            IntPtr cFontName = PiPiCSharpFontRegisterInvoker.InvokePiPiFontRegisterRegisterFont(this.cFontRegister, fontBytes, Convert.ToUInt32(fontBytes.Length));
            string fontName = Marshal.PtrToStringUTF8(cFontName);
            PiPiCSharpFontRegisterInvoker.InvokeDeletePiPiFontRegisterFontName(cFontName);
            return fontName;
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
                    PiPiCSharpFontRegisterInvoker.InvokeDeletePiPiFontRegister(this.cFontRegister);
                }

                this.disposedValue = true;
            }
        }
    }
}
