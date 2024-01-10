#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiEditor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor);

  PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiEditorIsOperable(int* code, int* exCode, int* exSubCode, PiPiEditor* editor);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorFlatten(int* code, int* exCode, int* exSubCode, PiPiEditor* editor);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorAddField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int type, unsigned int pageIndex, double x, double y, double width, double height);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int pageIndex);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y, double width, double height);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRenameField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* oldFieldName, char* newFieldName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontName(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, char* fontName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float fontSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, unsigned int alignment);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, bool multiline);

#ifdef __cplusplus
};
#endif
