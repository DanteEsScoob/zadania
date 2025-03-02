// See https://aka.ms/new-console-template for more information

using System;

namespace Nauka;

    class MyClass
    {
        static void Main(string[] args)
        {
            var a = 1;
            var d = 2l;
            var b = 1.0;
            var c = 1.5f;
            var done = true;
            while (!done)
            {
                Console.WriteLine("Hello World!");
            }
            if (done)
            {
                Console.WriteLine("Hello There!");
                done = false;
            }
            else
            {
                Console.WriteLine("General Kenobi");
                done = true;
            }


        }
    }
