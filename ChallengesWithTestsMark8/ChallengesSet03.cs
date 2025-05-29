using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //if (numbers == null)
            //    return false;
            //else
            //{
            //    int total = 0;
            //    foreach (int n in numbers)
            //    {
            //        if (numbers(n) % 2 == 0)
            //            total += numbers[n];
            //    }
            //}
            throw new NotImplementedException();


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) & password.Any(char.IsLower) & password.Any(char.IsDigit))
                return true;
            else
                return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        
        }

        public int[] GetOddsBelow100()
        {
            int[] odd = {};
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 != 0)
                    odd = odd.Concat(new int[] { i }).ToArray();
            }
            return odd;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
