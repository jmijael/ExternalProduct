using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReader.Library
{
    public class ExternalProduct
    {
        public string Action { get; set; }
        public string ExternalProductID { get; set; }
        public string BusinessUnit { get; set; }
        public string Culture { get; set; }
        public string DocumentType { get; set; }
        public string MIMEType { get; set; }
        public string SourceDocumentURL { get; set; }
        public string Brand { get; set; }
        public string DocumentTitle { get; set; }
    }
}
