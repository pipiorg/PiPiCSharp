#include "pch.h"
#include "PiPiMultiOperateWrapper.h"

PIPI_CSHARP_WRAPPER_API PiPiMultiOperator* CALLING_CONVENTION CreatePiPiMultiOperator() {
  return new PiPiMultiOperator();
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiMultiOperator(PiPiMultiOperator* multiOp) {
  delete multiOp;
  multiOp = nullptr;
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiMultiOperatorAdd(PiPiMultiOperator* multiOp, byte* pdfBytes, size_t pdfSize) {
  return multiOp->Add((char*)pdfBytes, pdfSize);
}

PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION PiPiMultiOperatorGetOperator(PiPiMultiOperator* multiOp, size_t index) {
  return multiOp->GetOperator(index);
}

PIPI_CSHARP_WRAPPER_API PiPiPager* CALLING_CONVENTION PiPiMultiOperatorGetPager(PiPiMultiOperator* multiOp) {
  return multiOp->GetPager();
}
