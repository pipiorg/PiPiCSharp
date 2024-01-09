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
        private readonly PiPiCSharpEditor editor;
        private readonly PiPiCSharpExtractor extractor;
        private readonly PiPiCSharpFiller filler;
        private readonly PiPiCSharpFontManager fontManager;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperator"/> class.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        public PiPiCSharpOperator(byte[] pdfBytes)
        {
            this.adapter = new PiPiCSharpOperateAdapter(pdfBytes);

            PiPiCSharpEditAdapter editAdapter = this.adapter.GetEditor();
            this.editor = new PiPiCSharpEditor(editAdapter);

            PiPiCSharpFillAdapter fillAdapter = this.adapter.GetFiller();
            this.filler = new PiPiCSharpFiller(fillAdapter);

            PiPiCSharpExtractAdapter extractAdapter = this.adapter.GetExtractor();
            this.extractor = new PiPiCSharpExtractor(extractAdapter);

            PiPiCSharpFontManageAdapter fontManageAdapter = this.adapter.GetFontManager();
            this.fontManager = new PiPiCSharpFontManager(fontManageAdapter);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperator"/> class.
        /// </summary>
        /// <param name="adapter">The PDF operate adapter.</param>
        internal PiPiCSharpOperator(PiPiCSharpOperateAdapter adapter)
        {
            this.adapter = adapter;

            PiPiCSharpEditAdapter editAdapter = this.adapter.GetEditor();
            this.editor = new PiPiCSharpEditor(editAdapter);

            PiPiCSharpFillAdapter fillAdapter = this.adapter.GetFiller();
            this.filler = new PiPiCSharpFiller(fillAdapter);

            PiPiCSharpExtractAdapter extractAdapter = this.adapter.GetExtractor();
            this.extractor = new PiPiCSharpExtractor(extractAdapter);

            PiPiCSharpFontManageAdapter fontManageAdapter = this.adapter.GetFontManager();
            this.fontManager = new PiPiCSharpFontManager(fontManageAdapter);
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
            return this.editor;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpExtractor"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpExtractor"/> instance.</returns>
        public PiPiCSharpExtractor GetExtractor()
        {
            return this.extractor;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFiller"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFiller"/> instance.</returns>
        public PiPiCSharpFiller GetFiller()
        {
            return this.filler;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFontManager"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFontManager"/> instance.</returns>
        public PiPiCSharpFontManager GetFontManager()
        {
            return this.fontManager;
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
