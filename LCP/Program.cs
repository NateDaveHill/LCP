using System;
using LCP;

namespace LeetCodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PalindromeNumber palindromeNumber = new PalindromeNumber();
            //TwoSum twoSum = new TwoSum();
            //MergeTwoSortedLists merge = new MergeTwoSortedLists();


            ////------------------------------------------------------
            //int[] nums = new int[] { 3, 3 };
            //int target = 6;

            //int[] data = twoSum.sumUp(nums, target);
            //foreach (var i in data)
            //{
            //    Console.WriteLine(i);
            //}

            ////------------------------------------------------------
            //bool test = palindromeNumber.checkIfPalindrome(1234);
            //Console.WriteLine(test);

            //------------------------------------------------------
            //ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //ListNode node3 = new ListNode(3);
            //ListNode node4 = new ListNode(4);

            //node1.next = node2;
            //node2.next = node3;
            //node3.next = node4;

            //ListNode list1 = node1;
            //ListNode list2 = node2;

            //ListNode newList = merge.mergeTwoSortedLists(list1, list2);
            //Console.ReadKey();

            //------------------------------------------------------
            //string s;

            ////s = "Hello World";
            ////s = "   fly me   to   the moon  ";
            //s = "luffy is still joyboy";

            //LengthOfLastWord lengthOfLastWord = new LengthOfLastWord();
            //Console.WriteLine(lengthOfLastWord.LengthOfLastWords(s));

            //------------------------------------------------------
            int[] prices = new int[] { 1,2 };
            //int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            //int[] prices = new int[] { 7, 6, 4, 3, 1 };
            MaxProfitAlgo maxProfitAlgo = new MaxProfitAlgo();

            int test = maxProfitAlgo.MaxProfit(prices);
            Console.WriteLine(test);


        }
    }
}