#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontRegister(int* code, int* exCode, int* exSubCode, PiPiFontRegister* fontRegister);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontRegisterIsOperable(int* code, int* exCode, int* exSubCode, PiPiFontRegister* fontRegister);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiFontRegisterRegisterFont(int* code, int* exCode, int* exSubCode, PiPiFontRegister* fontRegister, byte* fontBytes, size_t fontSize);

#ifdef __cplusplus
};
#endif
