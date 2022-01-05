using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            return words != null && (ignoreCase ? 
                             words.Where(w => w != null).Select(x => x.ToLower()).Contains(word.ToLower()) 
                             : words.Contains(word));
        }

        public bool IsPrimeNumber(int num)
        {
            return num > 1 && Enumerable.Range(1, num).Where(x => num % x == 0).Count() == 2;
        }

        public int IndexOfLastUniqueLetter(string str)
        {

           var uniqueChars = str.Where((x, i) => str.Remove(i, 1).Contains(x) == false);

            return uniqueChars.Count() == 0 ? -1 : str.IndexOf(uniqueChars.Last());
        }


        public int MaxConsecutiveCount(int[] numbers)
        {
            return numbers.ToList().Select((x, i) => {
                var count = 1;
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] == numbers[j+1]) count++;
                    else break;
                }
                return count;
            }).Max();

            /*
              return numbers.Where((x, i) => i != 0
                                        && i < numbers.Length - 1 
                                        && x == numbers[i + 1]
                                        && x == numbers[i-1]
                                      ).Count() + 2;
            */
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            return elements == null  || n <= 0 ? new double[] { } 
                                                : elements.Where((x, i) => (i+1) % n == 0).ToArray();
        }
    }
}
