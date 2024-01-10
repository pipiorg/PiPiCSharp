#include "pch.h"
#include "PiPiFillWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFiller(int* code, int* exCode, int* exSubCode, PiPiFiller* filler) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete filler;
    });
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFillerIsOperable(int* code, int* exCode, int* exSubCode, PiPiFiller* filler) {
  return handleException<bool>(code, exCode, exSubCode, [&]() {
    return filler->IsOperable();
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillValue(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, char* fieldName, char* value) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    filler->FillValue(fieldName, value);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillEllipsisValue(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, char* fieldName, char* value, bool ellipsis) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    filler->FillValue(fieldName, value, ellipsis);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillImage(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, char* fieldName, char* imageBytes, size_t imageSize) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    filler->FillImage(fieldName, imageBytes, imageSize);
    });
}
