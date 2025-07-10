using System;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;
            else
            {
                int evens = 0;
                int odds = 0;
                foreach(var i in numbers)
                {
                    if (i % 2 == 0)
                        evens += i;
                    else
                        odds += i;
                }
                return evens - odds;

            }

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] foo = new string[] { str1, str2, str3, str4 };
            foo = foo.OrderByDescending(x => x).ToArray();
            return foo[3].Length;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] small = new int[] { number1, number2, number3, number4 };
            small = small.OrderBy(x => x).ToArray();
            return small[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] triangle = new int[] { sideLength1, sideLength2, sideLength3};

            int[] sorted = triangle.OrderByDescending(x => x).ToArray();

            if ((sideLength1 <= 0) || (sideLength2 <= 0) || (sideLength3 <= 0))
                return false;
            else if ((sideLength1 == sideLength2) && (sideLength1 + sideLength2 > sideLength3))
                return true;
            else if ((sideLength1 == sideLength3) && (sideLength1 + sideLength3 > sideLength2))
                return true;
            else if ((sideLength2 == sideLength3) && (sideLength2 + sideLength3 > sideLength1))
                return true;
            else if (sorted[1] + sorted[2] > sorted[0])
                return true;
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers?.Length > 0)
            {
                double tally = 0;
                double sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        tally++;
                        sum += numbers[i];
                    }
                }
                if (tally == 0)
                    return 0;
                else
                {
                    return sum / tally;

                }
            }
            else
                return 0;

        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;
            int fact = 1;
            for (int i = 1; i < number + 1; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
