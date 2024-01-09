// <copyright file="PiPiCSharpFontManageAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;

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
        /// Invoke c++ PiPiFontManager destructor.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiFontManager")]
        internal static extern void DeletePiPiFontManager(IntPtr cFontManager);

        /// <summary>
        /// Invoke c++ PiPiFontManager IsOperable.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontManagerIsOperable")]
        internal static extern bool PiPiFontManagerIsOperable(IntPtr cFontManager);

        /// <summary>
        /// Invoke c++ PiPiFontManager RegisterFont.
        /// </summary>
        /// <param name="cFontManager">PiPiFontManager instance pointer.</param>
        /// <param name="fontBytes">The font binary bytes.</param>
        /// <param name="fontSize">The font binary size.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiFontManagerRegisterFont")]
        internal static extern void PiPiFontManagerRegisterFont(IntPtr cFontManager, byte[] fontBytes, int fontSize);

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <exception cref="PiPiCSharpFontManageException">Font manage exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            try
            {
                return PiPiFontManagerIsOperable(this.cFontManager);
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
        /// <exception cref="PiPiCSharpFontManageException">Font manage exception.</exception>
        internal void RegisterFont(byte[] fontBytes)
        {
            try
            {
                PiPiFontManagerRegisterFont(this.cFontManager, fontBytes, fontBytes.Length);
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
                    DeletePiPiFontManager(this.cFontManager);
                }

                this.disposedValue = true;
            }
        }
    }
}
