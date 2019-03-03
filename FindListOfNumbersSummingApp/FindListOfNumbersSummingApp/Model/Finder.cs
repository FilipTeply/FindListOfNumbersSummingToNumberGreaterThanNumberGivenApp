using System;
using System.Collections.Generic;
using System.Linq;

namespace FindListOfNumbersSummingApp.Model
{
    internal class Finder
    {
        internal List<int> FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(List<int> list, int targetSumMinusOne)
        {
            List<int> actualOutList = new List<int>();
            List<int> minimalOutList = new List<int>(list);
            int minimalCount = list.Count();

            if (!CheckIfValidSolutionExists(list, targetSumMinusOne))
            {
                Console.WriteLine("The sum of all numbers in the list is not greater than given number: " + targetSumMinusOne +
                    ". The task does not have solution.");
                return minimalOutList;
            }

            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < list.Count() - i + 1; j++)
                {
                    actualOutList = list.GetRange(i, j).ToList();

                    if (actualOutList.Sum() > targetSumMinusOne && actualOutList.Sum() <= minimalOutList.Sum())
                    {
                        minimalOutList = list.GetRange(i, j).ToList();
                        minimalCount = minimalOutList.Count();
                        //if (minimalCount > actualOutList.Count() && actualOutList.Sum() < minimalOutList.Sum())
                        //{
                        //    minimalOutList = list.GetRange(i, j).ToList();
                        //}
                        i++;
                        j -= 2;
                    }
                }
            }
            return minimalOutList;
        }

        public bool CheckIfValidSolutionExists(List<int> list, int targetSumMinusOne)
        {
            if (list.Sum() <= targetSumMinusOne)
            {
                return false;
            }
            return true;
        }

        public int SumOfNumbersFromIndexXtoIndexYInclusive(List<int> list, int fromIndexX, int toIndexY)
        {
            int sum = 0;

            for (int i = fromIndexX; i <= toIndexY; i++)
            {
                sum += list[i];
            }
            return sum;
        }
    }
}
