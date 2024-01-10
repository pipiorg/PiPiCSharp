// <copyright file="PiPiCSharpOperateAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Wrappers;

    /// <summary>
    /// PDF operate adapter.
    /// </summary>
    internal class PiPiCSharpOperateAdapter : IDisposable
    {
        private readonly IntPtr cOp;
        private readonly PiPiCSharpEditAdapter editAdapter;
        private readonly PiPiCSharpExtractAdapter extractoAdapter;
        private readonly PiPiCSharpFillAdapter fillAdapter;
        private readonly PiPiCSharpFontManageAdapter fontManageAdapter;
        private readonly bool multiManaged;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperateAdapter"/> class.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        internal PiPiCSharpOperateAdapter(byte[] pdfBytes)
        {
            this.multiManaged = false;

            this.cOp = PiPiOperateWrapper.CreatePiPiOperator(pdfBytes, pdfBytes.Length);

            IntPtr cEditor = PiPiOperateWrapper.PiPiOperatorGetEditor(this.cOp);
            this.editAdapter = new PiPiCSharpEditAdapter(cEditor);

            IntPtr cFiller = PiPiOperateWrapper.PiPiOperatorGetFiller(this.cOp);
            this.fillAdapter = new PiPiCSharpFillAdapter(cFiller);

            IntPtr cExtractor = PiPiOperateWrapper.PiPiOperatorGetPiPiExtractor(this.cOp);
            this.extractoAdapter = new PiPiCSharpExtractAdapter(cExtractor);

            IntPtr cFontManager = PiPiOperateWrapper.PiPiOperatorGetPiPiFontManager(this.cOp);
            this.fontManageAdapter = new PiPiCSharpFontManageAdapter(cFontManager);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperateAdapter"/> class.
        /// </summary>
        /// <param name="cOp">The c++ operate pointer.</param>
        internal PiPiCSharpOperateAdapter(IntPtr cOp)
        {
            this.multiManaged = true;

            this.cOp = cOp;

            IntPtr cEditor = PiPiOperateWrapper.PiPiOperatorGetEditor(this.cOp);
            this.editAdapter = new PiPiCSharpEditAdapter(cEditor);

            IntPtr cFiller = PiPiOperateWrapper.PiPiOperatorGetFiller(this.cOp);
            this.fillAdapter = new PiPiCSharpFillAdapter(cFiller);

            IntPtr cExtractor = PiPiOperateWrapper.PiPiOperatorGetPiPiExtractor(this.cOp);
            this.extractoAdapter = new PiPiCSharpExtractAdapter(cExtractor);

            IntPtr cFontManager = PiPiOperateWrapper.PiPiOperatorGetPiPiFontManager(this.cOp);
            this.fontManageAdapter = new PiPiCSharpFontManageAdapter(cFontManager);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Get PDF output.
        /// </summary>
        /// <exception cref="PiPiCSharpOperateException">Operate exception.</exception>
        /// <returns>The output PDF binary bytes.</returns>
        internal byte[] Finalize()
        {
            try
            {
                IntPtr cBytes = PiPiOperateWrapper.PiPiOperatorFinalize(this.cOp);

                int newPdfSize = PiPiOperateWrapper.PiPiOperatorMeasureFinalize(cBytes);
                byte[] newPdfBytes = new byte[newPdfSize];

                PiPiOperateWrapper.PiPiOperatorCopyFinalize(cBytes, newPdfBytes);
                PiPiOperateWrapper.PiPiOperatorDeleteFinalize(cBytes);

                return newPdfBytes;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpOperateException(PiPiCSharpOperateException.PiPiCSharpOperateExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpOperateAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpOperateAdapter"/> instance.</returns>
        internal PiPiCSharpEditAdapter GetEditor()
        {
            return this.editAdapter;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpExtractAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpExtractAdapter"/> instance.</returns>
        internal PiPiCSharpExtractAdapter GetExtractor()
        {
            return this.extractoAdapter;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFillAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFillAdapter"/> instance.</returns>
        internal PiPiCSharpFillAdapter GetFiller()
        {
            return this.fillAdapter;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFontManageAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFontManageAdapter"/> instance.</returns>
        internal PiPiCSharpFontManageAdapter GetFontManager()
        {
            return this.fontManageAdapter;
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
                    if (!this.multiManaged)
                    {
                        PiPiOperateWrapper.DeletePiPiOperator(this.cOp);
                    }
                }

                this.disposedValue = true;
            }
        }
    }
}
