using FindListOfNumbersSummingApp.Model;
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
            List<int> list = new List<int>() { 5, 3, 3, 6, 12, 5, 2, 3 };
            List<int> outList;
            outList = finder.FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(list, 9);

            outList.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadLine();

        }
    }
}
