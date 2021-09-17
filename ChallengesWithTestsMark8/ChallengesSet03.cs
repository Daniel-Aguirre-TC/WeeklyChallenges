using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            return numbers == null? false: numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return new Regex(@"(?=.*[a-z])+(?=.*[A-Z])+(?=.*[0-9])+").IsMatch(password);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return new int[51].Select((x, i) => x = (i * 2) - 1).Skip(1).ToArray();
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
