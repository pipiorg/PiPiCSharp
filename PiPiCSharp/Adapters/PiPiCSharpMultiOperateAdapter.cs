// <copyright file="PiPiCSharpMultiOperateAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using PiPiCSharp.Exceptions;
    using PiPiCSharp.Invokers;

    /// <summary>
    /// The multiple PDF operate adapter.
    /// </summary>
    internal class PiPiCSharpMultiOperateAdapter : IDisposable
    {
        private readonly IntPtr cMultiOp;
        private readonly Dictionary<int, uint> operateAdapterMap;
        private readonly List<PiPiCSharpOperateAdapter> operateAdapters;
        private readonly PiPiCSharpPageAdapter pageAdapter;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpMultiOperateAdapter"/> class.
        /// </summary>
        internal PiPiCSharpMultiOperateAdapter()
        {
            this.cMultiOp = PiPiCSharpMultiOperateInvoker.InvokeCreatePiPiMultiOperator();

            IntPtr cPager = PiPiCSharpMultiOperateInvoker.InvokePiPiMultiOperatorGetPager(this.cMultiOp);
            this.pageAdapter = new PiPiCSharpPageAdapter(cPager);

            this.operateAdapterMap = new Dictionary<int, uint>();
            this.operateAdapters = new List<PiPiCSharpOperateAdapter>();
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Add PDF to multi operator.
        /// </summary>
        /// <param name="pdfBytes">The PDF binary bytes.</param>
        /// <returns>The added index.</returns>
        /// <exception cref="PiPiCSharpMultiOperateException">Multi operate exception.</exception>
        internal int Add(byte[] pdfBytes)
        {
            uint cIndex = PiPiCSharpMultiOperateInvoker.InvokePiPiMultiOperatorAdd(this.cMultiOp, pdfBytes, Convert.ToUInt32(pdfBytes.Length));
            int index = this.operateAdapters.Count;

            IntPtr cOp = PiPiCSharpMultiOperateInvoker.InvokePiPiMultiOperatorGetOperator(this.cMultiOp, cIndex);
            PiPiCSharpOperateAdapter opAdapter = new PiPiCSharpOperateAdapter(cOp);

            this.operateAdapters.Add(opAdapter);
            this.operateAdapterMap.Add(index, cIndex);

            return index;
        }

        /// <summary>
        /// Get operator by index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The operator</returns>
        /// <exception cref="PiPiCSharpMultiOperateException">Multi operate exception.</exception>
        internal PiPiCSharpOperateAdapter GetOperator(int index)
        {
            return this.operateAdapters[index];
        }

        /// <summary>
        /// Get Pager.
        /// </summary>
        /// <returns>The pager.</returns>
        internal PiPiCSharpPageAdapter GetPager()
        {
            return this.pageAdapter;
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
                    PiPiCSharpMultiOperateInvoker.InvokeDeletePiPiMultiOperator(this.cMultiOp);
                }

                this.disposedValue = true;
            }
        }
    }
}
