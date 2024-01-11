// <copyright file="PiPiCSharpPageInvoker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Invokers
{
    using System;
    using PiPiCSharp.Natives;
    using PiPiCSharp.Utils;

    /// <summary>
    /// Invoker for PiPiPageWrapper.
    /// </summary>
    internal static class PiPiCSharpPageInvoker
    {
        /// <summary>
        /// Invoke PiPiPageWrapper CreatePiPiPagerMergeIndexs.
        /// </summary>
        /// <returns>The merge index list pointer.</returns>
        internal static IntPtr InvokeCreatePiPiPagerMergeIndexs()
        {
            return PiPiCSharpDelegateInvoker.Invoke(PiPiPageWrapper.CreatePiPiPagerMergeIndexs);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper DeletePiPiPager.
        /// </summary>
        /// <param name="cPager">PiPiPager instance pointer.</param>
        internal static void InvokeDeletePiPiPager(IntPtr cPager)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.DeletePiPiPager, cPager);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper DeletePiPiPagerMerge.
        /// </summary>
        /// <param name="cMerged">The merged instance pointer.</param>
        internal static void InvokeDeletePiPiPagerMerge(IntPtr cMerged)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.DeletePiPiPagerMerge, cMerged);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper DeletePiPiPagerMergeIndexs.
        /// </summary>
        /// <param name="cMergeIndexs">The merge index list pointer.</param>
        internal static void InvokeDeletePiPiPagerMergeIndexs(IntPtr cMergeIndexs)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.DeletePiPiPagerMergeIndexs, cMergeIndexs);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper DeletePiPiPagerSplit.
        /// </summary>
        /// <param name="split">The splitted instance pointer.</param>
        internal static void InvokeDeletePiPiPagerSplit(IntPtr split)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.DeletePiPiPagerSplit, split);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper DeletePiPiPagerSplitItem.
        /// </summary>
        /// <param name="splitItem">The splitted item instance pointer.</param>
        internal static void InvokeDeletePiPiPagerSplitItem(IntPtr splitItem)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.DeletePiPiPagerSplitItem, splitItem);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerAddMergeIndex.
        /// </summary>
        /// <param name="cMergeIndexs">The merge index list pointer.</param>
        /// <param name="mergeIndex">The merge index to add.</param>
        internal static void InvokePiPiPagerAddMergeIndex(IntPtr cMergeIndexs, uint mergeIndex)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.PiPiPagerAddMergeIndex, cMergeIndexs, mergeIndex);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerCopyMerge.
        /// </summary>
        /// <param name="cMerged">The merged instance pointer.</param>
        /// <param name="des">The destination to copy.</param>
        internal static void InvokePiPiPagerCopyMerge(IntPtr cMerged, byte[] des)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.PiPiPagerCopyMerge, cMerged, des);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerCopySplitItem.
        /// </summary>
        /// <param name="splitItem">The splitted item instance pointer.</param>
        /// <param name="des">The destination to copy.</param>
        internal static void InvokePiPiPagerCopySplitItem(IntPtr splitItem, byte[] des)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToVoidResult(PiPiPageWrapper.PiPiPagerCopySplitItem, splitItem, des);
            PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerGetSplitItem.
        /// </summary>
        /// <param name="split">The splitted instance pointer.</param>
        /// <param name="index">The item index of splitted.</param>
        /// <returns>The splitted item instance pointer.</returns>
        internal static IntPtr InvokePiPiPagerGetSplitItem(IntPtr split, uint index)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiPageWrapper.PiPiPagerGetSplitItem, split, index);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerMerge.
        /// </summary>
        /// <param name="cPager">PiPiPager instance pointer.</param>
        /// <param name="cMergeIndexs">The merge index list pointer.</param>
        /// <returns>The merged instance pointer.</returns>
        internal static IntPtr InvokePiPiPagerMerge(IntPtr cPager, IntPtr cMergeIndexs)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiPageWrapper.PiPiPagerMerge, cPager, cMergeIndexs);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerMergeSize.
        /// </summary>
        /// <param name="cMerged">The merged instance pointer.</param>
        /// <returns>The size of merged instance pointer.</returns>
        internal static uint InvokePiPiPagerMergeSize(IntPtr cMerged)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiPageWrapper.PiPiPagerMergeSize, cMerged);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerSplit.
        /// </summary>
        /// <param name="cPager">PiPiPager instance pointer.</param>
        /// <param name="index">The target index of PDF.</param>
        /// <param name="instruction">The split instruction.</param>
        /// <returns>The splitted instance pointer.</returns>
        internal static IntPtr InvokePiPiPagerSplit(IntPtr cPager, uint index, string instruction)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiPageWrapper.PiPiPagerSplit, cPager, index, instruction);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerSplitItemSize.
        /// </summary>
        /// <param name="splitItem">The splitted item instance pointer.</param>
        /// <returns>The splitted item size.</returns>
        internal static uint InvokePiPiPagerSplitItemSize(IntPtr splitItem)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiPageWrapper.PiPiPagerSplitItemSize, splitItem);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }

        /// <summary>
        /// Invoke PiPiPageWrapper PiPiPagerSplitSize.
        /// </summary>
        /// <param name="split">The splitted instance pointer.</param>
        /// <returns>The splitted size.</returns>
        internal static uint InvokePiPiPagerSplitSize(IntPtr split)
        {
            var resultDelegate = PiPiCSharpDelegateTransformer.TransformParamsToResult(PiPiPageWrapper.PiPiPagerSplitSize, split);
            return PiPiCSharpDelegateInvoker.Invoke(resultDelegate);
        }
    }
}
