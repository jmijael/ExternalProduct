using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalProduct.Models
{
    public class LocaleDetail
    {
        public string LocaleCode { get; set; }
        public List<Document> Documents { get; set; }
    }
}
