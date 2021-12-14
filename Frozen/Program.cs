using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    internal class Program
    {
        class Frozen
        {
            string name;
            string wish;
            public Frozen(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }
            // getters for Frozen
            public string Title
            {
                get { return name; }
            }
            public string Wish
            {
                get { return wish; }
            }
        }
        static void Main(string[] args)
        {   //Anna wants new earings for Christmas

           List<Frozen> myFrozen = new List<Frozen>();
            string[] itemsFromFile = GetDataFromFile();
            foreach(string line in itemsFromFile)
            {
                string[] tempArray = line.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"{tempArray[0]} wants {tempArray[1]} for Christmas" );
                Console.WriteLine();
            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string [] GetDataFromFile()
        {
            string filePath = @"C:\Users\User\source\repos\Week15-programming\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
    }
}
