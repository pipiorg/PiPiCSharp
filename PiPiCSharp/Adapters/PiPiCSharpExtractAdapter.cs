// <copyright file="PiPiCSharpExtractorAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;

    /// <summary>
    /// PDF extractor adapter.
    /// </summary>
    internal class PiPiCSharpExtractAdapter
    {
        private readonly IntPtr cExtractor;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpExtractAdapter"/> class.
        /// </summary>
        /// <param name="cExtractor">The PiPiExtractor instance pointer.</param>
        internal PiPiCSharpExtractAdapter(IntPtr cExtractor)
        {
            this.cExtractor = cExtractor;
        }
    }
}
