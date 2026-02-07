namespace CalculatorEngine  // will be the using statement for the consumer of this library
{
    public static class Calculator  // will be the class with which the consumer of this library will interact
    {
        public static double Add(double a, double b)
            => NativeMethods.NativeAdd(a, b);

        public static double Subtract(double a, double b)
            => NativeMethods.NativeSubtract(a, b);

        public static double Multiply(double a, double b)
            => NativeMethods.NativeMultiply(a, b);

        public static double Divide(double a, double b)
        {
            if (b == 0) throw new System.DivideByZeroException("cannot divide by zero");
            return NativeMethods.NativeDivide(a, b);
        }

    }
}