#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION CreatePiPiOperator(int* code, int* exCode, int* exSubCode, byte* pdfBytes, size_t pdfSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiOperator(int* code, int* exCode, int* exSubCode, PiPiOperator* op);

  PIPI_CSHARP_WRAPPER_API PiPiEditor* CALLING_CONVENTION PiPiOperatorGetEditor(int* code, int* exCode, int* exSubCode, PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API PiPiFiller* CALLING_CONVENTION PiPiOperatorGetFiller(int* code, int* exCode, int* exSubCode, PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API PiPiExtractor* CALLING_CONVENTION PiPiOperatorGetExtractor(int* code, int* exCode, int* exSubCode, PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API PiPiFontManager* CALLING_CONVENTION PiPiOperatorGetFontManager(int* code, int* exCode, int* exSubCode, PiPiOperator* op);

  PIPI_CSHARP_WRAPPER_API vector<char>* CALLING_CONVENTION PiPiOperatorFinalize(int* code, int* exCode, int* exSubCode, PiPiOperator* op);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiOperatorMeasureFinalize(int* code, int* exCode, int* exSubCode, vector<char>* out);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorDeleteFinalize(int* code, int* exCode, int* exSubCode, vector<char>* out);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorCopyFinalize(int* code, int* exCode, int* exSubCode, vector<char>* out, byte* newPdfBytes);

#ifdef __cplusplus
};
#endif
