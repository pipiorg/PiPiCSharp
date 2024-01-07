// <copyright file="PiPiCSharpFillAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;

    /// <summary>
    /// PDF fill adapter.
    /// </summary>
    internal class PiPiCSharpFillAdapter
    {
        private readonly IntPtr cFiller;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFillAdapter"/> class.
        /// </summary>
        /// <param name="cFiller">The PiPiFiller instance pointer.</param>
        internal PiPiCSharpFillAdapter(IntPtr cFiller)
        {
            this.cFiller = cFiller;
        }
    }
}
