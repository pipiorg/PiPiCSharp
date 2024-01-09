// <copyright file="PiPiCSharpOperateAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Runtime.InteropServices;

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
        public PiPiCSharpOperateAdapter(byte[] pdfBytes)
        {
            this.multiManaged = false;

            this.cOp = CreatePiPiOperator(pdfBytes, pdfBytes.Length);

            IntPtr cEditor = PiPiOperatorGetEditor(this.cOp);
            this.editAdapter = new PiPiCSharpEditAdapter(cEditor);

            IntPtr cFiller = PiPiOperatorGetFiller(this.cOp);
            this.fillAdapter = new PiPiCSharpFillAdapter(cFiller);

            IntPtr cExtractor = PiPiOperatorGetPiPiExtractor(this.cOp);
            this.extractoAdapter = new PiPiCSharpExtractAdapter(cExtractor);

            IntPtr cFontManager = PiPiOperatorGetPiPiFontManager(this.cOp);
            this.fontManageAdapter = new PiPiCSharpFontManageAdapter(cFontManager);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Invoke c++ PiPiOperator constructor.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        /// <param name="pdfSize">The pdf binary size.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "CreatePiPiOperator")]
        internal static extern IntPtr CreatePiPiOperator(byte[] pdfBytes, int pdfSize);

        /// <summary>
        /// Invoke c++ PiPiOperator destructor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiOperator")]
        internal static extern void DeletePiPiOperator(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetEditor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiEditor instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetEditor")]
        internal static extern IntPtr PiPiOperatorGetEditor(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetFiller.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFiller instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetFiller")]
        internal static extern IntPtr PiPiOperatorGetFiller(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetExtractor.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiExtractor instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetExtractor")]
        internal static extern IntPtr PiPiOperatorGetPiPiExtractor(IntPtr op);

        /// <summary>
        /// Invoke c++ PiPiOperator GetFontManager.
        /// </summary>
        /// <param name="op">PiPiOperator instance pointer.</param>
        /// <returns>PiPiFontManager instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiOperatorGetFontManager")]
        internal static extern IntPtr PiPiOperatorGetPiPiFontManager(IntPtr op);

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
                        DeletePiPiOperator(this.cOp);
                    }
                }

                this.disposedValue = true;
            }
        }
    }
}
