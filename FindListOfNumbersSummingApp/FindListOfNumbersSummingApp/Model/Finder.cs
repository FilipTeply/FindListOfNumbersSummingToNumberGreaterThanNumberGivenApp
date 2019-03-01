using System;
using System.Collections.Generic;
using System.Linq;

namespace FindListOfNumbersSummingApp
{
    internal class Finder
    {
        internal List<int> FindListOfNumbersSummingToNumberGreaterThanNumberGivenApp(List<int> list, int targetSumMinusOne)
        {
            List<int> outList = new List<int>();
            int actualSum = 0;

            if (!CheckIfValidSolutionExists(list, targetSumMinusOne))
            {
                Console.WriteLine("The sum of all numbers in the list is not greater than given number: " + targetSumMinusOne +
                    ". The task does not have solution.");
                return outList;
            }

            int minimalCountOfNumbersSummingGreater;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < list.Count(); j++)
                {
                    if (SumOfNumbersFromIndexXtoIndexYInclusive(list, i, j) > targetSumMinusOne)
                    {
                        sum1 = SumOfNumbersFromIndexXtoIndexYInclusive(list, i, j);
                        outList = list.GetRange(i, j + 1);
                        minimalCountOfNumbersSummingGreater = j - i + 1;
                        continue;
                    }
                }
            }
            return outList;


            //for (int i = 0; i < list.Count(); i++)
            //{

            //    if (true) { }

            //    if (list[i] >= targetSumMinusOne)
            //    {
            //        outList.Add(list[i]);
            //    }

            //}
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

            for (int i = fromIndexX; i <= toIndexY; fromIndexX++)
            {
                sum += list[i];
            }
            return sum;
        }

    }
}
