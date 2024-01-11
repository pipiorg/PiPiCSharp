// <copyright file="PiPiCSharpPageAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using PiPiCSharp.Invokers;
    using PiPiCSharp.Natives;

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
        /// Merge specific index PDF.
        /// </summary>
        /// <param name="indexs">The index of PDF.</param>
        /// <returns>The merged PDF binary bytes.</returns>
        internal byte[] Merge(List<int> indexs)
        {
            IntPtr cMergeIndexs = PiPiCSharpPageInvoker.InvokeCreatePiPiPagerMergeIndexs();

            for (int i = 0; i < indexs.Count; i++)
            {
                int index = indexs[i];
                PiPiCSharpPageInvoker.InvokePiPiPagerAddMergeIndex(cMergeIndexs, Convert.ToUInt32(index));
            }

            IntPtr cMerged = PiPiCSharpPageInvoker.InvokePiPiPagerMerge(this.cPager, cMergeIndexs);
            uint cMergedSize = PiPiCSharpPageInvoker.InvokePiPiPagerMergeSize(cMerged);

            byte[] merged = new byte[cMergedSize];
            PiPiCSharpPageInvoker.InvokePiPiPagerCopyMerge(cMerged, merged);

            PiPiCSharpPageInvoker.InvokeDeletePiPiPagerMergeIndexs(cMergeIndexs);
            PiPiCSharpPageInvoker.InvokeDeletePiPiPagerMerge(cMerged);

            return merged;
        }

        /// <summary>
        /// Split PDF.
        /// </summary>
        /// <param name="index">The index of PDF.</param>
        /// <param name="instruction">The instruction to split.</param>
        /// <returns>The splitted PDF binary bytes.</returns>
        internal List<byte[]> Split(int index, string instruction)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            uint uIndex = Convert.ToUInt32(index);

            var splitted = new List<byte[]>();

            IntPtr cSplitted = PiPiCSharpPageInvoker.InvokePiPiPagerSplit(this.cPager, uIndex, instruction);

            uint splittedSize = PiPiCSharpPageInvoker.InvokePiPiPagerSplitSize(cSplitted);
            for (int splittedIndex = 0; splittedIndex < splittedSize; splittedIndex++)
            {
                IntPtr cSplittedItem = PiPiCSharpPageInvoker.InvokePiPiPagerGetSplitItem(cSplitted, Convert.ToUInt32(splittedIndex));

                uint splittedItemSize = PiPiCSharpPageInvoker.InvokePiPiPagerSplitItemSize(cSplittedItem);
                byte[] splittedItem = new byte[splittedItemSize];

                PiPiCSharpPageInvoker.InvokePiPiPagerCopySplitItem(cSplittedItem, splittedItem);
                PiPiCSharpPageInvoker.InvokeDeletePiPiPagerSplitItem(cSplittedItem);

                splitted.Add(splittedItem);
            }

            PiPiCSharpPageInvoker.InvokeDeletePiPiPagerSplit(cSplitted);

            return splitted;
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
                    PiPiCSharpPageInvoker.InvokeDeletePiPiPager(this.cPager);
                }

                this.disposedValue = true;
            }
        }
    }
}
