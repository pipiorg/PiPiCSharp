#pragma once

#include "pch.h"
#include "PiPiWrapperShare.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPager(int* code, int* exCode, int* exSubCode, PiPiPager* pager);

  PIPI_CSHARP_WRAPPER_API std::vector<size_t>* CALLING_CONVENTION CreatePiPiPagerMergeIndexs(int* code, int* exCode, int* exSubCode);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerAddMergeIndex(int* code, int* exCode, int* exSubCode, std::vector<size_t>* mergeIndexs, size_t index);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMergeIndexs(int* code, int* exCode, int* exSubCode, std::vector<size_t>* mergeIndexs);

  PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerMerge(int* code, int* exCode, int* exSubCode, PiPiPager* pager, std::vector<size_t>* mergeIndexs);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerMergeSize(int* code, int* exCode, int* exSubCode, std::vector<char>* merge);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopyMerge(int* code, int* exCode, int* exSubCode, std::vector<char>* merge, byte* des);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMerge(int* code, int* exCode, int* exSubCode, std::vector<char>* merge);

  PIPI_CSHARP_WRAPPER_API std::vector<std::vector<char>*>* CALLING_CONVENTION PiPiPagerSplit(int* code, int* exCode, int* exSubCode, PiPiPager* pager, size_t index, wchar_t* instruction);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitSize(int* code, int* exCode, int* exSubCode, std::vector<std::vector<char>*>* split);
  PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerGetSplitItem(int* code, int* exCode, int* exSubCode, std::vector<std::vector<char>*>* split, size_t index);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitItemSize(int* code, int* exCode, int* exSubCode, std::vector<char>* splitItem);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopySplitItem(int* code, int* exCode, int* exSubCode, std::vector<char>* splitItem, byte* des);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplit(int* code, int* exCode, int* exSubCode, std::vector<std::vector<char>*>* split);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplitItem(int* code, int* exCode, int* exSubCode, std::vector<char>* split);

#ifdef __cplusplus
};
#endif
