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

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedFields(std::vector<const PiPiField*>* extractedFields) {
  delete extractedFields;
  extractedFields = nullptr;
}

PIPI_CSHARP_WRAPPER_API std::vector<const PiPiPage*>* CALLING_CONVENTION PiPiExtractorExtractPage(PiPiExtractor* extractor) {
  return extractor->ExtractPage();
}

PIPI_CSHARP_WRAPPER_API std::vector<const PiPiField*>* CALLING_CONVENTION PiPiExtractorExtractField(PiPiExtractor* extractor) {
  return extractor->ExtractField();
}
