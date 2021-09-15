using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_hej_med_dig() 
        {
            //Arrange
            IEnumerable<string> line = new string[]{"hej med dig"};
                var expected = new List<string>{"hej", "med", "dig"};

            //Act
            var actual = RegExpr.SplitLine(line);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Resolution_8_tuples() 
        {
            //Arrange
            IEnumerable<string> resolutions = new string[]{"1920x1080, 1024x768"};

            var expected = new List<(int, int)>(){(1920,1080), (1024,768)};

            //Act
            var actual = RegExpr.Resolution(resolutions);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void InnerText_html_a_six_results(){
            //Arrange
            string html = "<div> \n <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p> \n </div>";
            string tag = "a";
            IEnumerable<string> expected = new string[]{"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};
            
            //Act
            var actual = RegExpr.InnerText(html, tag);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void InnerText_html_p_six_results(){
            //Arrange
            string html = "<div> \n    <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p> \n </div>";
            string tag = "p";
            IEnumerable<string> expected = new string[]{"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};
            
            //Act
            var actual = RegExpr.InnerText(html, tag);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
