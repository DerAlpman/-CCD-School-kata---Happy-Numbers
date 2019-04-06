using System;
using System.Collections.Generic;

namespace HappyNumbers
{
    public static class HappyNumberChecker
    {
        public static bool IsHappyNumber(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return true;
            }

            numberToCheck = CalculateNext(numberToCheck);
            return IsHappyNumber(numberToCheck);
        }

        internal static IEnumerable<object> GetHappyNumbersInRange(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (IsHappyNumber(i))
                {
                    yield return i;
                }
            }
        }

        private static int CalculateNext(int numberToCheck)
        {
            var digits = GetDigits(numberToCheck);

            double next = 0;

            foreach (var digit in digits)
            {
                next += Math.Pow(digit, 2.0);
            }

            return (int)next;
        }

        private static int[] GetDigits(int numberToCheck)
        {
            int[] digits = new int[1 + (int)Math.Log10(numberToCheck)];
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit;
                numberToCheck = Math.DivRem(numberToCheck, 10, out digit);
                digits[i] = digit;
            }

            return digits;
        }
    }
}
