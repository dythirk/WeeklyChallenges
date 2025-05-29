using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CharacterIsNotALetter(char c)
        {
            return !Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Count() % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;
            double min= numbers.Min();
            double max = numbers.Max();

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
                return str1.Length;
            else
                return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            else
                return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            var total = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                    total += i;
            }
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            else
                return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for (int i = 1; i < number; i++)
            {
                if ((i > 0 ) & ((i % 2) == 1))
                    count++;
            }
            return count;
        }
    }
}
