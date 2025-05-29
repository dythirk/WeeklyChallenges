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

            //var min = numbers[0];
            //var max = numbers[0];
            //foreach ( var number in numbers)
            //{
            //    if (numbers[number] < min)
            //        min = numbers[number];
            //    if (numbers[number] > max)
            //        max = numbers[number];
            //}
            //return min + max;

            return 0;


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
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
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
            throw new NotImplementedException();
        }
    }
}
