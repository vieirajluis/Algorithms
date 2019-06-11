using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CrackCodingSharp
{
    class PermutationOfPalindrome
    {
        private static bool checkPermutationOfPalindrome(String str)
        {
            char[] arr = (Regex.Replace(str, @"\s", "")).ToLower().ToCharArray();
            var map = new Dictionary<char, int>();

            foreach (char ch in arr)
            {
                int count = 1;

                if (map.ContainsKey(ch))
                {
                    count = map[ch];
                    count++;
                    map.Remove(ch);
                }
                map.Add(ch, count);


            }

            bool foundOdd = false;
            // return false if more than one odd found
            foreach (var item in map)
            {

                Console.WriteLine("" + item.Key + ":" + item.Value);
                if (item.Value % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    foundOdd = true;
                }
            }
            return true;
        }

        //Test cases
        static void Main(string[] args)
        {
            //Palindrome:“race car”, “anna”, “tabcbat” ,“otabcbato”

            //car race -> true
            //abcde-> false
            string strs = "Tact Coa";
            Console.WriteLine("{0}", checkPermutationOfPalindrome(strs));
        }
    }
}
