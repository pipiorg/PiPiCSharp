// <copyright file="PiPiCSharpExtractor.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using System.Collections.Generic;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// The PDF extractor.
    /// </summary>
    internal class PiPiCSharpExtractor : IDisposable
    {
        private readonly PiPiCSharpExtractAdapter adapter;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpExtractor"/> class.
        /// </summary>
        /// <param name="adapter">The extractor adapter.</param>
        internal PiPiCSharpExtractor(PiPiCSharpExtractAdapter adapter)
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
        /// Extract fields in pdf.
        /// </summary>
        /// <returns>Extracted fields.</returns>
        public List<PiPiCSharpField> ExtractField()
        {
            return this.adapter.ExtractField();
        }

        /// <summary>
        /// Extract pages in pdf.
        /// </summary>
        /// <returns>Extracted pages.</returns>
        public List<PiPiCSharpPage> ExtractPage()
        {
            return this.adapter.ExtractPage();
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
