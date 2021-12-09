using DependencyInversion_H2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_H2.DataReaders
{
    public class WebReader : IDataRequest
    {
        public string Url { get; set; }

        public WebReader(string url)
        {
            Url = url;
        }

        public string RequestData()
        {
            return GetResponseUrl();
        }

        /// <summary>
        /// USed to get data from a website out from the Url
        /// </summary>
        /// <returns>All the website data as a string</returns>
        private string GetResponseUrl()
        {
            try
            {
                //Makes a web request to Url
                WebRequest webRequest = WebRequest.Create(Url);

                //Sets default credentials
                webRequest.Credentials = CredentialCache.DefaultCredentials;

                //Gets the response from request
                WebResponse webResponse = webRequest.GetResponse();

                string responseText = "";

                //Reads the data using a Stream
                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    responseText = sr.ReadToEnd();
                }

                //Close the response
                webResponse.Close();

                return responseText;
            }
            catch (Exception ex)
            {
                return $"ERROR, couldn't get response from {Url}\nError message: {ex.Message}";
            }
        }
    }
}
