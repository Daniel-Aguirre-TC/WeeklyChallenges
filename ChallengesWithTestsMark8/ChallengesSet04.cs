using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new string[] { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return  sideLength1 + sideLength2 > sideLength3 &&
                    sideLength2 + sideLength3 > sideLength1 &&
                    sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > objs.Where(x => x != null).Count();
        }

        public double AverageEvens(int[] numbers)
        {
            return numbers == null || numbers.Where(x => x % 2 == 0).Count() == 0 ?
                                        0 : numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
           return number == 0 ? 1 : Enumerable.Range(1, number).Aggregate((x, i) => x * i);
    }
    }
}
