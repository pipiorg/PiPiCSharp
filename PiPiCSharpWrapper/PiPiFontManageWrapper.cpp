#include "pch.h"
#include "PiPiFontManageWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontManager(PiPiFontManager* fontManager) {
  delete fontManager;
  fontManager = nullptr;
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontManagerIsOperable(PiPiFontManager* fontManager) {
  return fontManager->IsOperable();
}
PIPI_CSHARP_WRAPPER_API char* CALLING_CONVENTION PiPiFontManagerRegisterFont(PiPiFontManager* fontManager, byte* fontBytes, size_t fontSize) {
  std::string fontName = fontManager->RegisterFont((char*)fontBytes, fontSize);
  char* cFontName = new char[fontName.length() + 1];
  strcpy(cFontName, fontName.c_str());
  return cFontName;
}
