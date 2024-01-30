// <copyright file="PiPiCSharpOperator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// PDF Operator.
    /// </summary>
    public class PiPiCSharpOperator : IDisposable
    {
        private readonly PiPiCSharpOperateAdapter adapter;

        private bool disposedValue;
        private PiPiCSharpEditor? editor;
        private PiPiCSharpExtractor? extractor;
        private PiPiCSharpFiller? filler;
        private PiPiCSharpFontRegister? fontRegister;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperator"/> class.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        public PiPiCSharpOperator(byte[] pdfBytes)
        {
            this.adapter = new PiPiCSharpOperateAdapter(pdfBytes);
            this.editor = null;
            this.filler = null;
            this.extractor = null;
            this.fontRegister = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperator"/> class.
        /// </summary>
        /// <param name="adapter">The PDF operate adapter.</param>
        internal PiPiCSharpOperator(PiPiCSharpOperateAdapter adapter)
        {
            this.adapter = adapter;
            this.editor = null;
            this.filler = null;
            this.extractor = null;
            this.fontRegister = null;
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
        /// <returns>The PDF output binary bytes.</returns>
        public byte[] Finalized()
        {
            return this.adapter.Finalize();
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpEditor"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpEditor"/> instance.</returns>
        public PiPiCSharpEditor GetEditor()
        {
            if (this.editor == null)
            {
                PiPiCSharpEditAdapter editAdapter = this.adapter.GetEditor();
                this.editor = new PiPiCSharpEditor(editAdapter);
            }

            return this.editor;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpExtractor"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpExtractor"/> instance.</returns>
        public PiPiCSharpExtractor GetExtractor()
        {
            if (this.extractor == null)
            {
                PiPiCSharpExtractAdapter extractAdapter = this.adapter.GetExtractor();
                this.extractor = new PiPiCSharpExtractor(extractAdapter);
            }

            return this.extractor;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFiller"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFiller"/> instance.</returns>
        public PiPiCSharpFiller GetFiller()
        {
            if (this.filler == null)
            {
                PiPiCSharpFillAdapter fillAdapter = this.adapter.GetFiller();
                this.filler = new PiPiCSharpFiller(fillAdapter);
            }

            return this.filler;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFontRegister"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFontRegister"/> instance.</returns>
        public PiPiCSharpFontRegister GetFontRegister()
        {
            if (this.fontRegister == null)
            {
                PiPiCSharpFontRegisterAdapter fontRegisterAdapter = this.adapter.GetFontRegister();
                this.fontRegister = new PiPiCSharpFontRegister(fontRegisterAdapter);
            }

            return this.fontRegister;
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
