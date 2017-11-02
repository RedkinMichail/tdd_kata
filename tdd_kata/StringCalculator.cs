using System;

namespace tdd_kata
{
    internal static class StringCalculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            if (input.StartsWith("//"))
            {
                var delimeter = input[2];
                input = input.Substring(4);
                var numbers = GetNumbers(input, delimeter);
                return GetSum(numbers);

            }
            if (input.Contains(",") || input.Contains("\n"))
            {
                var numbers = GetNumbers(input, ',', '\n');
                return GetSum(numbers);
            }
            return Int32.Parse(input);
        }

        private static string[] GetNumbers(string input,params char[] delimeter)
        {
            return input.Split(delimeter);
        }

        private static int GetSum(string[] numbers)
        {
            var result = 0;
            foreach (var number in numbers)
            {
                result += Int32.Parse(number);
            }

            return result;
        }
    }
}