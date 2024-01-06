#include "pch.h"
#include "PiPiOperateWrapper.h"

PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION init(const char* pdfBytes, const size_t pdfSize) {
  size_t cPdfSize = pdfSize;
  char* cPdfBytes = new char[cPdfSize];

  for (size_t i = 0; i < pdfSize; i++) {
    cPdfBytes[i] = pdfBytes[i];
  }

  PiPiOperator* op = new PiPiOperator(cPdfBytes, cPdfSize);

  return op;
}
