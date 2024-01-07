// <copyright file="PiPiCSharpFontManagerAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;

    /// <summary>
    /// PDF font manager adapter.
    /// </summary>
    internal class PiPiCSharpFontManageAdapter
    {
        private readonly IntPtr cFontManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpFontManageAdapter"/> class.
        /// </summary>
        /// <param name="cFontManager">The PiPiFontManager instance pointer.</param>
        internal PiPiCSharpFontManageAdapter(IntPtr cFontManager)
        {
            this.cFontManager = cFontManager;
        }
    }
}
