#pragma once

#include "pch.h"
#include "pipi.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontManager(PiPiFontManager* fontManager);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontManagerIsOperable(PiPiFontManager* fontManager);
  PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiFontManagerRegisterFont(PiPiFontManager* fontManager, byte* fontBytes, size_t fontSize);

#ifdef __cplusplus
};
#endif
