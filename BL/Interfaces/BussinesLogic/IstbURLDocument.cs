using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IstbURLDocument
    {
        int ProductDetailId { get; set; }
        int URLTypeId { get; set; }
        string DocumentTitle { get; set; }
        string URL { get; set; }
        bool Verified { get; set; }
    }
}
