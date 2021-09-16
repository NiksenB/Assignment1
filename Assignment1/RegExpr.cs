using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {                   
            Regex rg = new Regex(@"\w+");

            foreach (string item in lines) 
            {
                MatchCollection words = rg.Matches(item);
                foreach (Match word in words)
                {
                    yield return word.Value.Replace("_","");
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
            Regex rg = new Regex(@"(?<width>\d+)[x](?<height>\d+)");

            foreach (var resolution in resolutions)
            {
                var matches = rg.Matches(resolution);
                foreach (Match match in matches)
                {
                        GroupCollection groups = match.Groups;
                        int w = Int32.Parse(groups["width"].Value);
                        int h = Int32.Parse(groups["height"].Value);

                        yield return (w, h);
                }
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            string a = "<";
            string b = ".*?>(.*?)<\\/";
            string c = ">*";

            Regex rg = new Regex(@a+tag+b+tag+c);

            string newP = @"<\/?[a-z]{0,10}>";

            foreach (Match match in rg.Matches(html)) 
            {
                GroupCollection groups = match.Groups;
                var newRg = Regex.Replace(groups[1].Value, newP, "");
                
                yield return newRg;
            }
        }
    }
}
