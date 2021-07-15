using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;

namespace BL.Models
{
    public class stbEntry : IstbEntry
    {
        public int LocaleId { get; set; }
        public int ProductDetailId { get; set; }
        public int ProductId { get; set; }
    }
}
