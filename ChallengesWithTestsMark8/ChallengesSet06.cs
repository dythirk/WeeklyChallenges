using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            if (elements == null || n <= 0 || n > elements.Count)
                return Array.Empty<double>();

            //if ((n <= 0) || (elements.Count == 0) || (elements is not { Count: > 0 }) || (!elements.Any()))
            //    return new double[] { };
            //if (elements == 0)
            //    return new double[] { };
            //if (elements.Count == 0)
            //    return new double[] { }; 
            //if (elements is not { Count: > 0 })
            //    return new double[] { }; 
            //if (!elements.Any())
            //    return new double[] { };
            //if (!(elements != null))
            //    return new double[] { };
            //if (elements is not null)
            //    return new double[] { };

            // I give up, I can not for the life of me get a null entry to return an empty array.
            // I am submitting this so you can tell me what I'm doing wrong. As you can tell, I've tried a lot of things.

            if (n == 1)
                return elements.ToArray();

                
            List<double> result = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                    if ((i + 1) % n == 0)
                        result.Add(elements[i]);
            }   
            return result.ToArray();
        }
    }
}
