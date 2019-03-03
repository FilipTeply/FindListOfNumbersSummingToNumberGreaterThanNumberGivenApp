using FindListOfNumbersSummingApp.Model;
using System;
using System.Collections.Generic;

namespace FindListOfNumbersSummingApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Finder finder = new Finder();
            List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1, 9};
            //List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1 };
            //List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1, 9, 10 };
            //List<int> list = new List<int>() { 5, 3, 3, 6, 12, 9, 2, 5, 3, 2, 11, 1, 1, 8, 1, 1 };
            int givenNumber = 9;
            List<int> outList;
            outList = finder.FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(list, givenNumber);
            Console.WriteLine("Hi, a minimal sublist from:");
            list.ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine("\nsumming greater than a number " + givenNumber + " is:");
            outList.ForEach(i => Console.Write("{0}, ", i));
            Console.ReadLine();

        }
    }
}
