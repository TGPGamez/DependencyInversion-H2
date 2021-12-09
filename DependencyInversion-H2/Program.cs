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

            Console.WriteLine("PART 1");
            IDataRequest webRequest = new WebReader("https://docs.microsoft.com");
            Console.WriteLine(dataReader.Read(webRequest));
            Console.WriteLine();
            Console.WriteLine("Press any key to finish..");
            Console.ReadKey();
        }
    }
}
