// <copyright file="PiPiCSharpExtractAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Wrappers;

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
        /// Extract fields in pdf.
        /// </summary>
        /// <returns>Extracted fields.</returns>
        /// <exception cref="PiPiCSharpExtractException">Extract exception.</exception>
        internal List<PiPiCSharpField> ExtractField()
        {
            try
            {
                var fields = new List<PiPiCSharpField>();

                IntPtr cFields = PiPiExtractWrapper.PiPiExtractorExtractField(this.cExtractor);

                int cFieldSize = PiPiExtractWrapper.PiPiExtractorExtractedFieldsSize(cFields);
                for (int i = 0; i < cFieldSize; i++)
                {
                    IntPtr cField = PiPiExtractWrapper.PiPiExtractorGetExtractedField(cFields, i);

                    IntPtr cName = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldName(cField);
                    string name = Marshal.PtrToStringUTF8(cName);

                    IntPtr cFontName = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldFontName(cField);
                    string fontName = Marshal.PtrToStringUTF8(cFontName);

                    float fontSize = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldFontSize(cField);

                    ushort pageIndex = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldPageIndex(cField);
                    ushort cType = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldType(cField);

                    double width = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldWidth(cField);
                    double height = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldHeight(cField);
                    double x = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldX(cField);
                    double y = PiPiExtractWrapper.PiPiExtractorGetExtractedFieldY(cField);

                    PiPiCSharpFieldType type = PiPiCSharpConstants.FieldTypeInvertMap[cType];

                    PiPiCSharpField field = new PiPiCSharpField(name, type, pageIndex, x, y, width, height, fontName, fontSize);
                    fields.Add(field);

                    PiPiExtractWrapper.DeletePiPiExtractorExtractedField(cField);
                }

                PiPiExtractWrapper.DeletePiPiExtractorExtractedFields(cFields);

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
                var pages = new List<PiPiCSharpPage>();

                IntPtr cPages = PiPiExtractWrapper.PiPiExtractorExtractPage(this.cExtractor);

                int cPageSize = PiPiExtractWrapper.PiPiExtractorExtractedPagesSize(cPages);
                for (int i = 0; i < cPageSize; i++)
                {
                    IntPtr cPage = PiPiExtractWrapper.PiPiExtractorGetExtractedPage(cPages, i);

                    double width = PiPiExtractWrapper.PiPiExtractorGetExtractedPageWidth(cPage);
                    double height = PiPiExtractWrapper.PiPiExtractorGetExtractedPageHeight(cPage);

                    PiPiCSharpPage page = new PiPiCSharpPage(width, height);
                    pages.Add(page);

                    PiPiExtractWrapper.DeletePiPiExtractorExtractedPage(cPage);
                }

                PiPiExtractWrapper.DeletePiPiExtractorExtractedPages(cPages);

                return pages;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpExtractException(PiPiCSharpExtractException.PiPiCSharpExtractExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <exception cref="PiPiCSharpExtractException">Extract exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            try
            {
                return PiPiExtractWrapper.PiPiExtractorIsOperable(this.cExtractor);
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
                    PiPiExtractWrapper.DeletePiPiExtractor(this.cExtractor);
                }

                this.disposedValue = true;
            }
        }
    }
}
