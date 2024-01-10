#include "pch.h"
#include "PiPiPageWrapper.h"

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPager(PiPiPager* pager) {
  delete pager;
}
PIPI_CSHARP_WRAPPER_API std::vector<size_t>* CALLING_CONVENTION CreatePiPiPagerMergeIndexs() {
  return new std::vector<size_t>();
}
PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerAddMergeIndex(std::vector<size_t>* mergeIndexs, size_t index) {
  mergeIndexs->push_back(index);
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMergeIndexs(std::vector<size_t>* mergeIndexs) {
  delete mergeIndexs;
}

PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerMerge(PiPiPager* pager, std::vector<size_t>* mergeIndexs) {
  std::vector<char>* newPdf;
  pager->Merge(mergeIndexs, &newPdf);
  return newPdf;
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerMergeSize(std::vector<char>* merge) {
  return merge->size();
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopyMerge(std::vector<char>* merge, byte* des) {
  for (size_t i = 0; i < merge->size(); i++) {
    des[i] = (byte)merge->at(i);
  }
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMerge(std::vector<char>* merge) {
  delete merge;
}

PIPI_CSHARP_WRAPPER_API std::vector<std::vector<char>*>* CALLING_CONVENTION PiPiPagerSplit(PiPiPager* pager, size_t index, char* instruction) {
  std::vector<std::vector<char>*>* newPdfs;
  pager->Split(index, instruction, &newPdfs);
  return newPdfs;
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitSize(std::vector<std::vector<char>*>* split) {
  return split->size();
}

PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerGetSplitItem(std::vector<std::vector<char>*>* split, size_t index) {
  return split->at(index);
}

PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitItemSize(std::vector<char>* splitItem) {
  return splitItem->size();
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopySplitItem(std::vector<char>* splitItem, byte* des) {
  for (size_t i = 0; i < splitItem->size(); i++) {
    des[i] = (byte)splitItem->at(i);
  }
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplit(std::vector<std::vector<char>*>* split) {
  delete split;
}

PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplitItem(std::vector<char>* split) {
  delete split;
}
