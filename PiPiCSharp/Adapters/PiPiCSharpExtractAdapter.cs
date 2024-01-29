// <copyright file="PiPiCSharpExtractAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Invokers;

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
            var fields = new List<PiPiCSharpField>();

            IntPtr cFields = PiPiCSharpExtractInvoker.InvokePiPiExtractorExtractField(this.cExtractor);

            uint cFieldSize = PiPiCSharpExtractInvoker.InvokePiPiExtractorExtractedFieldsSize(cFields);
            for (int i = 0; i < cFieldSize; i++)
            {
                uint ui = Convert.ToUInt32(i);

                IntPtr cField = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedField(cFields, ui);

                IntPtr cName = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldName(cField);
                string name = Marshal.PtrToStringUTF8(cName);
                PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedFieldName(cName);

                IntPtr cFontName = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldFontName(cField);
                string fontName = Marshal.PtrToStringUTF8(cFontName);
                PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedFieldFontName(cFontName);

                IntPtr cDefaultValue = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldDefaultValue(cField);
                string defaultValue = Marshal.PtrToStringUTF8(cDefaultValue);
                PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedFieldDefaultValue(cDefaultValue);

                uint uPageIndex = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldPageIndex(cField);
                int pageIndex = Convert.ToInt32(uPageIndex);

                uint cType = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldType(cField);
                PiPiCSharpFieldType type = PiPiCSharpConstants.FieldTypeInvertMap[cType];

                uint cTextHorizontalAlignment = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldTextHorizontalAlignment(cField);
                PiPiCSharpTextHorizontalAlignment textHorizontalAlignment = PiPiCSharpConstants.TextHorizontalAlignmentInvertMap[cTextHorizontalAlignment];

                float fontSize = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldFontSize(cField);

                double width = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldWidth(cField);
                double height = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldHeight(cField);
                double x = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldX(cField);
                double y = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldY(cField);
                double borderWidth = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBorderWidth(cField);

                bool multiline = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldMultiline(cField);

                float colorRed = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldColorRed(cField);
                float colorGreen = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldColorGreen(cField);
                float colorBlue = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldColorBlue(cField);

                Color color = Color.FromArgb((int)(colorRed * 255), (int)(colorGreen * 255), (int)(colorBlue * 255));

                bool backgroundColorExists = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBackgroundExists(cField);
                float backgroundColorRed = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBackgroundColorRed(cField);
                float backgroundColorGreen = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBackgroundColorGreen(cField);
                float backgroundColorBlue = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBackgroundColorBlue(cField);

                Color backgroundColor = !backgroundColorExists ? Color.Empty : Color.FromArgb((int)(backgroundColorRed * 255), (int)(backgroundColorGreen * 255), (int)(backgroundColorBlue * 255));

                bool borderExists = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBorderExists(cField);
                float borderColorRed = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBorderdColorRed(cField);
                float borderColorGreen = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBorderdColorGreen(cField);
                float borderColorBlue = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedFieldBorderdColorBlue(cField);

                Color borderColor = !borderExists ? Color.Empty : Color.FromArgb((int)(borderColorRed * 255), (int)(borderColorGreen * 255), (int)(borderColorBlue * 255));

                PiPiCSharpField field = new PiPiCSharpField(
                    name,
                    type,
                    pageIndex,
                    x,
                    y,
                    width,
                    height,
                    defaultValue,
                    textHorizontalAlignment,
                    multiline,
                    fontName,
                    fontSize,
                    color,
                    backgroundColor,
                    borderWidth,
                    borderColor);

                fields.Add(field);

                PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedField(cField);
            }

            PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedFields(cFields);

            return fields;
        }

        /// <summary>
        /// Extract pages in pdf.
        /// </summary>
        /// <returns>Extracted pages.</returns>
        /// <exception cref="PiPiCSharpExtractException">Extract exception.</exception>
        internal List<PiPiCSharpPage> ExtractPage()
        {
            var pages = new List<PiPiCSharpPage>();

            IntPtr cPages = PiPiCSharpExtractInvoker.InvokePiPiExtractorExtractPage(this.cExtractor);

            uint cPageSize = PiPiCSharpExtractInvoker.InvokePiPiExtractorExtractedPagesSize(cPages);
            for (int i = 0; i < cPageSize; i++)
            {
                IntPtr cPage = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedPage(cPages, Convert.ToUInt32(i));

                double width = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedPageWidth(cPage);
                double height = PiPiCSharpExtractInvoker.InvokePiPiExtractorGetExtractedPageHeight(cPage);

                PiPiCSharpPage page = new PiPiCSharpPage(width, height);
                pages.Add(page);

                PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedPage(cPage);
            }

            PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractorExtractedPages(cPages);

            return pages;
        }

        /// <summary>
        /// Get operable status.
        /// </summary>
        /// <exception cref="PiPiCSharpExtractException">Extract exception.</exception>
        /// <returns>The operable status.</returns>
        internal bool IsOperable()
        {
            return PiPiCSharpExtractInvoker.InvokePiPiExtractorIsOperable(this.cExtractor);
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
                    PiPiCSharpExtractInvoker.InvokeDeletePiPiExtractor(this.cExtractor);
                }

                this.disposedValue = true;
            }
        }
    }
}
