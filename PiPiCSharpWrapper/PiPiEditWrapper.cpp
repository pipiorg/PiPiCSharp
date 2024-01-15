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

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValue(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, wchar_t* defaultValue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sDefaultValue = wcharToUtf8String(defaultValue);
    editor->SetFieldDefaultValue(sFieldName, sDefaultValue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValueInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, wchar_t* defaultValue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sDefaultValue = wcharToUtf8String(defaultValue);
    editor->SetFieldDefaultValue(sFieldName, pageIndex, sDefaultValue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValueAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, wchar_t* defaultValue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sDefaultValue = wcharToUtf8String(defaultValue);
    editor->SetFieldDefaultValue(sFieldName, pageIndex, x, y, sDefaultValue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldDefaultValueExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, wchar_t* fondefaultValuetName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sDefaultValue = wcharToUtf8String(fondefaultValuetName);
    editor->SetFieldDefaultValue(sFieldName, pageIndex, x, y, width, height, sDefaultValue);
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

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontNameInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, wchar_t* fontName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sFontName = wcharToUtf8String(fontName);
    editor->SetFieldFontName(sFieldName, pageIndex, sFontName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontNameAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, wchar_t* fontName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sFontName = wcharToUtf8String(fontName);
    editor->SetFieldFontName(sFieldName, pageIndex, x, y, sFontName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontNameExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, wchar_t* fontName) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    std::string sFontName = wcharToUtf8String(fontName);
    editor->SetFieldFontName(sFieldName, pageIndex, x, y, width, height, sFontName);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSize(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float fontSize) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldFontSize(sFieldName, fontSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSizeInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float fontSize) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldFontSize(sFieldName, pageIndex, fontSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSizeAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float fontSize) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldFontSize(sFieldName, pageIndex, x, y, fontSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldFontSizeExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float fontSize) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldFontSize(sFieldName, pageIndex, x, y, width, height, fontSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignment(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int alignment) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    PiPiTextHorizontalAlignment rAlignment = TextHorizontalAlignmentMap.at(alignment);
    editor->SetFieldTextHorizontalAlignment(sFieldName, rAlignment);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignmentInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, unsigned int alignment) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    PiPiTextHorizontalAlignment rAlignment = TextHorizontalAlignmentMap.at(alignment);
    editor->SetFieldTextHorizontalAlignment(sFieldName, pageIndex, rAlignment);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignmentAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, unsigned int alignment) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    PiPiTextHorizontalAlignment rAlignment = TextHorizontalAlignmentMap.at(alignment);
    editor->SetFieldTextHorizontalAlignment(sFieldName, pageIndex, x, y, rAlignment);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldTextHorizontalAlignmentExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, unsigned int alignment) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    PiPiTextHorizontalAlignment rAlignment = TextHorizontalAlignmentMap.at(alignment);
    editor->SetFieldTextHorizontalAlignment(sFieldName, pageIndex, x, y, width, height, rAlignment);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldColor(sFieldName, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColorInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldColor(sFieldName, pageIndex, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColorAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldColor(sFieldName, pageIndex, x, y, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldColorExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldColor(sFieldName, pageIndex, x, y, width, height, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBackgroundColor(sFieldName, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColorInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBackgroundColor(sFieldName, pageIndex, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColorAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBackgroundColor(sFieldName, pageIndex, x, y, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBackgroundColorExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBackgroundColor(sFieldName, pageIndex, x, y, width, height, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColor(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderColor(sFieldName, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColorInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderColor(sFieldName, pageIndex, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColorAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderColor(sFieldName, pageIndex, x, y, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderColorExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, float red, float green, float blue) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderColor(sFieldName, pageIndex, x, y, width, height, red, green, blue);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderWidth(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, double borderWidth) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderWidth(sFieldName, borderWidth);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderWidthInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double borderWidth) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderWidth(sFieldName, pageIndex, borderWidth);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderWidthAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double borderWidth) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderWidth(sFieldName, pageIndex, x, y, borderWidth);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldBorderWidthExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, double borderWidth) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldBorderWidth(sFieldName, pageIndex, x, y, width, height, borderWidth);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultiline(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, bool multiline) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldMultiline(sFieldName, multiline);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultilineInPage(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, bool multiline) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldMultiline(sFieldName, pageIndex, multiline);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultilineAtPosition(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, bool multiline) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldMultiline(sFieldName, pageIndex, x, y, multiline);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiEditorSetFieldMultilineExact(int* code, int* exCode, int* exSubCode, PiPiEditor* editor, wchar_t* fieldname, unsigned int pageIndex, double x, double y, double width, double height, bool multiline) {
  handleVoidException(code, exCode, exSubCode, [&] {
    std::string sFieldName = wcharToUtf8String(fieldname);
    editor->SetFieldMultiline(sFieldName, pageIndex, x, y, width, height, multiline);
    });
}
