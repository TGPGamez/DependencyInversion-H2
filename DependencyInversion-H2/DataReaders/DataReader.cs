using DependencyInversion_H2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_H2.DataReaders
{
    /// <summary>
    /// This class is used to "combine" multiple data sources (from a website or file) using the IDataRequest (interface)
    /// </summary>
    public class DataReader
    {
        /// <summary>
        /// Used to read data from a request
        /// </summary>
        /// <param name="dataRequest"></param>
        /// <returns>All the data as a string</returns>
        public string Read(IDataRequest dataRequest)
        {
            return dataRequest.RequestData();
        }
    }
}
