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
            List<int> list = new List<int>() { 1, 11, 1, 1, 2, 10, 1, 1 };
            List<int> outList;
            outList = finder.FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(list, 9);
            outList.ForEach(i => Console.Write("{0}\t", i));

            Console.ReadLine();

        }
    }
}
