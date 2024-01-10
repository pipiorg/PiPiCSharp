#include "pch.h"
#include "PiPiExtractWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractor(int* code, int* exCode, int* exSubCode, PiPiExtractor* extractor) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete extractor;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPages(int* code, int* exCode, int* exSubCode, std::vector<const PiPiPage*>* extractedPages) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete extractedPages;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPage(int* code, int* exCode, int* exSubCode, const PiPiPage* extractedPage) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete extractedPage;
    });
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedPagesSize(int* code, int* exCode, int* exSubCode, std::vector<const PiPiPage*>* extractedPages) {
  return handleException<unsigned int>(code, exCode, exSubCode, [&]() {
    return extractedPages->size();
    });
}

PIPI_CSHARP_WRAPPER_API const PiPiPage* CALLING_CONVENTION PiPiExtractorGetExtractedPage(int* code, int* exCode, int* exSubCode, std::vector<const PiPiPage*>* extractedPages, size_t index) {
  return handleException<const PiPiPage*>(code, exCode, exSubCode, [&]() {
    return extractedPages->at(index);
    });
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageWidth(int* code, int* exCode, int* exSubCode, const PiPiPage* extractedPage) {
  return handleException<double>(code, exCode, exSubCode, [&]() {
    return extractedPage->width;
    });
}
PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageHeight(int* code, int* exCode, int* exSubCode, const PiPiPage* extractedPage) {
  return handleException<double>(code, exCode, exSubCode, [&]() {
    return extractedPage->height;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedFields(int* code, int* exCode, int* exSubCode, std::vector<const PiPiField*>* extractedFields) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete extractedFields;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedField(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete extractedField;
    });
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedFieldsSize(int* code, int* exCode, int* exSubCode, std::vector<const PiPiField*>* extractedFields) {
  return handleException<unsigned int>(code, exCode, exSubCode, [&]() {
    return extractedFields->size();
    });
}

PIPI_CSHARP_WRAPPER_API const PiPiField* CALLING_CONVENTION PiPiExtractorGetExtractedField(int* code, int* exCode, int* exSubCode, std::vector<const PiPiField*>* extractedFields, size_t index) {
  return handleException<const PiPiField*>(code, exCode, exSubCode, [&]() {
    return extractedFields->at(index);
    });
}

PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldName(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<char*>(code, exCode, exSubCode, [&]() {
    const std::string name = extractedField->name;
    char* cName = new char[name.length() + 1];
    strcpy(cName, name.c_str());
    return cName;
    });
}

PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontName(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<char*>(code, exCode, exSubCode, [&]() {
    const std::string fontName = extractedField->fontName;
    char* cFontName = new char[fontName.length() + 1];
    strcpy(cFontName, fontName.c_str());
    return cFontName;
    });
}

PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontSize(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<float>(code, exCode, exSubCode, [&]() {
    return extractedField->fontSize;
    });
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldType(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<unsigned int>(code, exCode, exSubCode, [&]() {
    switch (extractedField->type) {
    case PiPiFieldType::TextBox:
      return 0;
    case PiPiFieldType::CheckBox:
      return 1;
    case PiPiFieldType::Unknown:
    default:
      return 2;
    }
    });
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldPageIndex(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<unsigned int>(code, exCode, exSubCode, [&]() {
    return extractedField->pageIndex;
    });
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldWidth(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<double>(code, exCode, exSubCode, [&]() {
    return extractedField->width;
    });
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldHeight(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<double>(code, exCode, exSubCode, [&]() {
    return extractedField->height;
    });
}
PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldX(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<double>(code, exCode, exSubCode, [&]() {
    return extractedField->x;
    });
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldY(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField) {
  return handleException<double>(code, exCode, exSubCode, [&]() {
    return extractedField->y;
    });
}

PIPI_CSHARP_WRAPPER_API std::vector<const PiPiPage*>* CALLING_CONVENTION PiPiExtractorExtractPage(int* code, int* exCode, int* exSubCode, PiPiExtractor* extractor) {
  return handleException<std::vector<const PiPiPage*>*>(code, exCode, exSubCode, [&]() {
    return extractor->ExtractPage();
    });
}

PIPI_CSHARP_WRAPPER_API std::vector<const PiPiField*>* CALLING_CONVENTION PiPiExtractorExtractField(int* code, int* exCode, int* exSubCode, PiPiExtractor* extractor) {
  return handleException<std::vector<const PiPiField*>*>(code, exCode, exSubCode, [&]() {
    return extractor->ExtractField();
    });
}
