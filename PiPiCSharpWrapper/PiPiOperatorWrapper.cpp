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
