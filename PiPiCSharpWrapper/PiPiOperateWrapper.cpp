#include "pch.h"
#include "PiPiOperateWrapper.h"

PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION CreatePiPiOperator(int* code, int* exCode, int* exSubCode, byte* pdfBytes, size_t pdfSize) {
  return handleException<PiPiOperator*>(code, exCode, exSubCode, [&]() {
    return new PiPiOperator((char*)pdfBytes, pdfSize);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiOperator(int* code, int* exCode, int* exSubCode, PiPiOperator* op) {
  return handleVoidException(code, exCode, exSubCode, [&]() {
    delete op;
    });
}

PIPI_CSHARP_WRAPPER_API PiPiEditor* CALLING_CONVENTION PiPiOperatorGetEditor(int* code, int* exCode, int* exSubCode, PiPiOperator* op) {
  return handleException<PiPiEditor*>(code, exCode, exSubCode, [&]() {
    PiPiEditor* editor = op->GetEditor();
    return editor;
    });
}

PIPI_CSHARP_WRAPPER_API PiPiFiller* CALLING_CONVENTION PiPiOperatorGetFiller(int* code, int* exCode, int* exSubCode, PiPiOperator* op) {
  return handleException<PiPiFiller*>(code, exCode, exSubCode, [&]() {
    PiPiFiller* filler = op->GetFiller();
    return filler;
    });
}

PIPI_CSHARP_WRAPPER_API PiPiExtractor* CALLING_CONVENTION PiPiOperatorGetExtractor(int* code, int* exCode, int* exSubCode, PiPiOperator* op) {
  return handleException<PiPiExtractor*>(code, exCode, exSubCode, [&]() {
    PiPiExtractor* extractor = op->GetExtractor();
    return extractor;
    });
}

PIPI_CSHARP_WRAPPER_API PiPiFontManager* CALLING_CONVENTION PiPiOperatorGetFontManager(int* code, int* exCode, int* exSubCode, PiPiOperator* op) {
  return handleException<PiPiFontManager*>(code, exCode, exSubCode, [&]() {
    PiPiFontManager* fontManager = op->GetFontManager();
    return fontManager;
    });
}

PIPI_CSHARP_WRAPPER_API vector<char>* CALLING_CONVENTION PiPiOperatorFinalize(int* code, int* exCode, int* exSubCode, PiPiOperator* op) {
  return handleException<vector<char>*>(code, exCode, exSubCode, [&]() {
    vector<char>* out;
    op->Finalize(&out);
    return out;
    });
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiOperatorMeasureFinalize(int* code, int* exCode, int* exSubCode, vector<char>* out) {
  return handleException<size_t>(code, exCode, exSubCode, [&]() {
    return out->size();
    });
}
PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorCopyFinalize(int* code, int* exCode, int* exSubCode, vector<char>* out, byte* newPdfBytes) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    for (size_t i = 0; i < out->size(); i++) {
      newPdfBytes[i] = (byte)out->at(i);
    }
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorDeleteFinalize(int* code, int* exCode, int* exSubCode, vector<char>* out) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete out;
    });
}
