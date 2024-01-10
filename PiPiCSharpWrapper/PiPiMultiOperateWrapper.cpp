#include "pch.h"
#include "PiPiMultiOperateWrapper.h"

PIPI_CSHARP_WRAPPER_API PiPiMultiOperator* CALLING_CONVENTION CreatePiPiMultiOperator(int* code, int* exCode, int* exSubCode) {
  return handleException<PiPiMultiOperator*>(code, exCode, exSubCode, [&]() {
    return new PiPiMultiOperator();
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiMultiOperator(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp) {
  return handleVoidException(code, exCode, exSubCode, [&]() {
    delete multiOp;
    });
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiMultiOperatorAdd(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp, byte* pdfBytes, size_t pdfSize) {
  return handleException<size_t>(code, exCode, exSubCode, [&]() {
    return multiOp->Add((char*)pdfBytes, pdfSize);
    });
}

PIPI_CSHARP_WRAPPER_API PiPiOperator* CALLING_CONVENTION PiPiMultiOperatorGetOperator(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp, size_t index) {
  return handleException<PiPiOperator*>(code, exCode, exSubCode, [&]() {
    return multiOp->GetOperator(index);
    });
}

PIPI_CSHARP_WRAPPER_API PiPiPager* CALLING_CONVENTION PiPiMultiOperatorGetPager(int* code, int* exCode, int* exSubCode, PiPiMultiOperator* multiOp) {
  return handleException<PiPiPager*>(code, exCode, exSubCode, [&]() {
    return multiOp->GetPager();
    });
}
