using System;
using System.Linq;
using System.Text;

namespace P13307092022ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //int[] asd = FindCharIndexes("Salam", 'a');

            //foreach (int item in asd)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Hazir Methodlar

            //Console.WriteLine("Daxil Et");
            //string str = Console.ReadLine();
            //bool check = int.TryParse(str, out int result);
            //int result1;
            //int.TryParse(str, out result1);

            //Console.WriteLine(result);
            //Console.WriteLine(check);


            //int result2;
            //while (!int.TryParse(str, out result2))
            //{
            //    Console.WriteLine("Duzgun Daxil:");
            //    str = Console.ReadLine();
            //}

            //Console.WriteLine(result2);

            //char symbol = str[0];
            //while (!char.IsLetter(symbol))
            //{
            //    Console.WriteLine("Duzgun Daxil:");
            //    str = Console.ReadLine();
            //    symbol = str[0];
            //}

            int[] arr = { 5, 10, 15,16, 3,15,17,15,6 ,'@'};

            //int max = arr.Max();
            //Console.WriteLine(max);
            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Average());
            //Console.WriteLine(arr);

            //Array.Clear(arr, 2, 2);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int index = Array.IndexOf(arr,15, Array.IndexOf(arr,15,Array.IndexOf(arr,15)+1)+1);
            //Console.WriteLine(index);

            //Console.WriteLine(Array.LastIndexOf(arr, 15,Array.LastIndexOf(arr,15)-1));

            //Array.Reverse(arr);

            //Array.Sort(arr);
            //Array.Reverse(arr,3,3);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "    Hello World P133     ";

            //Console.WriteLine(String.Join('-', "P133", "Hello", "Wold"));

            //string subStr = word.Substring(2);
            //Console.WriteLine(subStr.Contains("Wor"));
            //Console.WriteLine(subStr.EndsWith("rd"));
            //Console.WriteLine(subStr.StartsWith("llo"));
            //Console.WriteLine(subStr.IndexOf('l'));
            //Console.WriteLine(subStr.LastIndexOf('l'));
            //char[] charArr = new char[] { 'a', 'b' };

            //Console.WriteLine(subStr.IndexOfAny(charArr));
            //Console.WriteLine(subStr.IndexOfAny(new char[] { 'a', 'b' }));
            //subStr = subStr.Replace('o', 'a');
            //Console.WriteLine(subStr);
            //Console.WriteLine(subStr.Replace("llo","Hello"));
            //string[] strArr = subStr.Split("Warld");

            //foreach (string item in strArr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(subStr.ToUpper());
            //Console.WriteLine(subStr.ToLower());

            //Console.WriteLine(word.Length);
            ////word = word.Trim();
            ////word = word.TrimEnd();
            //word = word.TrimStart();
            //Console.WriteLine(word.Length);

            //int a = 5;
            //a.ToString();
            //word += a;
            #endregion

            #region Task 2
            Console.WriteLine(JoinArray(arr));
            //Console.WriteLine();
            #endregion
        }

        #region Task 1
        //isdifadeci string ve char daxil edir. Daxil Edilen char stringin
        //hansi indexlerinde varsa o indexleri array seklinde geri qaytaran
        //method yazirsiniz. Eger Hec bir indexde yoxdursa sifir uzunluqlu
        //array geri qayitsin. FindCharIndex(string str, char symbol)
        //Misal: Salam a, {1,3} {}

        static int[] FindCharIndexes(string str, char symbol)
        {
            int[] arr = { };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }

            return arr;
        }
        #endregion

        #region Task 2
        //Reqemlerden Ibaret Arrayi vergulnen birlesdirib string seklinde geri qaytaran Method YAZINNNNN
        //Misal int[] arr = { 5, 7, 8 } --> 5,7,8
        static string JoinArray(int[] arr)
        {
            StringBuilder result = new StringBuilder();

            foreach (int item in arr)
            {
                result.Append(item);

                if (item != arr[arr.Length - 1])
                {
                    result.Append(',');
                }
            }

            return result.ToString();

            #region Old Version
            //string str = "";

            //foreach (int item in arr)
            //{
            //    str += item;

            //    if (item != arr[arr.Length-1])
            //    {
            //        str += ",";
            //    }
            //}

            //return str;
            #endregion
        }
        #endregion
    }
}
