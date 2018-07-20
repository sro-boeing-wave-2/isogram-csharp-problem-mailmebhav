using isogram;
using System;
using Xunit;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Class1.CheckIsogram(""));
        }
        [Fact]
        public void Test2()
        {
             Assert.True(Class1.CheckIsogram("isogram"));
        }
        [Fact]
        public void Test3()
        {
            Assert.False(Class1.CheckIsogram("eleven"));
        }
        [Fact]
        public void Test4()
        {
            Assert.True(Class1.CheckIsogram("subdermatoglyphic"));
        }
        [Fact]
        public void Test5()
        {
            Assert.True(Class1.CheckIsogram("Alphabet"));
        }
        [Fact]
        public void Test6()
        {
            Assert.True(Class1.CheckIsogram("thumbscrew-japingly"));
        }
        [Fact]
        public void Test7()
        {
            Assert.True(Class1.CheckIsogram("six-year-old"));
        }
        [Fact]
        public void Test8()
        {
            Assert.True(Class1.CheckIsogram("abc def"));
        }
    }
}
