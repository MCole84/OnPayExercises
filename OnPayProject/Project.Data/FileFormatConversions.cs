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
            using(StreamReader reader = new StreamReader(documentLocation))
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
                        if(parameters.Length == 8)
                        {
                            int checkNumber = int.Parse(parameters[0]);
                            if(ChecksInFile.ContainsKey(checkNumber))
                            {
                                ChecksInFile[checkNumber].InvoiceNumbers.Add(parameters[5]);
                                ChecksInFile[checkNumber].InvoiceDate.Add(DateTime.Parse(parameters[6]));
                                ChecksInFile[checkNumber].InvoiceAmounts.Add(Decimal.Parse(parameters[7]));
                            }
                            else
                            {
                                ChecksInFile.Add(checkNumber, new Check()
                                {
                                    CheckNumber = parameters[0],
                                    CheckDate = DateTime.Parse(parameters[1]),
                                    CheckAmount = Decimal.Parse(parameters[2]),
                                    VendorNumber = int.Parse(parameters[3]),
                                    VendorAddress = parameters[4],
                                    InvoiceNumbers = new List<string>() { parameters[5] },
                                    InvoiceDate = new List<DateTime>() { DateTime.Parse(parameters[6]) },
                                    InvoiceAmounts= new List<Decimal>() { Decimal.Parse(parameters[7])}
                                });

                            }
                        }
                        else
                        {
                            throw new InvalidDataException("The data was not in the proper format");
                        }
                    }
                CreateTextFileFromChecks(outputFileLocation, ChecksInFile);
                }
        }

        private static void CreateTextFileFromChecks(string outputFileLocation, IDictionary<int,Check> checks)
        {
            if (!File.Exists(outputFileLocation))
            {
                File.Create(outputFileLocation);
            }

            using(StreamWriter writer = new StreamWriter(outputFileLocation))
            {
                foreach(Check c in checks.Values)
                {
                    writer.WriteLine(c.CheckNumber);
                    writer.WriteLine(c.CheckDate);
                    writer.WriteLine(c.CheckAmount);
                    writer.WriteLine(c.VendorNumber);
                    writer.WriteLine(c.VendorAddress);
                    for(int i = 0; i < 95; i++)
                    {
                        if(i < c.InvoiceNumbers.Count)
                        {
                            writer.WriteLine($"{c.InvoiceNumbers[i],30} {c.InvoiceDate[i].ToString("MM/dd/yyyy")} {c.InvoiceAmounts[i]:C}");
                        }
                    }
                }
            }
        }

    }
}
