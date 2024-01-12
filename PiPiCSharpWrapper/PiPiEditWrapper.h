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

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorAddField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int type, unsigned int pageIndex, double x, double y, double width, double height);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int pageIndex);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int pageIndex, double x, double y);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int pageIndex, double x, double y, double width, double height);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRenameField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* oldFieldName, wchar_t* newFieldName);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValue(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, wchar_t* defaultValue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValueInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, wchar_t* defaultValue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValueAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, wchar_t* defaultValue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValueExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, wchar_t* fondefaultValuetName);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontName(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, wchar_t* fontName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontNameInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, wchar_t* fontName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontNameAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, wchar_t* fontName);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontNameExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, wchar_t* fontName);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float fontSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSizeInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float fontSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSizeAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float fontSize);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSizeExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float fontSize);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int alignment);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignmentInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, unsigned int alignment);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignmentAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, unsigned int alignment);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignmentExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, unsigned int alignment);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColorInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColorAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColorExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float red, float green, float blue);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColorInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColorAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColorExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float red, float green, float blue);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColorInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColorAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float red, float green, float blue);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColorExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float red, float green, float blue);

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, bool multiline);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultilineInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, bool multiline);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultilineAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, bool multiline);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultilineExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, bool multiline);

#ifdef __cplusplus
};
#endif
