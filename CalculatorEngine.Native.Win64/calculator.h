#pragma once

#ifdef CALCULATOR_EXPORTS
#define CALCULATOR_API __declspec(dllexport)
#else
#define CALCULATOR_API __declspec(dllimport)
#endif

extern "C" CALCULATOR_API double __stdcall add(double a, double b);
extern "C" CALCULATOR_API double __stdcall subtract(double a, double b);
extern "C" CALCULATOR_API double __stdcall multiply(double a, double b);
extern "C" CALCULATOR_API double __stdcall divide(double a, double b);
