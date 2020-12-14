using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var derek = char.IsLetter(c);
            return derek;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
           if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
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
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            
            return numbers.Min() + numbers.Max();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Where(n => n % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int odds = 0;
            foreach (int num1 in numbers)
            {
                odds += num1;
            }
            
                    
                if (odds % 2 != 0)
                {
                    return true;
                }
            
            return false; 
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            long count = 0;

            for (int i = 1; i < number; i++)
            
            {
                if ( i % 2 != 0)
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
