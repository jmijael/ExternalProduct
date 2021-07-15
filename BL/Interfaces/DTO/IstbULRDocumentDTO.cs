using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbULRDocumentDTO
    {
        Int64 ProductDetailId { get; set; }
        Int64 URLTypeId { get; set; }
        string DocumentTitle { get; set; }
        string URL { get; set; }
        bool Verified { get; set; }
    }
}
