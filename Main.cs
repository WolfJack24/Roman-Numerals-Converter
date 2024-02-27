using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Window.OpenWindow();
        }

        public static (string, string) RomanToNumber(string numerals)
        {
            int result = 0;
            string words = numerals;
            string originalWord = numerals;

            if (words.Contains("CM"))
            {
                result += 900;
                words = words.Replace("CM", "");
            }
            if (words.Contains("CD"))
            {
                result += 400;
                words = words.Replace("CD", "");
            }
            if (words.Contains("XC"))
            {
                result += 90;
                words = words.Replace("XC", "");
            }
            if (words.Contains("XL"))
            {
                result += 40;
                words = words.Replace("XL", "");
            }
            if (words.Contains("IX"))
            {
                result += 9;
                words = words.Replace("IX", "");
            }
            if (words.Contains("IV"))
            {
                result += 4;
                words = words.Replace("IV", "");
            }
            
            for (int i = 0; i < words.Length; i++)
            {
                switch (words[i])
                {
                    case 'I':
                        result += 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        result += 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        result += 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                }
            }

            return (Convert.ToString(result), originalWord);
        }
    }
}