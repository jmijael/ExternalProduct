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
        Int64 ProductDetailId { get; set; }
        Int64 ProductId { get; set; }
    }
}
