#include "pch.h"
#include "PiPiWrapperShare.h"

template<typename T>
T handleException(int* code, int* exCode, int* exSubCode, std::function<T()> func) {
  try {
    T res = func();

    *code = 1;
    *exCode = -1;
    *exSubCode = -1;

    return res;
  }
  catch (std::exception& e) {
    *code = 0;
    *exCode = -1;
    *exSubCode = -1;

    return T();
  }
}

void handleVoidException(int* code, int* exCode, int* exSubCode, std::function<void()> func) {
  try {
    func();

    *code = 1;
    *exCode = -1;
    *exSubCode = -1;
  }
  catch (std::exception& e) {
    *code = 0;
    *exCode = -1;
    *exSubCode = -1;
  }
}

template bool handleException<bool>(int* code, int* exCode, int* exSubCode, std::function<bool()> func);
template unsigned int handleException<unsigned int>(int* code, int* exCode, int* exSubCode, std::function<unsigned int()> func);
template float handleException<float>(int* code, int* exCode, int* exSubCode, std::function<float()> func);
template double handleException<double>(int* code, int* exCode, int* exSubCode, std::function<double()> func);
template size_t handleException<size_t>(int* code, int* exCode, int* exSubCode, std::function<size_t()> func);
template char* handleException<char*>(int* code, int* exCode, int* exSubCode, std::function<char* ()> func);

template vector<char>* handleException<vector<char>*>(int* code, int* exCode, int* exSubCode, std::function<vector<char>* ()> func);
template std::vector<std::vector<char>*>* handleException<std::vector<std::vector<char>*>*>(int* code, int* exCode, int* exSubCode, std::function<std::vector<std::vector<char>*>* ()> func);
template std::vector<const PiPi::PiPiPage*>* handleException<std::vector<const PiPi::PiPiPage*>*>(int* code, int* exCode, int* exSubCode, std::function<std::vector<const PiPi::PiPiPage*>* ()> func);
template std::vector<const PiPi::PiPiField*>* handleException<std::vector<const PiPi::PiPiField*>*>(int* code, int* exCode, int* exSubCode, std::function<std::vector<const PiPi::PiPiField*>* ()> func);
template std::vector<size_t>* handleException<std::vector<size_t>*>(int* code, int* exCode, int* exSubCode, std::function <std::vector<size_t>* ()> func);

template const PiPi::PiPiPage* handleException<const PiPi::PiPiPage*>(int* code, int* exCode, int* exSubCode, std::function<const PiPi::PiPiPage* ()> func);
template const PiPi::PiPiField* handleException<const PiPi::PiPiField*>(int* code, int* exCode, int* exSubCode, std::function<const PiPi::PiPiField* ()> func);

template PiPi::PiPiOperator* handleException<PiPi::PiPiOperator*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiOperator* ()> func);
template PiPi::PiPiMultiOperator* handleException<PiPi::PiPiMultiOperator*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiMultiOperator* ()> func);
template PiPi::PiPiPager* handleException<PiPi::PiPiPager*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiPager* ()> func);
template PiPi::PiPiEditor* handleException<PiPi::PiPiEditor*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiEditor* ()> func);
template PiPi::PiPiExtractor* handleException<PiPi::PiPiExtractor*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiExtractor* ()> func);
template PiPi::PiPiFontManager* handleException<PiPi::PiPiFontManager*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiFontManager* ()> func);
template PiPi::PiPiFiller* handleException<PiPi::PiPiFiller*>(int* code, int* exCode, int* exSubCode, std::function<PiPi::PiPiFiller* ()> func);
