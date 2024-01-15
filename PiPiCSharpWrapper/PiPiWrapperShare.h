#pragma once

#include "pch.h"
#include "utf8.h"

static const std::map<unsigned int, PiPi::PiPiFieldType> FieldTypeMap = {
  { 0, PiPi::PiPiFieldType::TextBox },
  { 1, PiPi::PiPiFieldType::CheckBox },
  { 2, PiPi::PiPiFieldType::Unknown }
};

static const std::map<PiPi::PiPiFieldType, unsigned int> InvertFieldTypeMap = {
  { PiPi::PiPiFieldType::TextBox, 0 },
  { PiPi::PiPiFieldType::CheckBox, 1 },
  { PiPi::PiPiFieldType::Unknown, 2 }
};

static const std::map<unsigned int, PiPi::PiPiTextHorizontalAlignment> TextHorizontalAlignmentMap = {
  { 0, PiPi::PiPiTextHorizontalAlignment::Left },
  { 1, PiPi::PiPiTextHorizontalAlignment::Center },
  { 2, PiPi::PiPiTextHorizontalAlignment::Right },
};

static const std::map<PiPi::PiPiTextHorizontalAlignment, unsigned int> InvertTextHorizontalAlignmentMap = {
  { PiPi::PiPiTextHorizontalAlignment::Left, 0 },
  { PiPi::PiPiTextHorizontalAlignment::Center, 1 },
  { PiPi::PiPiTextHorizontalAlignment::Right, 2 },
};

static const unsigned int PiPiCSharpAppearanceExceptionCode = 1;
static const unsigned int PiPiCSharpAppearanceExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpAppearanceExceptionSubCodeCreateFormObjectFromAppearanceFail = 1;
static const unsigned int PiPiCSharpAppearanceExceptionSubCodeUnsupportedFieldType = 2;

static const unsigned int PiPiCSharpEditFieldExceptionCode = 2;
static const unsigned int PiPiCSharpEditFieldExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpEditFieldExceptionSubCodeInOperable = 1;
static const unsigned int PiPiCSharpEditFieldExceptionSubCodeNotImplementate = 2;

static const unsigned int PiPiCSharpExtractExceptionCode = 3;
static const unsigned int PiPiCSharpExtractExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpExtractExceptionSubCodeInOperable = 1;

static const unsigned int PiPiCSharpFieldCompatibilityExceptionCode = 4;
static const unsigned int PiPiCSharpFieldCompatibilityExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpFieldCompatibilityExceptionSubCodeFixDotFieldFail = 1;

static const unsigned int PiPiCSharpFillFieldExceptionCode = 5;
static const unsigned int PiPiCSharpFillFieldExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpFillFieldExceptionSubCodeInOperable = 1;
static const unsigned int PiPiCSharpFillFieldExceptionSubCodeUnsupportedPdfFieldType = 2;

static const unsigned int PiPiCSharpFontManageExceptionCode = 6;
static const unsigned int PiPiCSharpFontManageExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpFontManageExceptionSubCodeInOperable = 1;

static const unsigned int PiPiCSharpManageFieldExceptionCode = 7;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeInvalidPdfFieldObject = 1;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeInvalidPdfFieldType = 2;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeInvalidRestrictFieldOperation = 3;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeInvalidRealStatus = 4;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeInvalidPageIndex = 5;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeDuplicateFieldExists = 6;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeUnsupportRemoveFakeField = 7;
static const unsigned int PiPiCSharpManageFieldExceptionSubCodeUnsupportRenameFakeField = 8;

static const unsigned int PiPiCSharpMultiOperateExceptionCode = 8;
static const unsigned int PiPiCSharpMultiOperateExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpMultiOperateExceptionSubCodeIndexOutOfRange = 1;

static const unsigned int PiPiCSharpPageExceptionCode = 9;
static const unsigned int PiPiCSharpPageExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpPageExceptionSubCodeInOperable = 1;
static const unsigned int PiPiCSharpPageExceptionSubCodeInvalidSplitInstruction = 2;
static const unsigned int PiPiCSharpPageExceptionSubCodeIndexOutOfRange = 3;

static const unsigned int PiPiCSharpFieldStyleManageExceptionCode = 10;
static const unsigned int PiPiCSharpFieldStyleManageExceptionSubCodeUnknown = 0;
static const unsigned int PiPiCSharpFieldStyleManageExceptionSubCodeNotRegisterFont = 1;
static const unsigned int PiPiCSharpFieldStyleManageExceptionSubCodeInvalidColor = 2;
static const unsigned int PiPiCSharpFieldStyleManageExceptionSubCodeMultilineNotSupported = 3;

template<typename T>
T handleException(int* code, int* exCode, int* exSubCode, std::function<T()> func);

void handleVoidException(int* code, int* exCode, int* exSubCode, std::function<void()> func);

std::string wcharToUtf8String(const wchar_t* utf16);
