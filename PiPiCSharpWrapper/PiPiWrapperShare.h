#pragma once

#include "pch.h"

static const std::map<unsigned int, PiPi::PiPiFieldType> fieldTypeMap = {
  { 0, PiPi::PiPiFieldType::TextBox },
  { 1, PiPi::PiPiFieldType::CheckBox },
  { 2, PiPi::PiPiFieldType::Unknown }
};

static const std::map<PiPi::PiPiFieldType, unsigned int> invertFieldTypeMap = {
  { PiPi::PiPiFieldType::TextBox, 0 },
  { PiPi::PiPiFieldType::CheckBox, 1 },
  { PiPi::PiPiFieldType::Unknown, 2 }
};

static const std::map<unsigned int, PiPi::PiPiTextHorizontalAlignment> textHorizontalAlignmentMap = {
  { 0, PiPi::PiPiTextHorizontalAlignment::Left },
  { 1, PiPi::PiPiTextHorizontalAlignment::Center },
  { 2, PiPi::PiPiTextHorizontalAlignment::Right },
};

static const std::map<PiPi::PiPiTextHorizontalAlignment, unsigned int> invertTextHorizontalAlignmentMap = {
  { PiPi::PiPiTextHorizontalAlignment::Left, 0 },
  { PiPi::PiPiTextHorizontalAlignment::Center, 1 },
  { PiPi::PiPiTextHorizontalAlignment::Right, 2 },
};

template<typename T>
T handleException(int* code, int* exCode, int* exSubCode, std::function<T()> func);

void handleVoidException(int* code, int* exCode, int* exSubCode, std::function<void()> func);
