#include "pch.h"
#include "PiPiOperateWrapper.h"

PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION CreatePiPiOperator(byte* pdfBytes, size_t pdfSize) {
  PiPiOperator* op = new PiPiOperator((char*)pdfBytes, pdfSize);
  return op;
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiOperator(PiPiOperator* op) {
  delete op;
  op = nullptr;
}

PIPI_CSHARP_WRAPPER_API PiPiEditor* CALLING_CONVENTION PiPiOperatorGetEditor(PiPiOperator* op) {
  PiPiEditor* editor = op->GetEditor();
  return editor;
}

PIPI_CSHARP_WRAPPER_API PiPiFiller* CALLING_CONVENTION PiPiOperatorGetFiller(PiPiOperator* op) {
  PiPiFiller* filler = op->GetFiller();
  return filler;
}

PIPI_CSHARP_WRAPPER_API PiPiExtractor* CALLING_CONVENTION PiPiOperatorGetExtractor(PiPiOperator* op) {
  PiPiExtractor* extractor = op->GetExtractor();
  return extractor;
}

PIPI_CSHARP_WRAPPER_API PiPiFontManager* CALLING_CONVENTION PiPiOperatorGetFontManager(PiPiOperator* op) {
  PiPiFontManager* fontManager = op->GetFontManager();
  return fontManager;
}

PIPI_CSHARP_WRAPPER_API vector<char>* CALLING_CONVENTION PiPiOperatorFinalize(PiPiOperator* op) {
  vector<char>* out;
  op->Finalize(&out);
  return out;
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiOperatorMeasureFinalize(vector<char>* out) {
  return out->size();
}
PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorCopyFinalize(vector<char>* out, byte* newPdfBytes) {
  for (size_t i = 0; i < out->size(); i++) {
    newPdfBytes[i] = (byte)out->at(i);
  }
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiOperatorDeleteFinalize(vector<char>* out) {
  delete out;
  out = nullptr;
}
