// <copyright file="PiPiCSharpOperator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp
{
    using PiPiCSharp.Adapters;

    /// <summary>
    /// PDF Operator.
    /// </summary>
    public class PiPiCSharpOperator
    {
        private readonly PiPiCSharpOperateAdapter adapter;

        /// <summary>
        /// Initializes a new instance of the <see cref="PiPiCSharpOperator"/> class.
        /// </summary>
        /// <param name="pdfBytes">The pdf binary bytes.</param>
        public PiPiCSharpOperator(byte[] pdfBytes)
        {
            this.adapter = new PiPiCSharpOperateAdapter(pdfBytes);
        }
    }
}
