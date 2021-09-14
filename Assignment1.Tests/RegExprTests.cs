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

            //Act
            var actual = RegExpr.SplitLine(line);
            var expected = new List<string>{"hej", "med", "dig"};

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Resolution_8_tuples() 
        {
            //Arrange
            IEnumerable<string> resolutions = new string[]{"1920x1080, 1024x768"};

            //Act
            var actual = RegExpr.Resolution(resolutions);
            var expected = new List<(int, int)>(){(1920,1080), (1024,768)};

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
