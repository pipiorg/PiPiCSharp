#pragma once

#include "pch.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractor(PiPiExtractor* extractor);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPages(std::vector<const PiPiPage*>* extractedPages);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPage(const PiPiPage* extractedPage);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedPagesSize(std::vector<const PiPiPage*>* extractedPages);
  PIPI_CSHARP_WRAPPER_API const PiPiPage* CALLING_CONVENTION PiPiExtractorGetExtractedPage(std::vector<const PiPiPage*>* extractedPages, size_t index);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageWidth(const PiPiPage* extractedPage);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedPageHeight(const PiPiPage* extractedPage);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedFields(std::vector<const PiPiField*>* extractedFields);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedField(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorExtractedFieldsSize(std::vector<const PiPiField*>* extractedFields);
  PIPI_CSHARP_WRAPPER_API const PiPiField* CALLING_CONVENTION PiPiExtractorGetExtractedField(std::vector<const PiPiField*>* extractedFields, size_t index);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldName(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontName(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API float CALLING_CONVENTION PiPiExtractorGetExtractedFieldFontSize(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldPageIndex(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API unsigned int CALLING_CONVENTION PiPiExtractorGetExtractedFieldType(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldWidth(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldHeight(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldX(const PiPiField* extractedField);
  PIPI_CSHARP_WRAPPER_API double CALLING_CONVENTION PiPiExtractorGetExtractedFieldY(const PiPiField* extractedField);

  PIPI_CSHARP_WRAPPER_API std::vector<const PiPiPage*>* CALLING_CONVENTION PiPiExtractorExtractPage(PiPiExtractor* extractor);
  PIPI_CSHARP_WRAPPER_API std::vector<const PiPiField*>* CALLING_CONVENTION PiPiExtractorExtractField(PiPiExtractor* extractor);

#ifdef __cplusplus
};
#endif
