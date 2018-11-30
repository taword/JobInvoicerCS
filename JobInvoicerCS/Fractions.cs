using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace JobInvoicerCS
{
    public class Fractions
    {
        private const double OneSixteenth = 0.0625D;

        public string DoubleToFraction(double aDouble)
        {
            var remainder = Convert.ToInt32(aDouble / OneSixteenth);
            switch (remainder)
            {
                case 1:
                    return "1/16";
                case 2:
                    return "1/8";
                case 3:
                    return "3/16";
                case 4:
                    return "1/4";
                case 5:
                    return "5/16";
                case 6:
                    return "3/8";
                case 7:
                    return "7/16";
                case 8:
                    return "1/2";
                case 9:
                    return "9/16";
                case 10:
                    return "5/8";
                case 11:
                    return "11/16";
                case 12:
                    return "3/4";
                case 13:
                    return "13/16";
                case 14:
                    return "7/8";
                case 15:
                    return "15/16";
                default:
                    return "";
            }
        }

        public static double FractionToDouble(string sixteenth)
        {
            //String[] fraction = Sixteenth.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            //if (fraction.Length != 2)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            //Int32 numerator, denominator;
            //if (Int32.TryParse(fraction[0], out numerator) && Int32.TryParse(fraction[1], out denominator))
            //{
            //    if (denominator == 0)
            //    {
            //        throw new InvalidOperationException("Divide by 0 occurred");
            //    }
            //    return Convert.ToDouble(((float)numerator / denominator).ToString("N4"));
            //}
            //throw new ArgumentException();
            switch (sixteenth)
            {
                case "1/16":
                    return 1 / 16D;
                case "1/8":
                    return 0125D;
                case "3/16":
                    return 0.1875D;
                case "1/4":
                    return 0.25D;
                case "5/16":
                    return 0.3125D;
                case "3/8":
                    return 0.375D;
                case "7/16":
                    return 0.4375D;
                case "1/2":
                    return 0.5D;
                case "9/16":
                    return 0.5625D;
                case "5/8":
                    return 0.625D;
                case "11/16":
                    return 0.6875D;
                case "3/4":
                    return 0.75D;
                case "13/16":
                    return 0.8125D;
                case "7/8":
                    return 0.875D;
                case "15/16":
                    return 0.9375D;
                default:
                    return 0;
            }
        }


        private static string ConvertToFraction(double d)
        {
            var input = d.ToString(CultureInfo.CurrentCulture);
            var strings = input.Split('.');
            var x = strings[strings.Length - 1];
            var y = "1";

            for (var i = 0; i < x.Length; i++)
            {
                y += "0";
            }

            var gcf = GreatestCommonFraction(int.Parse(x), int.Parse(y));

            if (int.Parse(strings[0]) != 0)
                return strings[0] + " " + int.Parse(x) / gcf + "/" + int.Parse(y) / gcf;
            return int.Parse(x) / gcf + "/" + int.Parse(y) / gcf;
        }


        private static int GreatestCommonFraction(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            do
            {
                var z = x % y;
                if (z == 0)
                    return y;
                x = y;
                y = z;
            } while (true);
        }

        public double ParseDoubleFromString(string num)
        {
            //removes multiple spces between characters, cammas, and leading/trailing whitespace
            num = Regex.Replace(num.Replace(",", ""), @"\s+", " ").Trim();
            var whole = 0;
            const string seperator = "/";

            //is there a fraction?
            if (!num.Contains(seperator))
            {
                //parse the whole thing
                return double.Parse(num.Replace(" ", ""));
            }
            //is there a space?
            double numerator;
            double denominator;
            if (!num.Contains(" "))
            {
                //set the numerator and denominator
                numerator = double.Parse(num.Split(seperator.ToCharArray())[0]);
                denominator = double.Parse(num.Split(seperator.ToCharArray())[1]);
            }
            else
            {
                //seperate the integer and fraction
                var firstspace = num.IndexOf(" ", StringComparison.Ordinal);
                var fraction = num.Substring(firstspace, num.Length - firstspace);
                //set the integer
                whole = int.Parse(num.Substring(0, firstspace));
                //set the numerator and denominator
                numerator = double.Parse(fraction.Split(seperator.ToCharArray())[0]);
                denominator = double.Parse(fraction.Split(seperator.ToCharArray())[1]);
            }

            //is it a valid fraction?
            if (Math.Abs(denominator) > 0)
            {
                return whole + numerator / denominator;
            }
            return 0;
        }

        public double DoWork(string data)
        {
            double final = 0;

            foreach (var s in data.Split(' '))
            {
                if (s.Contains("/"))
                {
                    final += double.Parse(s.Split('/')[0]) / double.Parse(s.Split('/')[1]);
                }
                else
                {
                    double tryparse;
                    double.TryParse(s, out tryparse);
                    final += tryparse;
                }
            }

            return final;
        }
    }
}