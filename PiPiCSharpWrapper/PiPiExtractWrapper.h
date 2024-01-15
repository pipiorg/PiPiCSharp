#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractor(int* code, int* exCode, int* exSubCode, PiPiExtractor* extractor);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPages(int* code, int* exCode, int* exSubCode, std::vector<const PiPiPage*>* extractedPages);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPage(int* code, int* exCode, int* exSubCode, const PiPiPage* extractedPage);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedPagesSize(int* code, int* exCode, int* exSubCode, std::vector<const PiPiPage*>* extractedPages);
  PIPI_CSHARP_WRAPPER_API const PiPiPage* CALLING_CONVENTION PiPiExtractorGetExtractedPage(int* code, int* exCode, int* exSubCode, std::vector<const PiPiPage*>* extractedPages, size_t index);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageWidth(int* code, int* exCode, int* exSubCode, const PiPiPage* extractedPage);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageHeight(int* code, int* exCode, int* exSubCode, const PiPiPage* extractedPage);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedFields(int* code, int* exCode, int* exSubCode, std::vector<const PiPiField*>* extractedFields);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedField(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedFieldsSize(int* code, int* exCode, int* exSubCode, std::vector<const PiPiField*>* extractedFields);
  PIPI_CSHARP_WRAPPER_API const PiPiField* CALLING_CONVENTION PiPiExtractorGetExtractedField(int* code, int* exCode, int* exSubCode, std::vector<const PiPiField*>* extractedFields, size_t index);

  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldDefaultValue(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldName(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontName(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontSize(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldPageIndex(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldType(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldTextHorizontalAlignment(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiExtractorGetExtractedFieldMultiline(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiExtractorGetExtractedFieldBorderExists(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiExtractorGetExtractedFieldBackgroundExists(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldColorRed(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldColorGreen(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldColorBlue(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldBorderColorRed(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldBorderColorGreen(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldBorderColorBlue(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldBackgroundColorRed(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldBackgroundColorGreen(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldBackgroundColorBlue(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldWidth(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldHeight(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldX(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldY(int* code, int* exCode, int* exSubCode, const PiPiField* extractedField);

  PIPI_CSHARP_WRAPPER_API std::vector<const PiPiPage*>* CALLING_CONVENTION PiPiExtractorExtractPage(int* code, int* exCode, int* exSubCode, PiPiExtractor* extractor);
  PIPI_CSHARP_WRAPPER_API std::vector<const PiPiField*>* CALLING_CONVENTION PiPiExtractorExtractField(int* code, int* exCode, int* exSubCode, PiPiExtractor* extractor);

#ifdef __cplusplus
};
#endif
