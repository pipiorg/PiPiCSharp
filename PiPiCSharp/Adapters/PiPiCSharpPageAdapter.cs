// <copyright file="PiPiCSharpPageAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;

    /// <summary>
    /// The PDF page adapter.
    /// </summary>
    internal class PiPiCSharpPageAdapter : IDisposable
    {
        private readonly IntPtr cPager;
        private bool disposedValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpPageAdapter"/> class.
        /// </summary>
        /// <param name="cPager">The PiPiPager instance pointer.</param>
        internal PiPiCSharpPageAdapter(IntPtr cPager)
        {
            this.cPager = cPager;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
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
                }

                this.disposedValue = true;
            }
        }
    }
}
