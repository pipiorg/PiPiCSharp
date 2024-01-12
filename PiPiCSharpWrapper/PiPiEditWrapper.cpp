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

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorAddField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int type, unsigned int pageIndex, double x, double y, double width, double height) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    std::string sFieldName = wcharToUtf8String(fieldName);
    PiPiFieldType rType = FieldTypeMap.at(type);
    editor->AddField(sFieldName, rType, pageIndex, x, y, width, height);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldName);
    editor->RemoveField(sFieldName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int pageIndex) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldName);
    editor->RemoveField(sFieldName, pageIndex);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int pageIndex, double x, double y) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldName);
    editor->RemoveField(sFieldName, pageIndex, x, y);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRemoveFieldExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldName, unsigned int pageIndex, double x, double y, double width, double height) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldName);
    editor->RemoveField(sFieldName, pageIndex, x, y, width, height);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorRenameField(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* oldFieldName, wchar_t* newFieldName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sOldFieldName = wcharToUtf8String(oldFieldName);
    std::string sNewFieldName = wcharToUtf8String(newFieldName);
    editor->RenameField(sOldFieldName, sNewFieldName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontName(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, wchar_t* fontName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sFontName = wcharToUtf8String(fontName);
    editor->SetFieldFontName(sFieldName, sFontName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float fontSize) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldFontSize(sFieldName, fontSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int alignment) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    PiPiTextHorizontalAlignment rAlignment = TextHorizontalAlignmentMap.at(alignment);
    editor->SetFieldTextHorizontalAlignment(sFieldName, rAlignment);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldColor(sFieldName, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBackgroundColor(sFieldName, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderColor(sFieldName, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, bool multiline) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldMultiline(sFieldName, multiline);
    });
}
