using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IProductDocumentDTO
    {
       string Action { get; set; }
       string ExternalProductID { get; set; }
       string BusinessUnit { get; set; }
       string Culture { get; set; }
       string DocumentType { get; set; }
       string MIMEType { get; set; }
       string SourceDocumentURL { get; set; }
       string Brand { get; set; }
       string DocumentTitle { get; set; }
    }
}
