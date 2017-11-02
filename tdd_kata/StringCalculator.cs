using System;

namespace tdd_kata
{
    internal static class StringCalculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            if (input.Contains(","))
            {
                var numbers = input.Split(',');
                return Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]);
            }
            return Int32.Parse(input);
        }
    }
}