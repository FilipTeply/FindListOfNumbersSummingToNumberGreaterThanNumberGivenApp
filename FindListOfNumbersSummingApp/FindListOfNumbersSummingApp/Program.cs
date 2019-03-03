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
            //List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1, 9};
            //List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1 };
            List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1, 9, 10 };
            List<int> outList;
            outList = finder.FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(list, 9);

            outList.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadLine();

        }
    }
}
