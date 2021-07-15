using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbProductDTO
    {
        Int64 ProductId { get; set; }
        string ExternalProductId { get; set; }
        string BusinessUnit { get; set; }
        string Brand { get; set; }
    }
}
