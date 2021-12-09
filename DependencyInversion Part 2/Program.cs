using DependencyInversion_Part_2.DataReaders;
using DependencyInversion_Part_2.Interfaces;
using System;

namespace DependencyInversion_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader dataReader = new DataReader();

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
