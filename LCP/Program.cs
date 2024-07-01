using System;
using LCP;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PalindromeNumber palindromeNumber = new PalindromeNumber();
            TwoSum twoSum = new TwoSum();

            int[] nums = new int[] { 3, 3 };
            int target = 6;

            int[] data = twoSum.sumUp(nums, target);
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }

            bool test = palindromeNumber.checkIfPalindrome(1234);
            Console.WriteLine(test);
        }
    }
}