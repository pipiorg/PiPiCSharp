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

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillValue(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, wchar_t* fieldName, wchar_t* value) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    std::string sFieldName = wcharToUtf8String(fieldName);
    std::string sValue = wcharToUtf8String(value);

    filler->FillValue(sFieldName, sValue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillEllipsisValue(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, wchar_t* fieldName, wchar_t* value, bool ellipsis) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    std::string sFieldName = wcharToUtf8String(fieldName);
    std::string sValue = wcharToUtf8String(value);

    filler->FillValue(sFieldName, sValue, ellipsis);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFillerFillImage(int* code, int* exCode, int* exSubCode, PiPiFiller* filler, wchar_t* fieldName, byte* imageBytes, size_t imageSize) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    std::string sFieldName = wcharToUtf8String(fieldName);

    filler->FillImage(sFieldName, (char*)imageBytes, imageSize);
    });
}
