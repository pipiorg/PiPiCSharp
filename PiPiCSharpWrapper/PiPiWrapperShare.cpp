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
