using Xunit;
using VowelCounterApp;
namespace VowelCounterApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void CountVowels_ReturnsCorrectCount_ForSimpleString()
        {
            int result = Program.CountVowels("Earth");
            Assert.Equal(2, result); // E, a
        }
        [Fact]
        public void CountVowels_ReturnsZero_ForNoVowels()
        {
            int result = Program.CountVowels("Violin");
            Assert.Equal(3, result);
        }
        [Fact]
        public void CountVowels_IgnoresCase()
        {
            int result = Program.CountVowels("aeIoU");
            Assert.Equal(5, result);
        }
        [Fact]
        public void CountVowels_ReturnsZero_ForEmptyString()
        {
            int result = Program.CountVowels("");
            Assert.Equal(0, result);
        }
    }
}