#pragma once

#include "pch.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API PiPiMultiOperator* CALLING_CONVENTION CreatePiPiMultiOperator();
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiMultiOperator(PiPiMultiOperator* multiOp);

  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiMultiOperatorAdd(PiPiMultiOperator* multiOp, byte* pdfBytes, size_t pdfSize);
  PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION PiPiMultiOperatorGetOperator(PiPiMultiOperator* multiOp, size_t index);
  PIPI_CSHARP_WRAPPER_API PiPiPager* CALLING_CONVENTION PiPiMultiOperatorGetPager(PiPiMultiOperator* multiOp);

#ifdef __cplusplus
};
#endif
