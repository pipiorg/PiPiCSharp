// <copyright file="PiPiCSharpExceptionDispatcher.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PiPiCSharp.Utils
{
    using PiPiCSharp.Exceptions;

    /// <summary>
    /// Exception dispatcher.
    /// </summary>
    internal static class PiPiCSharpExceptionDispatcher
    {
        /// <summary>
        /// Dispatch error.
        /// </summary>
        /// <param name="code">The return code.</param>
        /// <param name="exCode">The return exception code.</param>
        /// <param name="exSubCode">The return exception sub code.</param>
        internal static void Dispatch(int code, int exCode, int exSubCode)
        {
            if (code != 0)
            {
                return;
            }

            switch (exCode)
            {
                case 1:
                    DispatchAppearanceException(exSubCode);
                    break;

                case 2:
                    DispatchEditFieldException(exSubCode);
                    break;

                case 3:
                    DispatchExtractException(exSubCode);
                    break;

                case 4:
                    DispatchFieldCompatibliltyException(exSubCode);
                    break;

                case 5:
                    DispatchFillFieldException(exSubCode);
                    break;

                case 6:
                    DispatchFontManageException(exSubCode);
                    break;

                case 7:
                    DispatchManageFieldException(exSubCode);
                    break;

                case 8:
                    DispatchMultiOperateException(exSubCode);
                    break;

                case 9:
                    DispatchPageException(exSubCode);
                    break;

                default:
                    throw new PiPiCSharpUnknownException("Unknown exception code exception");
            }
        }

        private static void DispatchAppearanceException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpAppearanceException(PiPiCSharpAppearanceException.PiPiCSharpAppearanceExceptionCode.CreateFormObjectFromAppearanceFail);

                case 2:
                    throw new PiPiCSharpAppearanceException(PiPiCSharpAppearanceException.PiPiCSharpAppearanceExceptionCode.UnsupportedFieldType);

                case 0:
                default:
                    throw new PiPiCSharpAppearanceException(PiPiCSharpAppearanceException.PiPiCSharpAppearanceExceptionCode.Unknown);
            }
        }

        private static void DispatchEditFieldException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpEditFieldException(PiPiCSharpEditFieldException.PiPiCSharpEditFieldExceptionCode.InOperable);

                case 2:
                    throw new PiPiCSharpEditFieldException(PiPiCSharpEditFieldException.PiPiCSharpEditFieldExceptionCode.NotImplementate);

                case 3:
                    throw new PiPiCSharpEditFieldException(PiPiCSharpEditFieldException.PiPiCSharpEditFieldExceptionCode.MultilineNotSupported);

                case 4:
                    throw new PiPiCSharpEditFieldException(PiPiCSharpEditFieldException.PiPiCSharpEditFieldExceptionCode.NotRegisterFont);

                case 5:
                    throw new PiPiCSharpEditFieldException(PiPiCSharpEditFieldException.PiPiCSharpEditFieldExceptionCode.InvalidColor);

                case 0:
                default:
                    throw new PiPiCSharpEditFieldException(PiPiCSharpEditFieldException.PiPiCSharpEditFieldExceptionCode.Unknown);
            }
        }

        private static void DispatchExtractException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpExtractException(PiPiCSharpExtractException.PiPiCSharpExtractExceptionCode.InOperable);

                case 0:
                default:
                    throw new PiPiCSharpExtractException(PiPiCSharpExtractException.PiPiCSharpExtractExceptionCode.Unknown);
            }
        }

        private static void DispatchFieldCompatibliltyException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpFieldCompatibilityException(PiPiCSharpFieldCompatibilityException.PiPiCSharpFieldCompatibilityExceptionCode.FixDotFieldFail);

                case 0:
                default:
                    throw new PiPiCSharpFieldCompatibilityException(PiPiCSharpFieldCompatibilityException.PiPiCSharpFieldCompatibilityExceptionCode.Unknown);
            }
        }

        private static void DispatchFillFieldException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpFillFieldException(PiPiCSharpFillFieldException.PiPiCSharpFillFieldExceptionCode.InOperable);

                case 2:
                    throw new PiPiCSharpFillFieldException(PiPiCSharpFillFieldException.PiPiCSharpFillFieldExceptionCode.UnsupportedPdfFieldType);

                case 0:
                default:
                    throw new PiPiCSharpFillFieldException(PiPiCSharpFillFieldException.PiPiCSharpFillFieldExceptionCode.Unknown);
            }
        }

        private static void DispatchFontManageException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpFontManageException(PiPiCSharpFontManageException.PiPiCSharpFontManageExceptionCode.InOperable);

                case 0:
                default:
                    throw new PiPiCSharpFontManageException(PiPiCSharpFontManageException.PiPiCSharpFontManageExceptionCode.Unknown);
            }
        }

        private static void DispatchManageFieldException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.InvalidPdfFieldObject);

                case 2:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.InvalidPdfFieldType);

                case 3:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.InvalidRestrictFieldOperation);

                case 4:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.InvalidRealStatus);

                case 5:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.InvalidPageIndex);

                case 6:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.DuplicateFieldExists);

                case 7:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.UnsupportRemoveFakeField);

                case 8:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.UnsupportRenameFakeField);

                case 0:
                default:
                    throw new PiPiCSharpManageFieldException(PiPiCSharpManageFieldException.PiPiCSharpManageExceptionCode.Unknown);
            }
        }

        private static void DispatchMultiOperateException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpMultiOperateException(PiPiCSharpMultiOperateException.PiPiCSharpEditExceptionCode.IndexOutOfRange);

                case 0:
                default:
                    throw new PiPiCSharpMultiOperateException(PiPiCSharpMultiOperateException.PiPiCSharpEditExceptionCode.Unknown);
            }
        }

        private static void DispatchPageException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpEditExceptionCode.InOperable);

                case 2:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpEditExceptionCode.InvalidSplitInstruction);

                case 3:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpEditExceptionCode.IndexOutOfRange);

                case 0:
                default:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpEditExceptionCode.Unknown);
            }
        }
    }
}
