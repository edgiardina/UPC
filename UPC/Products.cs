using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UPC
{
    [DataContract]
    public class Products
    {
        public Product Product { get; set; }
    }
}
