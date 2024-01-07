// <copyright file="PiPiCSharpEditAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;

    /// <summary>
    /// PDF edit adapter.
    /// </summary>
    internal class PiPiCSharpEditAdapter
    {
        private readonly IntPtr cEditor;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpEditAdapter"/> class.
        /// </summary>
        /// <param name="cEditor">The PiPiEditor instance pointer.</param>
        internal PiPiCSharpEditAdapter(IntPtr cEditor)
        {
            this.cEditor = cEditor;
        }
    }
}
