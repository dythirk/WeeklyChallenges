using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
                
            startNumber++;
            for (int i = startNumber; true; i++) 
            {
                if (i % n == 0)
                    return i;
                
            }


        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                    bus.Name = "CLOSED";
            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;
            


            else
            {
                int tally = numbers[0];
                for (int i = 0; i < numbers.Length-1; i++) 
                {
                    if (numbers[i] > numbers[i+1])
                        return false;
                }
                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
                return 0;
            else 
            {
                int tally = 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                        tally += numbers[i + 1];
                }
                return tally;
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";
            else 
            {
                string sentence = "";
                foreach (string word in words) 
                {
                    if (!string.IsNullOrWhiteSpace(word))
                    sentence += word.Trim() + " ";
                }
                if (sentence == "")
                    return "";
                sentence = sentence.Trim() + ".";
                return sentence;
            
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0) 
                return new double[0];
            else 
            {
                List<double> quad = new List<double>();
                for (int i = 0; i < elements.Count; i++)
                {
                    if ((i+1) % 4 == 0)
                        quad.Add(elements[i]);
                }
                return quad.ToArray();
            }
                throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
