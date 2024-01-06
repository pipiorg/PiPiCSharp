#ifndef PCH_H
#define PCH_H

#ifdef PIPI_CSHARP_WRAPPER_EXPORTS
#define PIPI_CSHARP_WRAPPER_API __declspec(dllexport)
#else
#define PIPI_CSHARP_WRAPPER_API __declspec(dllimport)
#endif
#define CALLING_CONVENTION __cdecl

#include "framework.h"

#endif
