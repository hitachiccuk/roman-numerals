using System;
using System.Text;

namespace RomanNumerals.Domain
{
    public class RomanNumeralConverter
    {
        public string ConvertToNumeral(int number)
        {
            StringBuilder numeral = new StringBuilder();

            double div = Convert.ToDouble(number) / 5;
            int remainder = number % 5;

            if (remainder == 4)
            {
                if (number > 10)
                {
                    numeral.Append("X");
                }
                AppendI(numeral, 1);
                numeral.Append(IsEven(div) ? "V" : "X");
            }
            else if (number > 4)
            {
                if (number >= 10)
                {
                    numeral.Append("X");
                    numeral.Append(ConvertToNumeral(number - 10));
                }
                else
                {
                    numeral.Append("V");
                    AppendI(numeral, remainder);
                }
            }
            else
            {
                AppendI(numeral, number);
            }

            return numeral.ToString();
        }

        private void AppendI(StringBuilder numeral, int number)
        {
            for (int i = 0; i < number; i++)
            {
                numeral.Append("I");
            }
        }

        private bool IsEven(double number)
        {
            return Math.Floor(number) % 2 == 0;
        }
    }
}
