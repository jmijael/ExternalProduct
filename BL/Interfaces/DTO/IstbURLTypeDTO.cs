using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbURLTypeDTO
    {
        int URLTypeId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
