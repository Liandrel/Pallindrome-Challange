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
            string reversed = "";

            for (int i = normal.Length - 1; i > -1; i--)
            {
                reversed += normal[i];
            }

            normal = normal.RemoveSpecialCharacters();
            reversed = reversed.RemoveSpecialCharacters();

            if(normal == reversed)
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
