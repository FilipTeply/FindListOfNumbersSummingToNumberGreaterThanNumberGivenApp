using System;
using System.Collections.Generic;

namespace FindListOfNumbersSummingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Finder finder = new Finder();
            List<int> list = new List<int>() {1,11,1,10 };
            finder.FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(list,9);

        }
    }
}
