using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.Common;
using CsvHelper;
using UPC.UPCSearchService;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace UPC
{
    class Program
    {
     
        static void Main(string[] args)
        {
            var lookup = new UpcProductLookup();

            Console.WriteLine("Polling keyboard for barcode values... press enter to finish.");
            var products = lookup.PollKeyboardForBarcodes();
            Console.WriteLine("{0} products found.", products.Count);

            Console.WriteLine("Enter the path and file to save CSV data about the products");
            var path = Console.ReadLine();

            using (var textWriter = File.CreateText(path))
            {
                var csv = new CsvWriter(textWriter);
                csv.WriteRecords(products);
            }

            Console.WriteLine("File written to {0}", path);
        }
    }
}
