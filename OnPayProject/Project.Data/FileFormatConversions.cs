using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Project.Data
{
    public class FileFormatConversions
    {
        /// <summary>
        /// Convert a document from csv to a text document and save the file to the provided output location
        /// </summary>
        /// <param name="documentLocation"></param>
        /// <param name="outputFileLocation"></param>
        public static void ConvertCsvToText(string documentLocation, string outputFileLocation)
        {
            if(!File.Exists(outputFileLocation))
            {
                File.Create(outputFileLocation);
            }

            using(StreamReader reader = new StreamReader(documentLocation))
            {
                using(StreamWriter writer = new StreamWriter(outputFileLocation))
                {
                    string line = reader.ReadLine();
                    line = reader.ReadLine(); //bypass the first line which will contain header information for the payments
                    while(line != null)
                    {
                        string[] parameters = line.Split(',');
                        if(parameters.Length != 8)
                        {

                        }
                    }
                }
            }
        }
    }
}
