#pragma once

#include "pch.h"
#include "pipi.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION init(const char* pdfBytes, const size_t pdfSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION release(PiPiOperator* op);

#ifdef __cplusplus
};
#endif
