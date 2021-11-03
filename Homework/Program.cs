using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // #region task strings

            //    Console.WriteLine("Enter the string:");
            //    string text_word = Console.ReadLine();

            //    string[] word = text_word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        foreach (var item in word[i])
            //        {
            //            if (char.IsDigit(item))
            //            {
            //                word[i] = word[i].Replace(word[i], " ");
            //            }
            //        }

            //        if (i % 2 == 0)
            //        {
            //            word[i] = new string(word[i].Reverse().ToArray());
            //        }
            //    }

            //    for (int k = 0; k < word.Length; k++)
            //    {
            //        if (word[k].Length > 0)
            //        {
            //            word[k] = word[k].Substring(0, 1).ToUpper() + word[k].Substring(1, word[k].Length - 1).ToLower();
            //        }
            //    }

            //    Console.WriteLine("Result:");
            //    for (int j = 0; j < word.Length; j++)
            //    {
            //        Console.Write(word[j] + " ");
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Task 3:");
            //    string[] stroka = { "Port", "green", "placen" };

            //    for (int d = 0; d < stroka.Length; d++)
            //    {
            //        if (stroka[d].StartsWith("p", true, new System.Globalization.CultureInfo("en-US")))
            //        {
            //            stroka[d] = stroka[d].Replace("p", "S", true, new System.Globalization.CultureInfo("en-US"));
            //        }

            //        if (stroka[d].EndsWith("n", true, new System.Globalization.CultureInfo("en-US")))
            //        {
            //            stroka[d] = stroka[d].Replace("n", "O", true, new System.Globalization.CultureInfo("en-US"));
            //        }
            //    }

            //    for (int u = 0; u < stroka.Length; u++)
            //    {
            //        Console.WriteLine(stroka[u]);
            //    }
            //  #endregion
            #region task array

            Random random = new Random();
            Console.WriteLine("Enter count of element to fill array:");
            int array_len = int.Parse(Console.ReadLine());
            int[] array = new int[array_len];
            int?[] array1 = new int?[array_len];
            int?[] array2 = new int?[array_len];
            char[] ch1 = new char[array1.Length];
            char[] ch2 = new char[array2.Length];
            int chind1 = 0;
            int chind2 = 0;
            int index_arr = 0;
            int index_arr2 = 0;
            for (int i = 0; i < array_len; i++)
            {
                array[i] = random.Next(1, 26);
            }

            Console.WriteLine("Result array:");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > 0)
                {
                    if (array[j] % 2 == 0)
                    {
                        array1[index_arr++] = array[j];
                    }
                    else
                    {
                        array2[index_arr2++] = array[j];
                    }
                }
            }

            Console.WriteLine("array1");
            foreach (var items in array1)
            {
                Console.Write($"{items} ");
            }

            Console.WriteLine();
            Console.WriteLine("array2");
            foreach (var itemss in array2)
            {
                Console.Write($"{itemss} ");
            }

            Console.WriteLine();
            for (int k = 0; k < array1.Length - 1; k++)
            {
                if (array1[k] > 0)
                {
                    ch1[chind1++] = (char)(array1[k] + 97);
                }
            }

            for (int k = 0; k < array2.Length - 1; k++)
            {
                if (array2[k] > 0)
                {
                    ch2[chind2++] = (char)(array2[k] + 97);
                }
            }

            char[] chars = new char[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            int count = 0;
            int count_two = 0;
            Console.WriteLine("Arrays witn upper register:");
            for (int l = 0; l < ch1.Length; l++)
            {
                for (int p = 0; p < chars.Length; p++)
                {
                    if (ch1[l] == chars[p])
                    {
                        ch1[l] = char.ToUpper(ch1[l]);
                        count++;
                    }
                }
            }

            for (int x = 0; x < ch2.Length; x++)
            {
                for (int p = 0; p < chars.Length; p++)
                {
                    if (ch2[x] == chars[p])
                    {
                        ch2[x] = char.ToUpper(ch2[x]);
                        count_two++;
                    }
                }
            }


            for (int h = 0; h < ch1.Length; h++)
            {
                Console.Write($"{ch1[h]}  ");
            }

            Console.WriteLine();
            for (int n = 0; n < ch2.Length; n++)
            {
                Console.Write($"{ch2[n]}  ");
            }


            Console.WriteLine();
            Console.WriteLine(count > count_two ? "First has more upper register chars" :
                "Second has more upper register chars");

            #endregion
        }
    }
}
