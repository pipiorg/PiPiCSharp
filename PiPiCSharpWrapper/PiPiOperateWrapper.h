#pragma once

#include "pch.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION CreatePiPiOperator(byte* pdfBytes, size_t pdfSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiOperator(PiPiOperator* op);

  PIPI_CSHARP_WRAPPER_API PiPiEditor* CALLING_CONVENTION PiPiOperatorGetEditor(PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API PiPiFiller* CALLING_CONVENTION PiPiOperatorGetFiller(PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API PiPiExtractor* CALLING_CONVENTION PiPiOperatorGetExtractor(PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API PiPiFontManager* CALLING_CONVENTION PiPiOperatorGetFontManager(PiPiOperator* op);

  PIPI_CSHARP_WRAPPER_API vector<char>* CALLING_CONVENTION PiPiOperatorFinalize(PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiOperatorMeasureFinalize(vector<char>* out);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorDeleteFinalize(vector<char>* out);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorCopyFinalize(vector<char>* out, byte* newPdfBytes);

#ifdef __cplusplus
};
#endif
