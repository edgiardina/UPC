using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace UPC
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "productname")]
        public string ProductName { get; set; }

        [DataMember(Name = "imageurl")]
        public string Imageurl { get; set; }

        [DataMember(Name = "producturl")]
        public string ProductUrl { get; set; }

        [DataMember(Name = "price")]
        public string Price { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "saleprice")]
        public string SalePrice { get; set; }

        [DataMember(Name = "storename")]
        public string Storename { get; set; }
    }
}
