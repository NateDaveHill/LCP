using System;
using LCP;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 3 };
            int target = 6;

            int[] data = TwoSum.sumUp(nums, target);
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }

            bool test = PalindromeNumber.checkIfPalindrome(1234);
            Console.WriteLine(test);
        }
    }
}