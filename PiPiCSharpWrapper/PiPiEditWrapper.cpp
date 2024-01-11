#include "pch.h"
#include "PiPiEditWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiEditor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete editor;
    });
}

PIPI_CSHARP_WRAPPER_API bool CALLING_CONVENTION PiPiEditorIsOperable(int* code, int* exCode, int* exSubCode, PiPiEditor* editor) {
  return handleException<bool>(code, exCode, exSubCode, [&]() {
    bool operable = editor->IsOperable();
    return operable;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorFlatten(int* code, int* exCode, int* exSubCode, PiPiEditor* editor) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    editor->Flatten();
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorAddField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int type, unsigned int pageIndex, double x, double y, double width, double height) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    PiPiFieldType rType = fieldTypeMap.at(type);
    editor->AddField(fieldName, rType, pageIndex, x, y, width, height);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->RemoveField(fieldName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int pageIndex) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->RemoveField(fieldName, pageIndex);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->RemoveField(fieldName, pageIndex, x, y);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldName, unsigned int pageIndex, double x, double y, double width, double height) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->RemoveField(fieldName, pageIndex, x, y, width, height);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRenameField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* oldFieldName, char* newFieldName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->RenameField(oldFieldName, newFieldName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontName(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, char* fontName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->SetFieldFontName(fieldname, fontName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float fontSize) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->SetFieldFontSize(fieldname, fontSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, unsigned int alignment) {
  handleVoidException(code, exCode, exSubCode, [&] {
    PiPiTextHorizontalAlignment rAlignment = textHorizontalAlignmentMap.at(alignment);
    editor->SetFieldTextHorizontalAlignment(fieldname, rAlignment);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->SetFieldColor(fieldname, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->SetFieldBackgroundColor(fieldname, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->SetFieldBorderColor(fieldname, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, char* fieldname, bool multiline) {
  handleVoidException(code, exCode, exSubCode, [&] {
    editor->SetFieldMultiline(fieldname, multiline);
    });
}
