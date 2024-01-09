#pragma once

#include "pch.h"
#include "pipi.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiEditor(PiPiEditor* editor);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiEditorIsOperable(PiPiEditor* editor);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorFlatten(PiPiEditor* editor);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorAddField(PiPiEditor* editor, char* fieldName, unsigned int type, unsigned int pageIndex, double x, double y, double width, double height);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveField(PiPiEditor* editor, char* fieldName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldInPage(PiPiEditor* editor, char* fieldName, unsigned int pageIndex);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldAtPosition(PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldExact(PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y, double width, double height);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRenameField(PiPiEditor* editor, char* oldFieldName, char* newFieldName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontName(PiPiEditor* editor, char* fieldname, char* fontName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(PiPiEditor* editor, char* fieldname, float fontSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(PiPiEditor* editor, char* fieldname, unsigned int alignment);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(PiPiEditor* editor, char* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(PiPiEditor* editor, char* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(PiPiEditor* editor, char* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(PiPiEditor* editor, char* fieldname, bool multiline);

#ifdef __cplusplus
};
#endif
