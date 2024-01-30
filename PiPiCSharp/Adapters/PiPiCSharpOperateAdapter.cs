// <copyright file="PiPiCSharpOperateAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Invokers;

    /// <summary>
    /// PDF operate adapter.
    /// </summary>
    internal class PiPiCSharpOperateAdapter : IDisposable
    {
        private readonly IntPtr cOp;
        private readonly bool multiManaged;

        private bool disposedValue;
        private PiPiCSharpEditAdapter? editAdapter;
        private PiPiCSharpExtractAdapter? extractoAdapter;
        private PiPiCSharpFillAdapter? fillAdapter;
        private PiPiCSharpFontRegisterAdapter? fontRegisterAdapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperateAdapter"/> class.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        internal PiPiCSharpOperateAdapter(byte[] pdfBytes)
        {
            this.multiManaged = false;

            this.cOp = PiPiCSharpOperateInvoker.InvokeCreatePiPiOperator(pdfBytes, Convert.ToUInt32(pdfBytes.Length));
            this.editAdapter = null;
            this.extractoAdapter = null;
            this.fillAdapter = null;
            this.fontRegisterAdapter = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperateAdapter"/> class.
        /// </summary>
        /// <param name="cOp">The c++ operate pointer.</param>
        internal PiPiCSharpOperateAdapter(IntPtr cOp)
        {
            this.multiManaged = true;

            this.cOp = cOp;
            this.editAdapter = null;
            this.extractoAdapter = null;
            this.fillAdapter = null;
            this.fontRegisterAdapter = null;
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
            IntPtr cBytes = PiPiCSharpOperateInvoker.InvokePiPiOperatorFinalize(this.cOp);

            uint newPdfSize = PiPiCSharpOperateInvoker.InvokePiPiOperatorMeasureFinalize(cBytes);
            byte[] newPdfBytes = new byte[newPdfSize];

            PiPiCSharpOperateInvoker.InvokePiPiOperatorCopyFinalize(cBytes, newPdfBytes);
            PiPiCSharpOperateInvoker.InvokePiPiOperatorDeleteFinalize(cBytes);

            return newPdfBytes;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpOperateAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpOperateAdapter"/> instance.</returns>
        internal PiPiCSharpEditAdapter GetEditor()
        {
            if (this.editAdapter == null)
            {
                IntPtr cEditor = PiPiCSharpOperateInvoker.InvokePiPiOperatorGetEditor(this.cOp);
                this.editAdapter = new PiPiCSharpEditAdapter(cEditor);
            }

            return this.editAdapter;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpExtractAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpExtractAdapter"/> instance.</returns>
        internal PiPiCSharpExtractAdapter GetExtractor()
        {
            if (this.extractoAdapter == null)
            {
                IntPtr cExtractor = PiPiCSharpOperateInvoker.InvokePiPiOperatorGetPiPiExtractor(this.cOp);
                this.extractoAdapter = new PiPiCSharpExtractAdapter(cExtractor);
            }

            return this.extractoAdapter;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFillAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFillAdapter"/> instance.</returns>
        internal PiPiCSharpFillAdapter GetFiller()
        {
            if (this.fillAdapter == null)
            {
                IntPtr cFiller = PiPiCSharpOperateInvoker.InvokePiPiOperatorGetFiller(this.cOp);
                this.fillAdapter = new PiPiCSharpFillAdapter(cFiller);
            }

            return this.fillAdapter;
        }

        /// <summary>
        /// Get <see cref="PiPiCSharpFontRegisterAdapter"/>.
        /// </summary>
        /// <returns><see cref="PiPiCSharpFontRegisterAdapter"/> instance.</returns>
        internal PiPiCSharpFontRegisterAdapter GetFontRegister()
        {
            if (this.fontRegisterAdapter == null)
            {
                IntPtr cFontRegister = PiPiCSharpOperateInvoker.InvokePiPiOperatorGetPiPiFontRegister(this.cOp);
                this.fontRegisterAdapter = new PiPiCSharpFontRegisterAdapter(cFontRegister);
            }

            return this.fontRegisterAdapter;
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
                        PiPiCSharpOperateInvoker.InvokeDeletePiPiOperator(this.cOp);
                    }
                }

                this.disposedValue = true;
            }
        }
    }
}
