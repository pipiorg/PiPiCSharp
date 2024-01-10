#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API PiPiMultiOperator* CALLING_CONVENTION CreatePiPiMultiOperator(int* code, int* exCode, int* exSubCode);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiMultiOperator(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp);

  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiMultiOperatorAdd(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp, byte* pdfBytes, size_t pdfSize);
  PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION PiPiMultiOperatorGetOperator(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp, size_t index);
  PIPI_CSHARP_WRAPPER_API PiPiPager* CALLING_CONVENTION PiPiMultiOperatorGetPager(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp);

#ifdef __cplusplus
};
#endif
