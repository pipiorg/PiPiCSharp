// <copyright file="PiPiPageWrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Wrappers
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Wrapper for PiPiPager.
    /// </summary>
    internal static class PiPiPageWrapper
    {
        /// <summary>
        /// Invoke c++ PiPiPager destructor.
        /// </summary>
        /// <param name="cPager">PiPiPager instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiPager")]
        internal static extern void DeletePiPiPager(IntPtr cPager);

        /// <summary>
        /// Invoke c++ PiPiPager to create a merge index list.
        /// </summary>
        /// <returns>The merge index list pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "CreatePiPiPagerMergeIndexs")]
        internal static extern IntPtr CreatePiPiPagerMergeIndexs();

        /// <summary>
        /// Invoke c++ PiPiPager to add merge index to a merge index list.
        /// </summary>
        /// <param name="cMergeIndexs">The merge index list pointer.</param>
        /// <param name="mergeIndex">The merge index to add.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerAddMergeIndex")]
        internal static extern void PiPiPagerAddMergeIndex(IntPtr cMergeIndexs, int mergeIndex);

        /// <summary>
        /// Invoke c++ PiPiPager to add merge index to a merge index list.
        /// </summary>
        /// <param name="cMergeIndexs">The merge index list pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiPagerMergeIndexs")]
        internal static extern void DeletePiPiPagerMergeIndexs(IntPtr cMergeIndexs);

        /// <summary>
        /// Invoke c++ PiPiPager Merge.
        /// </summary>
        /// <param name="cPager">PiPiPager instance pointer.</param>
        /// <param name="cMergeIndexs">The merge index list pointer.</param>
        /// <returns>The merged instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerMerge")]
        internal static extern IntPtr PiPiPagerMerge(IntPtr cPager, IntPtr cMergeIndexs);

        /// <summary>
        /// Invoke c++ PiPiPager to get merged size.
        /// </summary>
        /// <param name="cMerged">The merged instance pointer.</param>
        /// <returns>The size of merged instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerMergeSize")]
        internal static extern int PiPiPagerMergeSize(IntPtr cMerged);

        /// <summary>
        /// Invoke c++ PiPiPager to copy merged.
        /// </summary>
        /// <param name="cMerged">The merged instance pointer.</param>
        /// <param name="des">The destination to copy.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerCopyMerge")]
        internal static extern void PiPiPagerCopyMerge(IntPtr cMerged, byte[] des);

        /// <summary>
        /// Invoke c++ PiPiPager to release merged.
        /// </summary>
        /// <param name="cMerged">The merged instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiPagerMerge")]
        internal static extern void DeletePiPiPagerMerge(IntPtr cMerged);

        /// <summary>
        /// Invoke c++ PiPiPager Split.
        /// </summary>
        /// <param name="cPager">PiPiPager instance pointer.</param>
        /// <param name="index">The target index of PDF.</param>
        /// <param name="instruction">The split instruction.</param>
        /// <returns>The splitted instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerSplit")]
        internal static extern IntPtr PiPiPagerSplit(IntPtr cPager, int index, string instruction);

        /// <summary>
        /// Invoke c++ PiPiPager get splitted size.
        /// </summary>
        /// <param name="split">The splitted instance pointer.</param>
        /// <returns>The splitted size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerSplitSize")]
        internal static extern int PiPiPagerSplitSize(IntPtr split);

        /// <summary>
        /// Invoke c++ PiPiPager get splitted item.
        /// </summary>
        /// <param name="split">The splitted instance pointer.</param>
        /// <param name="index">The item index of splitted.</param>
        /// <returns>The splitted item instance pointer.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerGetSplitItem")]
        internal static extern IntPtr PiPiPagerGetSplitItem(IntPtr split, int index);

        /// <summary>
        /// Invoke c++ PiPiPager get the splitted item size.
        /// </summary>
        /// <param name="splitItem">The splitted item instance pointer.</param>
        /// <returns>The splitted item size.</returns>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerSplitItemSize")]
        internal static extern int PiPiPagerSplitItemSize(IntPtr splitItem);

        /// <summary>
        /// Invoke c++ PiPiPager copy the splitted item.
        /// </summary>
        /// <param name="splitItem">The splitted item instance pointer.</param>
        /// <param name="des">The destination to copy.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "PiPiPagerCopySplitItem")]
        internal static extern void PiPiPagerCopySplitItem(IntPtr splitItem, byte[] des);

        /// <summary>
        /// Invoke c++ PiPiPager release split.
        /// </summary>
        /// <param name="split">The splitted instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiPagerSplit")]
        internal static extern void DeletePiPiPagerSplit(IntPtr split);

        /// <summary>
        /// Invoke c++ PiPiPager release split item.
        /// </summary>
        /// <param name="splitItem">The splitted item instance pointer.</param>
        [DllImport(PiPiCSharpConstants.DllName, CallingConvention = PiPiCSharpConstants.CC, CharSet = PiPiCSharpConstants.CS, EntryPoint = "DeletePiPiPagerSplitItem")]
        internal static extern void DeletePiPiPagerSplitItem(IntPtr splitItem);
    }
}
