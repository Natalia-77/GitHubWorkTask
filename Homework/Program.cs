using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string text_word = Console.ReadLine();

            string[] word = text_word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < word.Length; i++)
            {
                foreach (var item in word[i])
                {
                    if (char.IsDigit(item))
                    {
                        word[i] = word[i].Replace(word[i], " ");
                    }
                }

                if (i % 2 == 0)
                {
                    word[i] = new string(word[i].Reverse().ToArray());
                }
            }

            for (int k = 0; k < word.Length; k++)
            {
                if (word[k].Length > 0)
                {
                    word[k] = word[k].Substring(0, 1).ToUpper() + word[k].Substring(1, word[k].Length - 1).ToLower();
                }
            }

            Console.WriteLine("Result:");
            for (int j = 0; j < word.Length; j++)
            {
                Console.Write(word[j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Task 3:");
            string[] stroka = { "Port", "green", "placen" };

            for (int d = 0; d < stroka.Length; d++)
            {
                if (stroka[d].StartsWith("p", true, new System.Globalization.CultureInfo("en-US")))
                {
                    stroka[d] = stroka[d].Replace("p", "S", true, new System.Globalization.CultureInfo("en-US"));
                }

                if (stroka[d].EndsWith("n", true, new System.Globalization.CultureInfo("en-US")))
                {
                    stroka[d] = stroka[d].Replace("n", "O", true, new System.Globalization.CultureInfo("en-US"));
                }
            }

            for (int u = 0; u < stroka.Length; u++)
            {
                Console.WriteLine(stroka[u]);
            }
        }
    }
}
