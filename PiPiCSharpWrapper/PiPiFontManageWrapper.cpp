#include "pch.h"
#include "PiPiFontManageWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontManager(int* code, int* exCode, int* exSubCode, PiPiFontManager* fontManager) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete fontManager;
    });
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontManagerIsOperable(int* code, int* exCode, int* exSubCode, PiPiFontManager* fontManager) {
  return handleException<bool>(code, exCode, exSubCode, [&]() {
    return fontManager->IsOperable();
    });
}
PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiFontManagerRegisterFont(int* code, int* exCode, int* exSubCode, PiPiFontManager* fontManager, byte* fontBytes, size_t fontSize) {
  return handleException<char*>(code, exCode, exSubCode, [&]() {
    std::string fontName = fontManager->RegisterFont((char*)fontBytes, fontSize);
    char* cFontName = new char[fontName.length() + 1];
    strcpy(cFontName, fontName.c_str());
    return cFontName;
    });
}
