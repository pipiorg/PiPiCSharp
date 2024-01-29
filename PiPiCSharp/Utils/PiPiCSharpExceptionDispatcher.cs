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
                    DispatchManageAppearanceException(exSubCode);
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
                    DispatchFontRegisterException(exSubCode);
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

                case 10:
                    DispatchFieldStyleManageException(exSubCode);
                    break;

                case 11:
                    DispatchManageFlattenException(exSubCode);
                    break;

                default:
                    throw new PiPiCSharpUnknownException("Unknown exception code exception");
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

        private static void DispatchFieldStyleManageException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpFieldStyleManageException(PiPiCSharpFieldStyleManageException.PiPiCSharpFieldStyleManageExceptionCode.NotRegisterFont);

                case 2:
                    throw new PiPiCSharpFieldStyleManageException(PiPiCSharpFieldStyleManageException.PiPiCSharpFieldStyleManageExceptionCode.InvalidColor);

                case 3:
                    throw new PiPiCSharpFieldStyleManageException(PiPiCSharpFieldStyleManageException.PiPiCSharpFieldStyleManageExceptionCode.MultilineNotSupported);

                case 0:
                default:
                    throw new PiPiCSharpFieldStyleManageException(PiPiCSharpFieldStyleManageException.PiPiCSharpFieldStyleManageExceptionCode.Unknown);
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

        private static void DispatchFontRegisterException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpFontRegisterException(PiPiCSharpFontRegisterException.PiPiCSharpFontRegisterExceptionCode.InOperable);

                case 0:
                default:
                    throw new PiPiCSharpFontRegisterException(PiPiCSharpFontRegisterException.PiPiCSharpFontRegisterExceptionCode.Unknown);
            }
        }

        private static void DispatchManageAppearanceException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpManageAppearanceException(PiPiCSharpManageAppearanceException.PiPiCSharpManageAppearanceExceptionCode.UnsupportedFieldType);

                case 0:
                default:
                    throw new PiPiCSharpManageAppearanceException(PiPiCSharpManageAppearanceException.PiPiCSharpManageAppearanceExceptionCode.Unknown);
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

        private static void DispatchManageFlattenException(int exSubCode)
        {
            switch (exSubCode)
            {
                case 1:
                    throw new PiPiCSharpManageFlattenException(PiPiCSharpManageFlattenException.PiPiCSharpManageFlattenExceptionCode.CreateFormObjectFromAppearanceFail);

                case 0:
                default:
                    throw new PiPiCSharpManageFlattenException(PiPiCSharpManageFlattenException.PiPiCSharpManageFlattenExceptionCode.Unknown);
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
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpPageExceptionCode.InOperable);

                case 2:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpPageExceptionCode.InvalidSplitInstruction);

                case 3:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpPageExceptionCode.IndexOutOfRange);

                case 4:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpPageExceptionCode.MergeFieldConflict);

                case 0:
                default:
                    throw new PiPiCSharpPageException(PiPiCSharpPageException.PiPiCSharpPageExceptionCode.Unknown);
            }
        }
    }
}
