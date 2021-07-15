using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbLocaleDTO
    {
        Int64 LocaleId { get; set; }
        string LocaleCode { get; set; }
        string Name { get; set; }
        bool Enabled { get; set; }
    }
}
