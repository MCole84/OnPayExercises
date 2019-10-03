using Project.Data.Models;
using Project.Data.OutputModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                    //add new checkNumbers to dictionary each line read. Existing numbers add the invoice information to the appropriate item
                    Dictionary<int, Check> ChecksInFile = new Dictionary<int, Check>();
                    string line = reader.ReadLine();
                    if (line.StartsWith("Check"))
                    {
                        line = reader.ReadLine(); //the first line was headers for the csv file so skip over it
                    }
                    while(line != null)
                    {
                        string[] parameters = line.Split(',');
                        if(parameters.Length != 8)
                        {
                            int checkNumber = int.Parse(parameters[0]);
                            if(ChecksInFile.ContainsKey(checkNumber))
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
