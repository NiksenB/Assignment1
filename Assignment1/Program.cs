using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Innertext exercise
            string html = "<div> \n    <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p> \n </div>";
            string tag = "p";
            foreach (string i in RegExpr.InnerText(html,tag))
            {
                 Console.WriteLine(i);
            }
            
            //Resolution exercise
            // var res = "1920x1080, 1024x768, 800x600, 640x480, 320x200, 320x240, 800x600, 1280x960";
            // foreach (var i in RegExpr.Resolution(new string[]{res}))
            // {
            //     Console.WriteLine(i);
            // }

            // SplitLine exercise
            /*var ord = "hej med dig";
            foreach (string i in RegExpr.SplitLine(new string[]{ord}))
            {
                Console.WriteLine(i);
            }*/
        

            // Filter exercise
            /*var liste = new List<int>{1,2,3,4,5,6};
            Predicate<int> even = Iterators.Even;
            foreach (int i in Iterators.Filter<int>(liste, even)) {
                Console.WriteLine(i);
            }*/
            
            // Flatten exercise
            /*var lilList = new List<int>{1,2,3};
            var lilBuddyList = new List<int>{3,0,5};
            var bigList = new List<List<int>> {lilList, lilBuddyList};

            foreach (int i in Iterators.Flatten<int>(bigList)) {
                Console.WriteLine(i);
            }*/
        }
    }
}
