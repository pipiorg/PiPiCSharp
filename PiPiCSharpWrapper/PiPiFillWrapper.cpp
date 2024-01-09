#include "pch.h"
#include "PiPiFillWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFiller(PiPiFiller* filler) {
  delete filler;
  filler = nullptr;
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFillerIsOperable(PiPiFiller* filler) {
  return filler->IsOperable();
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillValue(PiPiFiller* filler, char* fieldName, char* value) {
  filler->FillValue(fieldName, value);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillEllipsisValue(PiPiFiller* filler, char* fieldName, char* value, bool ellipsis) {
  filler->FillValue(fieldName, value, ellipsis);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillImage(PiPiFiller* filler, char* fieldName, char* imageBytes, size_t imageSize) {
  filler->FillImage(fieldName, imageBytes, imageSize);
}
