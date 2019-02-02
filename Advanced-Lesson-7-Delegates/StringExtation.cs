using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    public static class StringExtation
    {
        public delegate string Formatter(string str);

        public static string[] Format(this string[] str, Formatter formatter)
        {
            string[] arr = new string[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                arr[i] = formatter(str[i]);
            }
            return arr;
        }
    }
}
