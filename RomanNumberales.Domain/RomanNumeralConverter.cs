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

            if (DoesntFollowPattern(number))
            {
                if (number > 10)
                {
                    numeral.Append("X");
                }
                AppendI(numeral, 1);
                if (IsEven(div))
                    numeral.Append("V");
                else
                    numeral.Append("X");
            }
            else if (IsVOrX(number))
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

        private bool DoesntFollowPattern(int number)
        {
            double div = Convert.ToDouble(number) / 5;

            return Math.Round(div - Math.Floor(div), 1) == 0.8;
        }

        private bool IsVOrX(int number)
        {
            return Convert.ToDouble(number) / 5 >= 0.7;
        }

        private bool IsEven(double number)
        {
            return Math.Floor(number) % 2 == 0;
        }
    }
}
