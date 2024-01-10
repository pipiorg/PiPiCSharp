#include "pch.h"
#include "PiPiPageWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPager(int* code, int* exCode, int* exSubCode, PiPiPager* pager) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete pager;
    });
}

PIPI_CSHARP_WRAPPER_API std::vector<size_t>* CALLING_CONVENTION CreatePiPiPagerMergeIndexs(int* code, int* exCode, int* exSubCode) {
  return handleException<std::vector<size_t>*>(code, exCode, exSubCode, [&]() {
    return new std::vector<size_t>();
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerAddMergeIndex(int* code, int* exCode, int* exSubCode, std::vector<size_t>* mergeIndexs, size_t index) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    mergeIndexs->push_back(index);
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMergeIndexs(int* code, int* exCode, int* exSubCode, std::vector<size_t>* mergeIndexs) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete mergeIndexs;
    });
}

PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerMerge(int* code, int* exCode, int* exSubCode, PiPiPager* pager, std::vector<size_t>* mergeIndexs) {
  return handleException<std::vector<char>*>(code, exCode, exSubCode, [&]() {
    std::vector<char>* newPdf;
    pager->Merge(mergeIndexs, &newPdf);
    return newPdf;
    });
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerMergeSize(int* code, int* exCode, int* exSubCode, std::vector<char>* merge) {
  return handleException<size_t>(code, exCode, exSubCode, [&]() {
    return merge->size();
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopyMerge(int* code, int* exCode, int* exSubCode, std::vector<char>* merge, byte* des) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    for (size_t i = 0; i < merge->size(); i++) {
      des[i] = (byte)merge->at(i);
    }
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMerge(int* code, int* exCode, int* exSubCode, std::vector<char>* merge) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete merge;
    });
}

PIPI_CSHARP_WRAPPER_API std::vector<std::vector<char>*>* CALLING_CONVENTION PiPiPagerSplit(int* code, int* exCode, int* exSubCode, PiPiPager* pager, size_t index, char* instruction) {
  return handleException<std::vector<std::vector<char>*>*>(code, exCode, exSubCode, [&]() {
    std::vector<std::vector<char>*>* newPdfs;
    pager->Split(index, instruction, &newPdfs);
    return newPdfs;
    });
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitSize(int* code, int* exCode, int* exSubCode, std::vector<std::vector<char>*>* split) {
  return handleException<size_t>(code, exCode, exSubCode, [&]() {
    return split->size();
    });
}

PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerGetSplitItem(int* code, int* exCode, int* exSubCode, std::vector<std::vector<char>*>* split, size_t index) {
  return handleException<std::vector<char>*>(code, exCode, exSubCode, [&]() {
    return split->at(index);
    });
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitItemSize(int* code, int* exCode, int* exSubCode, std::vector<char>* splitItem) {
  return handleException<size_t>(code, exCode, exSubCode, [&]() {
    return splitItem->size();
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopySplitItem(int* code, int* exCode, int* exSubCode, std::vector<char>* splitItem, byte* des) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    for (size_t i = 0; i < splitItem->size(); i++) {
      des[i] = (byte)splitItem->at(i);
    }
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplit(int* code, int* exCode, int* exSubCode, std::vector<std::vector<char>*>* split) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete split;
    });
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplitItem(int* code, int* exCode, int* exSubCode, std::vector<char>* split) {
  handleVoidException(code, exCode, exSubCode, [&]() {
    delete split;
    });
}
