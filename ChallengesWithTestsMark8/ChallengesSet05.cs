using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return Enumerable.Range(++startNumber, startNumber + n).Where(x => x % n == 0).First();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            businesses.Where(x => !(x.TotalRevenue > 0)).Select(x => x.Name = "CLOSED").ToList();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            return numbers != null && numbers.Length > 0 && numbers.SequenceEqual(numbers.OrderBy(x => x));            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Where((x, i) => i != 0 && numbers[i - 1] % 2 == 0).Sum(x => x);
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            return words == null || words.Where(x => x.Trim() != "").Count() == 0 ? 
                                    "" : string.Join(' ', words.Where(x => x.Trim() != "").
                                         Select(x => x.Trim())) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            return elements == null ? new double[] { } : elements.Where(x => x % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {

            return nums.Select((a, i) => nums.Where((check, index) => index != i).
                            Select(b => a + b).Contains(targetNumber)).Any(result => result);
        }
    }
}
