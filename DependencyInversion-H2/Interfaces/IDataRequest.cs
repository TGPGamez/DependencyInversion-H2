using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_H2.Interfaces
{
    public interface IDataRequest
    {
        /// <summary>
        /// Used to read data
        /// </summary>
        /// <returns></returns>
        string RequestData();
    }
}
