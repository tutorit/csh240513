using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax
{
    internal static class MyExtensions
    {

        public static string Left(this string s, int n)
        {
            return s.Substring(0, n);   
        }

        public static string Right(this string s, int n)
        {
            return s.Substring(s.Length - n);
        }
    }
}
