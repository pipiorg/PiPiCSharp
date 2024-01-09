#pragma once

#include "pch.h"
#include "pipi.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractor(PiPiExtractor* extractor);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedPages(std::vector<const PiPiPage*>* extractedPages);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiExtractorExtractedFields(std::vector<const PiPiField*>* extractedFields);

  PIPI_CSHARP_WRAPPER_API std::vector<const PiPiPage*>* CALLING_CONVENTION PiPiExtractorExtractPage(PiPiExtractor* extractor);
  PIPI_CSHARP_WRAPPER_API std::vector<const PiPiField*>* CALLING_CONVENTION PiPiExtractorExtractField(PiPiExtractor* extractor);

#ifdef __cplusplus
};
#endif
