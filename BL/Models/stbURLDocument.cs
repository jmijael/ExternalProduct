using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;

namespace BL.Models
{
    public class stbURLDocument : IstbULRDocument
    {
        public int ProductDetailId { get; set; }
        public int URLTypeId { get; set; }
        public string DocumentTitle { get; set; }
        public string URL { get; set; }
        public bool Verified { get; set; }
    }
}
