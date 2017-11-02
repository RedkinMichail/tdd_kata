using System;

namespace tdd_kata
{
    internal static class StringCalculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            else
            {
                return Int32.Parse(input);
            }
        }
    }
}