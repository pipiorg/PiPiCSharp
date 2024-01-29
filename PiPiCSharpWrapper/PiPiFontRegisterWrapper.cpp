#include "pch.h"
#include "PiPiFontRegisterWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontRegister(int* code, int* exCode, int* exSubCode, PiPiFontRegister* fontRegister) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete fontRegister;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontRegisterFontName(int* code, int* exCode, int* exSubCode, char* fontName) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete[] fontName;
    });
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontRegisterIsOperable(int* code, int* exCode, int* exSubCode, PiPiFontRegister* fontRegister) {
  return handleException<bool>(code, exCode, exSubCode, [&]() {
    return fontRegister->IsOperable();
    });
}
PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiFontRegisterRegisterFont(int* code, int* exCode, int* exSubCode, PiPiFontRegister* fontRegister, byte* fontBytes, size_t fontSize) {
  return handleException<char*>(code, exCode, exSubCode, [&]() {
    std::string fontName = fontRegister->RegisterFont((char*)fontBytes, fontSize);
    char* cFontName = new char[fontName.length() + 1];
    strcpy(cFontName, fontName.c_str());
    return cFontName;
    });
}
