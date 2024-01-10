// <copyright file="PiPiCSharpPager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
    using System.Collections.Generic;
    using PiPiCSharp.Adapters;

    /// <summary>
    /// The PDF pager.
    /// </summary>
    public class PiPiCSharpPager : IDisposable
    {
        private readonly PiPiCSharpPageAdapter adapter;

        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpPager"/> class.
        /// </summary>
        /// <param name="adapter">The PDF page adapter.</param>
        internal PiPiCSharpPager(PiPiCSharpPageAdapter adapter)
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
        /// Merge PDF.
        /// </summary>
        /// <param name="indexs">The index of PDF.</param>
        /// <returns>The merged PDF binary bytes.</returns>
        public byte[] Merge(List<int> indexs)
        {
            return this.adapter.Merge(indexs);
        }

        /// <summary>
        /// Split PDF.
        /// </summary>
        /// <param name="index">The index of PDF.</param>
        /// <param name="instruction">The split instruction.</param>
        /// <returns>The splitted PDF binary bytes.</returns>
        public List<byte[]> Split(int index, string instruction)
        {
            return this.adapter.Split(index, instruction);
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
