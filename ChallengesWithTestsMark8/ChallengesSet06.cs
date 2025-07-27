using System;
using System.Linq;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words is null)
                return false;
            if (ignoreCase)
                foreach (string comp in words)
                {
                        if (comp is not null)
                        {
                            if (comp.ToLower().Equals(word.ToLower()))
                                return true;
                        }
                }
            else
                foreach (string comp in words)
                {
                    if (comp is not null)
                    {
                        if (comp.Equals(word))
                            return true;
                    }
                }
            return false;
        }
        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) 
            {
                return false;
            }
            if (num == 2)
            { 
                return true; 
            }

            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                    return false;                
            }
            return true;
        }
        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == "")
                return -1;
            if (str.Length == 1)
                return 0;
            int position = -1;
            for (int i = str.Length-1; i >= 0; i--)
            {
                if (str.Count(c => c == str[i]) == 1)
                    return i;
            }
            return position;
        }
        public int MaxConsecutiveCount(int[] numbers)
        {

            int tally = 0;
            int max = 0;
            for (int i = 1; i < numbers.Length; i++) 
            {

                if (numbers[i] == numbers[i - 1])
                {

                    tally++;
                }
                else
                    tally = 0;
                if (max < tally)
                {
                    max = tally;


                }
            }
            max++;
            return max;
        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if ((elements.Count == 0) || (n <= 0) || (elements is not { Count: > 0 }) || (!elements.Any()))
                    return new double[] { };
            if (n == 1)
                return elements.ToArray();
            List<double> result = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                while ((elements[i] != null) && (elements[i + 1] != null)) 
                { 
                
                    if ((i + 1) % n == 0)
                        result.Add(elements[i]);
                }

            }   
            return result.ToArray();
        }
    }
}
