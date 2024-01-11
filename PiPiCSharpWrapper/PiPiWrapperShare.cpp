#include "pch.h"
#include "PiPiWrapperShare.h"

template<typename T>
T handleException(int* code, int* exCode, int* exSubCode, std::function<T()> func) {
  try {
    T res = func();

    *code = 1;
    *exCode = -1;
    *exSubCode = -1;

    return res;
  }
  catch (PiPi::PiPiAppearanceException& e) {
    *code = 0;
    *exCode = PiPiCSharpAppearanceExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiAppearanceException::CreateFormObjectFromAppearanceFail:
      *exSubCode = PiPiCSharpAppearanceExceptionSubCodeCreateFormObjectFromAppearanceFail;
      break;
    case PiPi::PiPiAppearanceException::UnsupportedFieldType:
      *exSubCode = PiPiCSharpAppearanceExceptionSubCodeUnsupportedFieldType;
      break;
    default:
      *exSubCode = PiPiCSharpAppearanceExceptionSubCodeUnknown;
    }

    return T();
  }
  catch (PiPi::PiPiEditFieldException& e) {
    *code = 0;
    *exCode = PiPiCSharpEditFieldExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiEditFieldException::InOperable:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeInOperable;
      break;
    case PiPi::PiPiEditFieldException::InvalidColor:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeInvalidColor;
      break;
    case PiPi::PiPiEditFieldException::MultilineNotSupported:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeMultilineNotSupported;
      break;
    case PiPi::PiPiEditFieldException::NotImplementate:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeNotImplementate;
      break;
    case PiPi::PiPiEditFieldException::NotRegisterFont:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeNotRegisterFont;
      break;
    default:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeUnknown;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiExtractException& e) {
    *code = 0;
    *exCode = PiPiCSharpExtractExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiExtractException::InOperable:
      *exSubCode = PiPiCSharpExtractExceptionSubCodeInOperable;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiFieldCompatibilityException& e) {
    *code = 0;
    *exCode = PiPiCSharpFieldCompatibilityExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiFieldCompatibilityException::FixDotFieldFail:
      *exSubCode = PiPiCSharpFieldCompatibilityExceptionSubCodeFixDotFieldFail;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiFillFieldException& e) {
    *code = 0;
    *exCode = PiPiCSharpFillFieldExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiFillFieldException::InOperable:
      *exSubCode = PiPiCSharpFillFieldExceptionSubCodeInOperable;
      break;
    case PiPi::PiPiFillFieldException::UnsupportedPdfFieldType:
      *exSubCode = PiPiCSharpFillFieldExceptionSubCodeUnsupportedPdfFieldType;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiFontManageException& e) {
    *code = 0;
    *exCode = PiPiCSharpFontManageExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiFontManageException::InOperable:
      *exSubCode = PiPiCSharpFontManageExceptionSubCodeInOperable;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiManageFieldException& e) {
    *code = 0;
    *exCode = PiPiCSharpManageFieldExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiManageFieldException::DuplicateFieldExists:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeDuplicateFieldExists;
      break;
    case PiPi::PiPiManageFieldException::InvalidPageIndex:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidPageIndex;
      break;
    case PiPi::PiPiManageFieldException::InvalidPdfFieldObject:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidPdfFieldObject;
      break;
    case PiPi::PiPiManageFieldException::InvalidPdfFieldType:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidPdfFieldType;
      break;
    case PiPi::PiPiManageFieldException::InvalidRealStatus:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidRealStatus;
      break;
    case PiPi::PiPiManageFieldException::InvalidRestrictFieldOperation:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidRestrictFieldOperation;
      break;
    case PiPi::PiPiManageFieldException::UnsupportRemoveFakeField:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeUnsupportRemoveFakeField;
      break;
    case PiPi::PiPiManageFieldException::UnsupportRenameFakeField:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeUnsupportRenameFakeField;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiMultiOperateException& e) {
    *code = 0;
    *exCode = PiPiCSharpMultiOperateExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiMultiOperateException::IndexOutOfRange:
      *exSubCode = PiPiCSharpMultiOperateExceptionSubCodeIndexOutOfRange;
      break;
    }

    return T();
  }
  catch (PiPi::PiPiPageException& e) {
    *code = 0;
    *exCode = PiPiCSharpPageExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiPageException::IndexOutOfRange:
      *exSubCode = PiPiCSharpPageExceptionSubCodeIndexOutOfRange;
      break;
    case PiPi::PiPiPageException::InOperable:
      *exSubCode = PiPiCSharpPageExceptionSubCodeInOperable;
      break;
    case PiPi::PiPiPageException::InvalidSplitInstruction:
      *exSubCode = PiPiCSharpPageExceptionSubCodeInvalidSplitInstruction;
      break;
    }

    return T();
  }
  catch (std::exception& e) {
    *code = 0;
    *exCode = -1;
    *exSubCode = -1;

    return T();
  }
}

void handleVoidException(int* code, int* exCode, int* exSubCode, std::function<void()> func) {
  try {
    func();

    *code = 1;
    *exCode = -1;
    *exSubCode = -1;
  }
  catch (PiPi::PiPiAppearanceException& e) {
    *code = 0;
    *exCode = PiPiCSharpAppearanceExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiAppearanceException::CreateFormObjectFromAppearanceFail:
      *exSubCode = PiPiCSharpAppearanceExceptionSubCodeCreateFormObjectFromAppearanceFail;
      break;
    case PiPi::PiPiAppearanceException::UnsupportedFieldType:
      *exSubCode = PiPiCSharpAppearanceExceptionSubCodeUnsupportedFieldType;
      break;
    default:
      *exSubCode = PiPiCSharpAppearanceExceptionSubCodeUnknown;
    }
  }
  catch (PiPi::PiPiEditFieldException& e) {
    *code = 0;
    *exCode = PiPiCSharpEditFieldExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiEditFieldException::InOperable:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeInOperable;
      break;
    case PiPi::PiPiEditFieldException::InvalidColor:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeInvalidColor;
      break;
    case PiPi::PiPiEditFieldException::MultilineNotSupported:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeMultilineNotSupported;
      break;
    case PiPi::PiPiEditFieldException::NotImplementate:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeNotImplementate;
      break;
    case PiPi::PiPiEditFieldException::NotRegisterFont:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeNotRegisterFont;
      break;
    default:
      *exSubCode = PiPiCSharpEditFieldExceptionSubCodeUnknown;
      break;
    }
  }
  catch (PiPi::PiPiExtractException& e) {
    *code = 0;
    *exCode = PiPiCSharpExtractExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiExtractException::InOperable:
      *exSubCode = PiPiCSharpExtractExceptionSubCodeInOperable;
      break;
    }
  }
  catch (PiPi::PiPiFieldCompatibilityException& e) {
    *code = 0;
    *exCode = PiPiCSharpFieldCompatibilityExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiFieldCompatibilityException::FixDotFieldFail:
      *exSubCode = PiPiCSharpFieldCompatibilityExceptionSubCodeFixDotFieldFail;
      break;
    }
  }
  catch (PiPi::PiPiFillFieldException& e) {
    *code = 0;
    *exCode = PiPiCSharpFillFieldExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiFillFieldException::InOperable:
      *exSubCode = PiPiCSharpFillFieldExceptionSubCodeInOperable;
      break;
    case PiPi::PiPiFillFieldException::UnsupportedPdfFieldType:
      *exSubCode = PiPiCSharpFillFieldExceptionSubCodeUnsupportedPdfFieldType;
      break;
    }
  }
  catch (PiPi::PiPiFontManageException& e) {
    *code = 0;
    *exCode = PiPiCSharpFontManageExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiFontManageException::InOperable:
      *exSubCode = PiPiCSharpFontManageExceptionSubCodeInOperable;
      break;
    }
  }
  catch (PiPi::PiPiManageFieldException& e) {
    *code = 0;
    *exCode = PiPiCSharpManageFieldExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiManageFieldException::DuplicateFieldExists:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeDuplicateFieldExists;
      break;
    case PiPi::PiPiManageFieldException::InvalidPageIndex:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidPageIndex;
      break;
    case PiPi::PiPiManageFieldException::InvalidPdfFieldObject:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidPdfFieldObject;
      break;
    case PiPi::PiPiManageFieldException::InvalidPdfFieldType:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidPdfFieldType;
      break;
    case PiPi::PiPiManageFieldException::InvalidRealStatus:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidRealStatus;
      break;
    case PiPi::PiPiManageFieldException::InvalidRestrictFieldOperation:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeInvalidRestrictFieldOperation;
      break;
    case PiPi::PiPiManageFieldException::UnsupportRemoveFakeField:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeUnsupportRemoveFakeField;
      break;
    case PiPi::PiPiManageFieldException::UnsupportRenameFakeField:
      *exSubCode = PiPiCSharpManageFieldExceptionSubCodeUnsupportRenameFakeField;
      break;
    }
  }
  catch (PiPi::PiPiMultiOperateException& e) {
    *code = 0;
    *exCode = PiPiCSharpMultiOperateExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiMultiOperateException::IndexOutOfRange:
      *exSubCode = PiPiCSharpMultiOperateExceptionSubCodeIndexOutOfRange;
      break;
    }
  }
  catch (PiPi::PiPiPageException& e) {
    *code = 0;
    *exCode = PiPiCSharpPageExceptionCode;

    switch (e.getCode()) {
    case PiPi::PiPiPageException::IndexOutOfRange:
      *exSubCode = PiPiCSharpPageExceptionSubCodeIndexOutOfRange;
      break;
    case PiPi::PiPiPageException::InOperable:
      *exSubCode = PiPiCSharpPageExceptionSubCodeInOperable;
      break;
    case PiPi::PiPiPageException::InvalidSplitInstruction:
      *exSubCode = PiPiCSharpPageExceptionSubCodeInvalidSplitInstruction;
      break;
    }
  }
  catch (std::exception& e) {
    *code = 0;
    *exCode = -1;
    *exSubCode = -1;
  }
}

template bool handleException<bool>(int* code, int* exCode, int* exSubCode, std::function<bool()> func);
template unsigned int handleException<unsigned int>(int* code, int* exCode, int* exSubCode, std::function<unsigned int()> func);
template float handleException<float>(int* code, int* exCode, int* exSubCode, std::function<float()> func);
template double handleException<double>(int* code, int* exCode, int* exSubCode, std::function<double()> func);
template size_t handleException<size_t>(int* code, int* exCode, int* exSubCode, std::function<size_t()> func);
template char* handleException<char*>(int* code, int* exCode, int* exSubCode, std::function<char* ()> func);

template vector<char>* handleException<vector<char>*>(int* code, int* exCode, int* exSubCode, std::function<vector<char>* ()> func);
template std::vector<std::vector<char>*>* handleException<std::vector<std::vector<char>*>*>(int* code, int* exCode, int* exSubCode, std::function<std::vector<std::vector<char>*>* ()> func);
template std::vector<const PiPi::PiPiPage*>* handleException<std::vector<const PiPi::PiPiPage*>*>(int* code, int* exCode, int* exSubCode, std::function<std::vector<const PiPi::PiPiPage*>* ()> func);
template std::vector<const PiPi::PiPiField*>* handleException<std::vector<const PiPi::PiPiField*>*>(int* code, int* exCode, int* exSubCode, std::function<std::vector<const PiPi::PiPiField*>* ()> func);
template std::vector<size_t>* handleException<std::vector<size_t>*>(int* code, int* exCode, int* exSubCode, std::function <std::vector<size_t>* ()> func);

template const PiPi::PiPiPage* handleException<const PiPi::PiPiPage*>(int* code, int* exCode, int* exSubCode, std::function<const PiPi::PiPiPage* ()> func);
template const PiPi::PiPiField* handleException<const PiPi::PiPiField*>(int* code, int* exCode, int* exSubCode, std::function<const PiPi::PiPiField* ()> func);

template PiPi::PiPiOperator* handleException<PiPi::PiPiOperator*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiOperator* ()> func);
template PiPi::PiPiMultiOperator* handleException<PiPi::PiPiMultiOperator*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiMultiOperator* ()> func);
template PiPi::PiPiPager* handleException<PiPi::PiPiPager*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiPager* ()> func);
template PiPi::PiPiEditor* handleException<PiPi::PiPiEditor*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiEditor* ()> func);
template PiPi::PiPiExtractor* handleException<PiPi::PiPiExtractor*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiExtractor* ()> func);
template PiPi::PiPiFontManager* handleException<PiPi::PiPiFontManager*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiFontManager* ()> func);
template PiPi::PiPiFiller* handleException<PiPi::PiPiFiller*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiFiller* ()> func);
