using DependencyInversion_H2.DataReaders;
using System;

namespace DependencyInversion_H2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PART 1");
            WebReader webReader = new WebReader("https://docs.microsoft.com");
            Console.WriteLine(webReader.GetResponseUrl());
            Console.WriteLine();
            Console.WriteLine("Press any key to finish..");
            Console.ReadKey();
        }
    }
}
