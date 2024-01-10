#ifndef PCH_H
#define PCH_H

#ifdef PIPICSHARPWRAPPER_EXPORTS
#define PIPI_CSHARP_WRAPPER_API __declspec(dllexport)
#else
#define PIPI_CSHARP_WRAPPER_API __declspec(dllimport)
#endif
#define CALLING_CONVENTION __cdecl

#include "framework.h"
#include "pipi.h"

#endif
