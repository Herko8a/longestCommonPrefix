using System;
using System.Linq;

namespace MaxPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix2(words));
        }

        static string LongestCommonPrefix(string[] strs)
        {
            string longPrefix = "";
            string word = strs.OrderBy(x => x.Length).FirstOrDefault();

            for (int i = 0; i < word.Length; i++)
            {
                bool valid = true;
                char ltr = word[i];

                for (int j = 1; j < strs.Length; j++)
                {
                    valid = valid && (strs[j].Length > i) && (ltr == strs[j][i]);
                    if (!valid) break;
                }

                if (valid)
                    longPrefix += ltr;
                else
                    break;
            }

            return longPrefix;
        }

        static string LongestCommonPrefix2(string[] strs)
        {
            string longPrefix = "";
            strs = strs.OrderBy(x => x.Length).ToArray();

            for (int i = 0; i < strs[0].Length; i++)
            {
                if (strs.Count(x => x[i] != strs[0][i]) > 0) break;
                longPrefix += strs[0][i];
            }

            return longPrefix;
        }

    }
}
