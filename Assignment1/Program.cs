using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lilList = new List<int>{1,2,3};
            var lilBuddyList = new List<int>{3,0,5};
            var bigList = new List<List<int>> {lilList, lilBuddyList};

            foreach (int i in Iterators.Flatten<int>(bigList)) {
                Console.WriteLine(i);
            }
        }
    }
}
