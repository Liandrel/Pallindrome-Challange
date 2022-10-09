using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindromeChall
{
    public static class PallindromeCheckLogic
    {
        public static bool IsAPallindrome<T>(T input)
        {
            bool output = false;

            string normal = input.ToString();
            string reversed = new string(normal.Reverse().ToArray());


            normal = normal.RemoveSpecialCharacters();
            reversed = reversed.RemoveSpecialCharacters();

            if (string.Compare(normal,reversed) == 0)
            {
                output = true;
            }

            return output;
        }
        private static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().ToLower();
        }
    }

}
