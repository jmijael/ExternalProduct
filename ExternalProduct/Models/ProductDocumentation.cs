using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Models;
namespace ExternalProduct.Models
{
    public class ProductDocumentation
    {
        public Int64 ProductID { get; set; }
        public string ExternalProductID { get; set; }
        public string BusinessUnit { get; set; }
        public string Brand { get; set; }
        public List<LocaleDetail> LocaleDetail { get; set; }

    }
}
