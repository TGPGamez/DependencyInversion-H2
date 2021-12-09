using DependencyInversion_H2.DataReaders;
using DependencyInversion_H2.Interfaces;
using System;

namespace DependencyInversion_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader dataReader = new DataReader();

            //Part 1
            Console.WriteLine("PART 1");
            IDataRequest webRequest = new WebReader("https://docs.microsoft.com");
            Console.WriteLine(dataReader.Read(webRequest));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

            Console.Clear();

            //Part 2
            Console.WriteLine("PART 2");
            IDataRequest webRequest2 = new WebReader("https://docs.microsoft.com");
            IDataRequest fileRequest = new FileReader("TextFile.txt");
            Console.WriteLine(dataReader.Read(webRequest2));
            Console.WriteLine(dataReader.Read(fileRequest));
            Console.WriteLine();
            Console.WriteLine("Press any key to finish..");
            Console.ReadKey();
        }
    }
}
