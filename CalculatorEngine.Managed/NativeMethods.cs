using System.Runtime.InteropServices;

internal static class NativeMethods
{
    private const string LibraryName = "CalculatorEngine";  // The name of the native library (without the .dll extension)

    [DllImport(LibraryName, EntryPoint = "add", CallingConvention = CallingConvention.StdCall)]
    internal static extern double NativeAdd(double a, double b);

    [DllImport(LibraryName, EntryPoint = "subtract", CallingConvention = CallingConvention.StdCall)]
    internal static extern double NativeSubtract(double a, double b);

    [DllImport(LibraryName, EntryPoint = "multiply", CallingConvention = CallingConvention.StdCall)]
    internal static extern double NativeMultiply(double a, double b);

    [DllImport(LibraryName, EntryPoint = "divide", CallingConvention = CallingConvention.StdCall)]
    internal static extern double NativeDivide(double a, double b);
}