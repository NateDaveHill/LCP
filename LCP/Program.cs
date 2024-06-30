using System;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 3 };
            int target = 6;

            int[] data = TwoSum(nums, target);
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }
    }
}