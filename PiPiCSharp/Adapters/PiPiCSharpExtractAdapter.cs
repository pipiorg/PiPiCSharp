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
        /// Invoke c++ PiPiExtractor release extracted field.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedField")]
        internal static extern void DeletePiPiExtractorExtractedField(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted fields.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedFields")]
        internal static extern void DeletePiPiExtractorExtractedFields(IntPtr cExtractedFields);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted page.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedPage")]
        internal static extern void DeletePiPiExtractorExtractedPage(IntPtr cExtractedPage);

        /// <summary>
        /// Invoke c++ PiPiExtractor release extracted pages.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiExtractorExtractedPages")]
        internal static extern void DeletePiPiExtractorExtractedPages(IntPtr cExtractedPages);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted fields size.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <returns>>The extracted fields size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractedFieldsSize")]
        internal static extern ushort PiPiExtractorExtractedFieldsSize(IntPtr cExtractedFields);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted pages size.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <returns>The extracted pages size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorExtractedPagesSize")]
        internal static extern ushort PiPiExtractorExtractedPagesSize(IntPtr cExtractedPages);

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
        /// Invoke c++ PiPiExtractor get extracted field from extracted fields.
        /// </summary>
        /// <param name="cExtractedFields">Extracted fields pointer.</param>
        /// <param name="index">The index of extracted field.</param>
        /// <returns>The extracted field pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedField")]
        internal static extern IntPtr PiPiExtractorGetExtractedField(IntPtr cExtractedFields, int index);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field font name.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font name.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldFontName")]
        internal static extern string PiPiExtractorGetExtractedFieldFontName(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field font size.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field font size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldFontSize")]
        internal static extern float PiPiExtractorGetExtractedFieldFontSize(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field height.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field height.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldHeight")]
        internal static extern float PiPiExtractorGetExtractedFieldHeight(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field name.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field name.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldName")]
        internal static extern string PiPiExtractorGetExtractedFieldName(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field page index.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field page index.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldPageIndex")]
        internal static extern ushort PiPiExtractorGetExtractedFieldPageIndex(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field type.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field type.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldType")]
        internal static extern ushort PiPiExtractorGetExtractedFieldType(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field width.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field width.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldWidth")]
        internal static extern float PiPiExtractorGetExtractedFieldWidth(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field x.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field x.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldX")]
        internal static extern float PiPiExtractorGetExtractedFieldX(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted field y.
        /// </summary>
        /// <param name="cExtractedField">Extracted field pointer.</param>
        /// <returns>The extracted field y.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedFieldY")]
        internal static extern float PiPiExtractorGetExtractedFieldY(IntPtr cExtractedField);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted page from extracted pages.
        /// </summary>
        /// <param name="cExtractedPages">Extracted pages pointer.</param>
        /// <param name="index">The index of extracted page.</param>
        /// <returns>The extracted page pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedPage")]
        internal static extern IntPtr PiPiExtractorGetExtractedPage(IntPtr cExtractedPages, int index);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted page height.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page height.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedPageHeight")]
        internal static extern double PiPiExtractorGetExtractedPageHeight(IntPtr cExtractedPage);

        /// <summary>
        /// Invoke c++ PiPiExtractor get extracted page width.
        /// </summary>
        /// <param name="cExtractedPage">Extracted page pointer.</param>
        /// <returns>The extracted page width.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorGetExtractedPageWidth")]
        internal static extern double PiPiExtractorGetExtractedPageWidth(IntPtr cExtractedPage);

        /// <summary>
        /// Invoke c++ PiPiExtractor IsOperable.
        /// </summary>
        /// <param name="cExtractor">PiPiExtractor instance pointer.</param>
        /// <returns>The operable status.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiExtractorIsOperable")]
        internal static extern bool PiPiExtractorIsOperable(IntPtr cExtractor);

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

                IntPtr cFields = PiPiExtractorExtractField(this.cExtractor);

                int cFieldSize = PiPiExtractorExtractedFieldsSize(cFields);
                for (int i = 0; i < cFieldSize; i++)
                {
                    IntPtr cField = PiPiExtractorGetExtractedField(cFields, i);

                    string name = PiPiExtractorGetExtractedFieldName(cField);
                    string fontName = PiPiExtractorGetExtractedFieldFontName(cField);

                    float fontSize = PiPiExtractorGetExtractedFieldFontSize(cField);

                    ushort pageIndex = PiPiExtractorGetExtractedFieldPageIndex(cField);
                    ushort cType = PiPiExtractorGetExtractedFieldType(cField);

                    double width = PiPiExtractorGetExtractedFieldWidth(cField);
                    double height = PiPiExtractorGetExtractedFieldHeight(cField);
                    double x = PiPiExtractorGetExtractedFieldX(cField);
                    double y = PiPiExtractorGetExtractedFieldY(cField);

                    PiPiCSharpFieldType type = PiPiCSharpConstants.FieldTypeInvertMap[cType];

                    PiPiCSharpField field = new PiPiCSharpField(name, type, pageIndex, x, y, width, height, fontName, fontSize);
                    fields.Add(field);

                    DeletePiPiExtractorExtractedField(cField);
                }

                DeletePiPiExtractorExtractedFields(cFields);

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

                IntPtr cPages = PiPiExtractorExtractPage(this.cExtractor);

                int cPageSize = PiPiExtractorExtractedPagesSize(cPages);
                for (int i = 0; i < cPageSize; i++)
                {
                    IntPtr cPage = PiPiExtractorGetExtractedPage(cPages, i);

                    double width = PiPiExtractorGetExtractedPageWidth(cPage);
                    double height = PiPiExtractorGetExtractedPageHeight(cPage);

                    PiPiCSharpPage page = new PiPiCSharpPage(width, height);
                    pages.Add(page);

                    DeletePiPiExtractorExtractedPage(cPage);
                }

                DeletePiPiExtractorExtractedPages(cPages);

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
                return PiPiExtractorIsOperable(this.cExtractor);
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
