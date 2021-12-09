
using DependencyInversion_Part_2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_Part_2.DataReaders
{
    public class FileReader : IDataRequest
    {
        public string Path { get; set; }

        public FileReader(string path = "")
        {
            Path = path;
        }

        public string RequestData()
        {
            return ReadFromFile();
        }

        /// <summary>
        /// Used to read from a file out from a path
        /// </summary>
        /// <returns>All file data as a string</returns>
        private string ReadFromFile()
        {
            try
            {
                //Opens file from path
                StreamReader sr = new StreamReader(Path);

                //Reads all the data from the file
                string data = sr.ReadToEnd();

                return data;
            }
            catch (Exception ex)
            {

                return $"ERROR, couldn't get response from {Path}\nError message: {ex.Message}";
            }
        }
    }
}
