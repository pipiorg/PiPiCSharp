// <copyright file="PiPiCSharpMultiOperator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using System.Collections.Generic;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// The PDF multi operator.
    /// </summary>
    internal class PiPiCSharpMultiOperator : IDisposable
    {
        private readonly PiPiCSharpMultiOperateAdapter adapter;
        private readonly Dictionary<int, int> operatorMap;
        private readonly List<PiPiCSharpOperator> operators;
        private readonly PiPiCSharpPager pager;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpMultiOperator"/> class.
        /// </summary>
        public PiPiCSharpMultiOperator()
        {
            this.adapter = new PiPiCSharpMultiOperateAdapter();

            PiPiCSharpPageAdapter pageAdapter = this.adapter.GetPager();
            this.pager = new PiPiCSharpPager(pageAdapter);

            this.operators = new List<PiPiCSharpOperator>();
            this.operatorMap = new Dictionary<int, int>();
        }

        /// <summary>
        /// Add PDF to multi operators.
        /// </summary>
        /// <param name="pdfBytes">The PDF binary bytes.</param>
        /// <returns>The added index.</returns>
        public int Add(byte[] pdfBytes)
        {
            int index = this.adapter.Add(pdfBytes);
            int opIndex = this.operators.Count;

            PiPiCSharpOperateAdapter opAdapter = this.adapter.GetOperator(index);
            PiPiCSharpOperator op = new PiPiCSharpOperator(opAdapter);

            this.operators.Add(op);
            this.operatorMap.Add(opIndex, index);

            return opIndex;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Get operator by index.
        /// </summary>
        /// <param name="index">The PDF index.</param>
        /// <returns>The operator.</returns>
        public PiPiCSharpOperator GetOperator(int index)
        {
            return this.operators[index];
        }

        /// <summary>
        /// Get the pager.
        /// </summary>
        /// <returns>The pager.</returns>
        public PiPiCSharpPager GetPager()
        {
            return this.pager;
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
