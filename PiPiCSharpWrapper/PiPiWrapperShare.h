#pragma once

#include "pch.h"

template<typename T>
T handleException(int* code, int* exCode, int* exSubCode, std::function<T()> func);

void handleVoidException(int* code, int* exCode, int* exSubCode, std::function<void()> func);
