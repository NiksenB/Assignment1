using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_integers_123_340_returns_123340(){
            
            //Arrange
            var list1 = new List<int>{1,2,3};
            var list2 = new List<int>{3,4,0};
            var bigList = new List<List<int>> {list1, list2};

            //Act
            var actual = Iterators.Flatten<int>(bigList);
            IEnumerable<int> expected = new []{1,2,3,3,4,0};

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Flatten_strings_heyhello_ab_returns_heyhelloab(){
            
            //Arrange
            var stack1 = new Stack<string>();
            stack1.Push("Hey");
            stack1.Push("Hello");
            var stack2 = new Stack<string>();
            stack2.Push("A");
            stack2.Push("B");
            var bigStack = new Stack<Stack<string>>();
            bigStack.Push(stack1);
            bigStack.Push(stack2);

            //Act
            var actual = Iterators.Flatten<string>(bigStack);
            IEnumerable<string> expected = new []{"B", "A", "Hello", "Hey"};

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Filter_returns_246() {
            //Arrange
            var testliste = new List<int>{1,2,3,4,5,6};
            var expected = new List<int>{2,4,6};
            Predicate<int> even = Iterators.Even;

            //Act
            var actual = Iterators.Filter<int>(testliste, even);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
