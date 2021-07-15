using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbProductDetailDTO
    {
        Int64 ProductDetailId { get; set; }
        string DocumentType { get; set; }
        bool Verified { get; set; }
    }
}
