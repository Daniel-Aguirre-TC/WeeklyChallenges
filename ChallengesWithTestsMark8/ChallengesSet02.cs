using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return new Regex(@"[a-zA-Z]").IsMatch(c.ToString());
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;
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
            return numbers == null  || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 0 ? number / 2 : 0;
        }
    }
}
