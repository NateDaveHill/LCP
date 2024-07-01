using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    public class PalindromeNumber
    {
        public static bool checkIfPalindrome(int num)
        {

            List<int> listOfInt = num.ToString()
                .Select(digit => int.Parse(digit.ToString()))
                .ToList();

            List<int> reversedListOfInt = listOfInt.AsEnumerable().Reverse().ToList();

            var result = listOfInt.Zip(reversedListOfInt, (a, b) => new { AreEqual = a == b });

            foreach (var item in result)
            {
                if (item.AreEqual)
                {
                    continue;
                }

                return false;
            }
            return true;

        }


        // simplified chatGpt solution
        //public static bool checkIfPalindrome(int num)
        //{
        //    if (num < 0)
        //    {
        //        return false;
        //    }

        //    var digits = num.ToString().ToCharArray();
        //    return digits.SequenceEqual(digits.Reverse());
        //}
    }
}
