// <copyright file="PiPiCSharpMultiOperateAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using PiPiCSharp.Exceptions;

    /// <summary>
    /// The multiple PDF operate adapter.
    /// </summary>
    internal class PiPiCSharpMultiOperateAdapter : IDisposable
    {
        private readonly IntPtr cMultiOp;
        private readonly Dictionary<int, int> operateAdapterMap;
        private readonly List<PiPiCSharpOperateAdapter> operateAdapters;
        private readonly PiPiCSharpPageAdapter pageAdapter;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpMultiOperateAdapter"/> class.
        /// </summary>
        internal PiPiCSharpMultiOperateAdapter()
        {
            this.cMultiOp = CreatePiPiMultiOperator();

            IntPtr cPager = PiPiMultiOperatorGetPager(this.cMultiOp);
            this.pageAdapter = new PiPiCSharpPageAdapter(cPager);

            this.operateAdapterMap = new Dictionary<int, int>();
            this.operateAdapters = new List<PiPiCSharpOperateAdapter>();
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Invoke c++ PiPiMultiOperator constructor.
        /// </summary>
        /// <returns>PiPiMultiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "CreatePiPiMultiOperator")]
        internal static extern IntPtr CreatePiPiMultiOperator();

        /// <summary>
        /// Invoke c++ PiPiMultiOperator destructor.
        /// </summary
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiMultiOperator")]
        internal static extern void DeletePiPiMultiOperator(IntPtr cMultiOp);

        /// <summary>
        /// Invoke c++ PiPiMultiOperator Add.
        /// </summary
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <param name="pdfBytes">The PDF binary bytes.</param>
        /// <param name="pdfSize">The PDF binary size.</param>
        /// <returns>The index of PDF.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiMultiOperatorAdd")]
        internal static extern int PiPiMultiOperatorAdd(IntPtr cMultiOp, byte[] pdfBytes, int pdfSize);

        /// <summary>
        /// Invoke c++ PiPiMultiOperator GetPointer.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <param name="index">The index of PDF.</param>
        /// <returns>PiPiOperator instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiMultiOperatorGetOperator")]
        internal static extern IntPtr PiPiMultiOperatorGetOperator(IntPtr cMultiOp, int index);

        /// <summary>
        /// Invoke c++ PiPiMultiOperator GetPager.
        /// </summary>
        /// <param name="cMultiOp">The PiPiMultiOperator instance pointer.</param>
        /// <returns>PiPiPager instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiMultiOperatorGetPager")]
        internal static extern IntPtr PiPiMultiOperatorGetPager(IntPtr cMultiOp);

        /// <summary>
        /// Add PDF to multi operator.
        /// </summary>
        /// <param name="pdfBytes">The PDF binary bytes.</param>
        /// <returns>The added index.</returns>
        /// <exception cref="PiPiCSharpMultiOperateException">Multi operate exception.</exception>
        internal int Add(byte[] pdfBytes)
        {
            try
            {
                int cIndex = PiPiMultiOperatorAdd(this.cMultiOp, pdfBytes, pdfBytes.Length);
                int index = this.operateAdapters.Count;

                IntPtr cOp = PiPiMultiOperatorGetOperator(this.cMultiOp, cIndex);
                PiPiCSharpOperateAdapter opAdapter = new PiPiCSharpOperateAdapter(cOp);

                this.operateAdapters.Add(opAdapter);
                this.operateAdapterMap.Add(index, cIndex);

                return index;
            }
            catch (Exception e)
            {
                throw new PiPiCSharpMultiOperateException(PiPiCSharpMultiOperateException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
        }

        /// <summary>
        /// Get operator by index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The operator</returns>
        /// <exception cref="PiPiCSharpMultiOperateException">Multi operate exception.</exception>
        internal PiPiCSharpOperateAdapter GetOperator(int index)
        {
            try
            {
                return this.operateAdapters[index];
            }
            catch (Exception e)
            {
                throw new PiPiCSharpMultiOperateException(PiPiCSharpMultiOperateException.PiPiCSharpEditExceptionCode.Unknown, e);
            }
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
                    DeletePiPiMultiOperator(this.cMultiOp);
                }

                this.disposedValue = true;
            }
        }
    }
}
