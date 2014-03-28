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
            int rem = number % 5;

            if (div - Math.Floor(div) == 0.8)
            {
                AppendI(numeral, 1);
                if (Math.Floor(div) % 2 == 0)
                    numeral.Append("V");
                else
                    numeral.Append("X");
            }
            else if (div >= 0.7)
            {
                if (number >= 10)
                    numeral.Append("X");
                else
                    numeral.Append("V");

                AppendI(numeral, rem);
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
    }
}
