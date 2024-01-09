// <copyright file="PiPiCSharpPager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using System;
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
