using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
namespace BL.Models
{
    public class stbProduct : IstbProduct
    {
        public int ProductId { get; set; }
        public string ExternalProductId { get; set; }
        public string BusinessUnit { get; set; }
        public string Brand { get; set; }
    }
}
