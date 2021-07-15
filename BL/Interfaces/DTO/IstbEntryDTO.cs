using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbEntryDTO
    {
        Int64 LocaleId { get; set; }
        int ProductDetailId { get; set; }
        int ProductId { get; set; }
    }
}
