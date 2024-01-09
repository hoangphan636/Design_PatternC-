using System;
using System.Collections.Generic;
using System.Reflection;

namespace Phan.Cao.Khoa
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Create new object List<string>
            List<int> listData = new List<int>() { 6, 7, 3, 3, 1, 7, 4, 3, 7, 2, 8, 5, 7, 4 };

            // Display all position number 7 in list object 
            //foreach (var index in GetListIndex1(listData, 7))
            //    Console.Write(index + " ");
           
            //foreach (var index in GetListIndex2(listData, 7))
            //    Console.WriteLine(index + " ");

            foreach (var index in GetListIndex2s(listData, 7))
                Console.WriteLine(index + " ");

            // Output: 1 5 8 12
        }

        // Usually Dev use this scenario
        private static List<int> GetListIndex1(List<int> listData, int valueFind)
        {
            List<int> listIdx = new List<int>();
            for (int ii = 0; ii < listData.Count; ii++)
            {
                if (listData[ii] == valueFind)
                    listIdx.Add(ii);
            }
            return listIdx;
        }

        // Use yield
        private static IEnumerable<int> GetListIndex2(List<int> listData, int valueFind)
        {
            for (int ii = 0; ii < listData.Count; ii++)
            {
                if (listData[ii] == valueFind)
                    yield return ii;
            }
        }
        private static IEnumerable<int> GetListIndex2s(this IEnumerable<int> enumerable, int valueFind)
        {
            return enumerable.Concat(new int[] { valueFind });
        }
    }
}
