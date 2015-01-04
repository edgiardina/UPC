using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UPC.UPCSearchService;

namespace UPC
{
    public class UpcProductLookup
    {
        private static string ApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["SearchUpcApiKey"];
            }
        }

        private readonly UPCSearchSoapClient upcService = new UPCSearchSoapClient();

        public List<Product> PollKeyboardForBarcodes()
        {
            string barcode = "";
            var productsFound = new List<Product>();

            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.Enter)
                {
                    if (barcode == string.Empty)
                        return productsFound;

                    Console.WriteLine("Looking up barcode {0}", barcode);
                   
                    try
                    {
                        var product = GetProductFromBarcode(barcode);
                        productsFound.Add(product);
                        Console.WriteLine("Found Product '{0}'", product.ProductName);
                    }
                    catch(InvalidUpcException)
                    {
                        Console.WriteLine("Barcode is invalid.");
                    }
                
                    barcode = string.Empty;
                }
                else
                {
                    barcode += input.KeyChar;
                }
            }
        }

        public Product GetProductFromBarcode(string barcode)
        {
            //var isValid = bool.Parse(upcService.Validate(barcode, ApiKey));

            //if (isValid)
            //{
                var jsonResult = upcService.GetProductJSON(barcode, ApiKey);
                JObject deserializedProducts = JObject.Parse(jsonResult);
                var obj = deserializedProducts["0"].ToObject<Product>();
                return obj;
            //}
            //else
            //{
            //    //"The UPC string provided is not valid."
            //    throw new InvalidUpcException();
            //}
        }
    }
}
