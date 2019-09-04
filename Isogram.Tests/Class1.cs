using System;
using isogram_csharp_problem;
using Xunit;

namespace Isogram.Tests
{
    public class Class1
    {
        [Fact]
        public void isogramcheck_emptyString()
        {
            Assert.Equal(true,Program.isogram(""));
        }
        [Fact]
        public void isogramcheck_lowercase()
        {
            Assert.Equal(true, Program.isogram("isogram"));
        }
        [Fact]
        public void isogramcheck_eleven()
        {
            Assert.Equal(false, Program.isogram("eleven"));
        }
        [Fact]
        public void isogramcheck_longEnglishWords()
        {
            Assert.Equal(true, Program.isogram("subdermatoglyphic"));
        }
        [Fact]
        public void isogramcheck_duplicateCharactersMixedCase()
        {
            Assert.Equal(true, Program.isogram("Alphabet"));
        }
        [Fact]
        public void isogramcheck_hyphen()
        {
            Assert.Equal(true, Program.isogram("thumbscrew-japingly"));
        }
        [Fact]
        public void isogramcheck_duplicateHyphen()
        {
            Assert.Equal(true, Program.isogram("six-year-old"));
        }
        [Fact]
        public void isogramcheck_spaces()
        {
            Assert.Equal(true, Program.isogram("take m b"));
        }
    }
}
