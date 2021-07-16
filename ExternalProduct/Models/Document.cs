using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExternalProduct.Models
{
    public class Document
    {
        public string MimeType { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentURL { get; set; }
    }
}
