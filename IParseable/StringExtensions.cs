using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IParseable
{
    public static class StringExtensions
    {
         // extension method immer statisch
        public static int CountWords(this string s) // Datentyp benennen welcher erweitert wird "this" und den Datentyp
        {
            return s.Split(' ').Length;
        }

        public static T Parse<T>(this string s) 
            where T : IParsable<T>
        {
            return T.Parse(s, null);
        }
    }
}
