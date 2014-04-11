using RomanNumerals.Domain;
using Xunit;
using Xunit.Extensions;

namespace RomanNumerals.UnitTests
{
    public class RomanNumeralConverterTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        public void ConvertReturnsExpected(int number, string numeral)
        {
            AssertEqual(number, numeral);
        }

        private void AssertEqual(int number, string expected)
        {
            RomanNumeralConverter sut = new RomanNumeralConverter();
            string result = sut.ConvertToNumeral(number);
            Assert.Equal(expected, result);
        }
    }
}
