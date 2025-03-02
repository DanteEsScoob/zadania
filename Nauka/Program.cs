// See https://aka.ms/new-console-template for more information

using System;

namespace Nauka;

    class MyClass
    {
        static void Main(string[] args)
        {

        }

        public static int tabAnalyzer(int[] arr)
        {
            var res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }
            return res;
        }
    }
