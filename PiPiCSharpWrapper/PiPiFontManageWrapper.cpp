#include "pch.h"
#include "PiPiFontManageWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiFontManager(PiPiFontManager* fontManager) {
  delete fontManager;
  fontManager = nullptr;
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiFontManagerIsOperable(PiPiFontManager* fontManager) {
  return fontManager->IsOperable();
}
PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiFontManagerRegisterFont(PiPiFontManager* fontManager, byte* fontBytes, size_t fontSize) {
  fontManager->RegisterFont((char*)fontBytes, fontSize);
}
