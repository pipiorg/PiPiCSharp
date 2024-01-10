// <copyright file="PiPiCSharpFontManageAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Wrappers;

    /// <summary>
    /// PDF font manager adapter.
    /// </summary>
    internal class PiPiCSharpFontManageAdapter : IDisposable
    {
        private readonly IntPtr cFontManager;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontManageAdapter"/> class.
        /// </summary>
        /// <param name="cFontManager">The PiPiFontManager instance pointer.</param>
        internal PiPiCSharpFontManageAdapter(IntPtr cFontManager)
        {
            this.cFontManager = cFontManager;
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
        /// <exception cref="PiPiCSharpFontManageException">Font manage exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            try
            {
                return PiPiFontManageWrapper.PiPiFontManagerIsOperable(this.cFontManager);
            }
            catch (Exception e)
            {
                throw new PiPiCSharpFontManageException(PiPiCSharpFontManageException.PiPiCSharpFontManageExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Register font.
        /// </summary>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <returns>The current font manage adapter instance.</returns>
        /// <exception cref="PiPiCSharpFontManageException">Font manage exception.</exception>
        internal string RegisterFont(byte[] fontBytes)
        {
            try
            {
                IntPtr cFontName = PiPiFontManageWrapper.PiPiFontManagerRegisterFont(this.cFontManager, fontBytes, fontBytes.Length);
                string fontName = Marshal.PtrToStringUTF8(cFontName);
                return fontName;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpFontManageException(PiPiCSharpFontManageException.PiPiCSharpFontManageExceptionCode.Unknown, e);
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
                    PiPiFontManageWrapper.DeletePiPiFontManager(this.cFontManager);
                }

                this.disposedValue = true;
            }
        }
    }
}
