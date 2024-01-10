#pragma once

#include "pch.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFiller(PiPiFiller* filler);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFillerIsOperable(PiPiFiller* filler);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillValue(PiPiFiller* filler, char* fieldName, char* value);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillEllipsisValue(PiPiFiller* filler, char* fieldName, char* value, bool ellipsis);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillImage(PiPiFiller* filler, char* fieldName, char* imageBytes, size_t imageSize);

#ifdef __cplusplus
};
#endif
