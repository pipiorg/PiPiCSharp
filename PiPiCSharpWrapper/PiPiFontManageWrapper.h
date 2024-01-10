#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontManager(int* code, int* exCode, int* exSubCode, PiPiFontManager* fontManager);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontManagerIsOperable(int* code, int* exCode, int* exSubCode, PiPiFontManager* fontManager);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiFontManagerRegisterFont(int* code, int* exCode, int* exSubCode, PiPiFontManager* fontManager, byte* fontBytes, size_t fontSize);

#ifdef __cplusplus
};
#endif
