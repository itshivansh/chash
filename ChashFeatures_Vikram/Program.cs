using ChashFeatures_Vikram.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ChashFeatures_Vikram
{
    class Program: IPrintable
    {
        static void Main(string[] args)
        {
            #region Interpolation Old
            int number = 300;
            Console.WriteLine("The Number is::{0}", number);//C# 2.0
            Console.WriteLine($"The Number is::{number}");//C# 6.0
            #endregion
            #region Interpolation
            //Console.WriteLine("Using features");
            //string filename = "Sample.txt";
            ////interpolation in C#
            ////$ C# 6.0
            ////$@ C# 7.0
            ////@$ C# 8.0
            //string filepath = $@"C:\Users\VikramH\source\repos\ChashFeatures_Vikram\ChashFeatures_Vikram\data\{filename}";
            //string someLine = string.Empty;
            #endregion
            #region using Option
            #region Old using Concept
            //using (StreamReader reader = new StreamReader(filepath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //

            #endregion
            //using StreamReader reader = new StreamReader(filepath);
            //string line;
            //while ((line = reader.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            #endregion
            #region Ranges
            List<int> listofNumbers = new List<int>() { 300, 200, 100, 40, 50, 400 };
            var firstNumber = listofNumbers[0];
            Console.WriteLine(firstNumber);
            var lastNumber = listofNumbers[^1];
            Console.WriteLine(lastNumber);
            var arrValues = listofNumbers.ToArray();

            var allValues = arrValues[..];

            var itemsfromSpecifiedIndex = arrValues[1..^1];
            Console.WriteLine(itemsfromSpecifiedIndex);

            itemsfromSpecifiedIndex = arrValues[1..3];
            Console.WriteLine(itemsfromSpecifiedIndex);
            ////Negetive Values
            // var negetiveValies = arrValues[-1];//Index was outside the bounds of the array.'
            //Console.WriteLine(negetiveValies);
            #endregion
            #region NullCoallasing operation C#
            int? nullValueToVariable = null;
            Console.WriteLine(nullValueToVariable ??= 0);//
            #endregion
            #region interface Implementation
            //Check models folder IPrintable interface
            #endregion
            Product product = new Product();
            product.Id = 101;
            Console.WriteLine(product);
            //Auto Property Initializer
            #region static Local Functions
            Console.WriteLine(Product.TotalPrice(400));
            #endregion
        }

        public void GeneratePrint()
        {
            Console.WriteLine("Generate Function");
        }
    }
}
