#pragma once

#include "pch.h"

using namespace PiPi;

#ifdef __cplusplus
extern "C" {
#endif

  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPager(PiPiPager* pager);

  PIPI_CSHARP_WRAPPER_API std::vector<size_t>* CALLING_CONVENTION CreatePiPiPagerMergeIndexs();
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerAddMergeIndex(std::vector<size_t>* mergeIndexs, size_t index);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMergeIndexs(std::vector<size_t>* mergeIndexs);

  PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerMerge(PiPiPager* pager, std::vector<size_t>* mergeIndexs);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerMergeSize(std::vector<char>* merge);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopyMerge(std::vector<char>* merge, byte* des);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerMerge(std::vector<char>* merge);

  PIPI_CSHARP_WRAPPER_API std::vector<std::vector<char>*>* CALLING_CONVENTION PiPiPagerSplit(PiPiPager* pager, size_t index, char* instruction);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitSize(std::vector<std::vector<char>*>* split);
  PIPI_CSHARP_WRAPPER_API std::vector<char>* CALLING_CONVENTION PiPiPagerGetSplitItem(std::vector<std::vector<char>*>* split, size_t index);
  PIPI_CSHARP_WRAPPER_API size_t CALLING_CONVENTION PiPiPagerSplitItemSize(std::vector<char>* splitItem);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION PiPiPagerCopySplitItem(std::vector<char>* splitItem, byte* des);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplit(std::vector<std::vector<char>*>* split);
  PIPI_CSHARP_WRAPPER_API void CALLING_CONVENTION DeletePiPiPagerSplitItem(std::vector<char>* split);

#ifdef __cplusplus
};
#endif
