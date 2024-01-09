// <copyright file="PiPiCSharpExtractAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;

    /// <summary>
    /// PDF extractor adapter.
    /// </summary>
    internal class PiPiCSharpExtractAdapter : IDisposable
    {
        private readonly IntPtr cExtractor;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpExtractAdapter"/> class.
        /// </summary>
        /// <param name="cExtractor">The PiPiExtractor instance pointer.</param>
        internal PiPiCSharpExtractAdapter(IntPtr cExtractor)
        {
            this.cExtractor = cExtractor;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Invoke c++ PiPiExtractor destructor.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractor")]
        internal static extern void DeletePiPiExtractor(IntPtr cExtractor);

        /// <summary>
        /// Invoke c++ PiPiExtractor ExtractField.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted field pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractField")]
        internal static extern IntPtr PiPiExtractorExtractField(IntPtr cExtractor);

        /// <summary>
        /// Invoke c++ PiPiExtractor ExtractPage.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The c++ extracted page pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractPage")]
        internal static extern IntPtr PiPiExtractorExtractPage(IntPtr cExtractor);

        /// <summary>
        /// Extract fields in pdf.
        /// </summary>
        /// <returns>Extracted fields.</returns>
        /// <exception cref="PiPiCSharpExtractException">Extract exception.</exception>
        internal List<PiPiCSharpField> ExtractField()
        {
            try
            {
                IntPtr cFields = PiPiExtractorExtractField(this.cExtractor);

                // TODO: transform it.
                var fields = new List<PiPiCSharpField>();

                return fields;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpExtractException(PiPiCSharpExtractException.PiPiCSharpExtractExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Extract pages in pdf.
        /// </summary>
        /// <returns>Extracted pages.</returns>
        /// <exception cref="PiPiCSharpExtractException">Extract exception.</exception>
        internal List<PiPiCSharpPage> ExtractPage()
        {
            try
            {
                IntPtr cPages = PiPiExtractorExtractPage(this.cExtractor);

                // TODO: transform it.
                var pages = new List<PiPiCSharpPage>();

                return pages;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpExtractException(PiPiCSharpExtractException.PiPiCSharpExtractExceptionCode.Unknown, e);
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
                    DeletePiPiExtractor(this.cExtractor);
                }

                this.disposedValue = true;
            }
        }
    }
}
