#include "pch.h"
#include "PiPiExtractWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractor(PiPiExtractor* extractor) {
  delete extractor;
  extractor = nullptr;
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPages(std::vector<const PiPiPage*>* extractedPages) {
  delete extractedPages;
  extractedPages = nullptr;
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPage(const PiPiPage* extractedPage) {
  delete extractedPage;
  extractedPage = nullptr;
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedPagesSize(std::vector<const PiPiPage*>* extractedPages) {
  return extractedPages->size();
}

PIPI_CSHARP_WRAPPER_API const PiPiPage* CALLING_CONVENTION PiPiExtractorGetExtractedPage(std::vector<const PiPiPage*>* extractedPages, size_t index) {
  return extractedPages->at(index);
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageWidth(const PiPiPage* extractedPage) {
  return extractedPage->width;
}
PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageHeight(const PiPiPage* extractedPage) {
  return extractedPage->height;
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedFields(std::vector<const PiPiField*>* extractedFields) {
  delete extractedFields;
  extractedFields = nullptr;
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedField(const PiPiField* extractedField) {
  delete extractedField;
  extractedField = nullptr;
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedFieldsSize(std::vector<const PiPiField*>* extractedFields) {
  return extractedFields->size();
}

PIPI_CSHARP_WRAPPER_API const PiPiField* CALLING_CONVENTION PiPiExtractorGetExtractedField(std::vector<const PiPiField*>* extractedFields, size_t index) {
  return extractedFields->at(index);
}

PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldName(const PiPiField* extractedField) {
  const std::string name = extractedField->name;
  char* cName = new char[name.length() + 1];
  strcpy(cName, name.c_str());
  return cName;
}

PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontName(const PiPiField* extractedField) {
  const std::string fontName = extractedField->fontName;
  char* cFontName = new char[fontName.length() + 1];
  strcpy(cFontName, fontName.c_str());
  return cFontName;
}

PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontSize(const PiPiField* extractedField) {
  return extractedField->fontSize;
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldType(const PiPiField* extractedField) {
  switch (extractedField->type) {
  case PiPiFieldType::TextBox:
    return 0;
  case PiPiFieldType::CheckBox:
    return 1;
  case PiPiFieldType::Unknown:
  default:
    return 2;
  }
}

PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldPageIndex(const PiPiField* extractedField) {
  return extractedField->pageIndex;
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldWidth(const PiPiField* extractedField) {
  return extractedField->width;
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldHeight(const PiPiField* extractedField) {
  return extractedField->height;
}
PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldX(const PiPiField* extractedField) {
  return extractedField->x;
}

PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldY(const PiPiField* extractedField) {
  return extractedField->y;
}

PIPI_CSHARP_WRAPPER_API std::vector<const PiPiPage*>* CALLING_CONVENTION PiPiExtractorExtractPage(PiPiExtractor* extractor) {
  return extractor->ExtractPage();
}

PIPI_CSHARP_WRAPPER_API std::vector<const PiPiField*>* CALLING_CONVENTION PiPiExtractorExtractField(PiPiExtractor* extractor) {
  return extractor->ExtractField();
}
