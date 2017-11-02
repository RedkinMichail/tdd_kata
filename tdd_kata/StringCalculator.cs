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
                var result = 0;
                var numbers = input.Split(',', '\n');
                foreach (var number in numbers)
                {
                    result += Int32.Parse(number);
                }
                return result;
            }
            return Int32.Parse(input);
        }
    }
}