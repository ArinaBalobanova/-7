using System;

namespace Домашняя_работа_7.Classes
{
    class ReverseStringProgram
    {
        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
