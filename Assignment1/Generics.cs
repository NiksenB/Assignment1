using System;
using System.Collections.Generic;

namespace Assignment1.obj
{
    public class stuff {

        /*int GreaterCount<T, U>(IEnumerable<T> items, T x)
        where T : IComparable<T> {
            foreach (T item in items){
                if (item > x) {yield return T}
            }
        }*/

public static void Main(string[] args)
{
    var liste = 1;
    var test = new List<int>();


    GreaterCount<int, List<int>>(test, liste);

}
        static int GreaterCount<T, U>(IEnumerable<T> items, T x)
        where T : U
        where U : IComparable<U>
        {




            return 1;
        }

    }

}