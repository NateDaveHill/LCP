using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWords(string s)
        {
            List<string> words = new List<string>();
            List<string> tempWords = new List<string>();
            words = s.Split(' ').ToList();

            foreach (var word in words)
            {
                if (word != "")
                {
                    tempWords.Add(word);
                }
            }

            return tempWords[tempWords.Count - 1].Length;
        }
    }
}