// <copyright file="PiPiCSharpPageAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Adapters
{
    using System;
    using System.Collections.Generic;
    using PiPiCSharp.Wrappers;

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
            IntPtr cMergeIndexs = PiPiPageWrapper.CreatePiPiPagerMergeIndexs();

            for (int i = 0; i < indexs.Count; i++)
            {
                int index = indexs[i];
                PiPiPageWrapper.PiPiPagerAddMergeIndex(cMergeIndexs, index);
            }

            IntPtr cMerged = PiPiPageWrapper.PiPiPagerMerge(this.cPager, cMergeIndexs);
            int cMergedSize = PiPiPageWrapper.PiPiPagerMergeSize(cMerged);

            byte[] merged = new byte[cMergedSize];
            PiPiPageWrapper.PiPiPagerCopyMerge(cMerged, merged);

            PiPiPageWrapper.DeletePiPiPagerMergeIndexs(cMergeIndexs);
            PiPiPageWrapper.DeletePiPiPagerMerge(cMerged);

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
            var splitted = new List<byte[]>();

            IntPtr cSplitted = PiPiPageWrapper.PiPiPagerSplit(this.cPager, index, instruction);

            int splittedSize = PiPiPageWrapper.PiPiPagerSplitSize(cSplitted);
            for (int splittedIndex = 0; splittedIndex < splittedSize; splittedIndex++)
            {
                IntPtr cSplittedItem = PiPiPageWrapper.PiPiPagerGetSplitItem(cSplitted, splittedIndex);

                int splittedItemSize = PiPiPageWrapper.PiPiPagerSplitItemSize(cSplittedItem);
                byte[] splittedItem = new byte[splittedItemSize];

                PiPiPageWrapper.PiPiPagerCopySplitItem(cSplittedItem, splittedItem);
                PiPiPageWrapper.DeletePiPiPagerSplitItem(cSplittedItem);

                splitted.Add(splittedItem);
            }

            PiPiPageWrapper.DeletePiPiPagerSplit(cSplitted);

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
                    PiPiPageWrapper.DeletePiPiPager(this.cPager);
                }

                this.disposedValue = true;
            }
        }
    }
}
