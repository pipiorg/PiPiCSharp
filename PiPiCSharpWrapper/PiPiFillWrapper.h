#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFiller(int* code, int* exCode, int* exSubCode, PiPiFiller* filler);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFillerIsOperable(int* code, int* exCode, int* exSubCode, PiPiFiller* filler);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillValue(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, char* fieldName, char* value);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillEllipsisValue(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, char* fieldName, char* value, bool ellipsis);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillImage(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, char* fieldName, char* imageBytes, size_t imageSize);

#ifdef __cplusplus
};
#endif
