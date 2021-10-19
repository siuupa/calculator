using System;

namespace Testing
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int CompareValuesAndReturnGreater(int a, int b)
        {
            if (a == b || a > b)
                return a;
            else
                return b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}