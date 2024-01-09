#include "pch.h"
#include "PiPiEditWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiEditor(PiPiEditor* editor) {
  delete editor;
  editor = nullptr;
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiEditorIsOperable(PiPiEditor* editor) {
  return editor->IsOperable();
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorFlatten(PiPiEditor* editor) {
  editor->Flatten();
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorAddField(PiPiEditor* editor, char* fieldName, unsigned int type, unsigned int pageIndex, double x, double y, double width, double height) {
  // FIXME: solve issue
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveField(PiPiEditor* editor, char* fieldName) {
  editor->RemoveField(fieldName);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldInPage(PiPiEditor* editor, char* fieldName, unsigned int pageIndex) {
  editor->RemoveField(fieldName, pageIndex);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldAtPosition(PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y) {
  editor->RemoveField(fieldName, pageIndex, x, y);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldExact(PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y, double width, double height) {
  editor->RemoveField(fieldName, pageIndex, x, y, width, height);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRenameField(PiPiEditor* editor, char* oldFieldName, char* newFieldName) {
  editor->RenameField(oldFieldName, newFieldName);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontName(PiPiEditor* editor, char* fieldname, char* fontName) {
  editor->SetFieldFontName(fieldname, fontName);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(PiPiEditor* editor, char* fieldname, float fontSize) {
  editor->SetFieldFontSize(fieldname, fontSize);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(PiPiEditor* editor, char* fieldname, unsigned int alignment) {
  // FIXME: solve issue
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(PiPiEditor* editor, char* fieldname, float red, float green, float blue) {
  editor->SetFieldColor(fieldname, red, green, blue);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(PiPiEditor* editor, char* fieldname, float red, float green, float blue) {
  editor->SetFieldBackgroundColor(fieldname, red, green, blue);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(PiPiEditor* editor, char* fieldname, float red, float green, float blue) {
  editor->SetFieldBorderColor(fieldname, red, green, blue);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(PiPiEditor* editor, char* fieldname, bool multiline) {
  editor->SetFieldMultiline(fieldname, multiline);
}
