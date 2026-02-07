#include "pch.h"
#include <stdexcept>
#include "calculator.h"

// Define CALCULATOR_EXPORTS in the DLL project's properties 
// (Project Properties -> C/C++ -> Preprocessor Definitions)
// zzSWS huh?

double __stdcall add(double a, double b) {
    return a + b;
}

double __stdcall subtract(double a, double b) {
    return a - b;
}

double __stdcall multiply(double a, double b) {
    return a * b;
}

double __stdcall divide(double a, double b) {
    return a / b;
}
