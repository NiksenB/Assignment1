using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
        //Flatten takes as argument a stream of a stream of T's. It should return a stream of T's.
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (IEnumerable<T> item in items)
            {
                foreach (T thing in item)
                {
                    yield return thing;
                }
            }
        }

        /* Filter takes as arguments a stream of T's and a function which returns true or false when 
        applied to an instance of T. It returns a stream of only the Ts where the predicate returns true. */
        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            throw new NotImplementedException();
        }

        public static void Main(string[] args) {
            var lilList = new List<int>{1,2,3};
            var lilBuddyList = new List<int>{3,4,5};
            var bigList = new List<List<int>> {lilList};

            foreach (int i in Flatten<int>(bigList)) {
                Console.WriteLine(i);
            }
        }
    }
}
