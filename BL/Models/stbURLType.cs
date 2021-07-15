using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;

namespace BL.Models
{
    public class stbURLType : IstbURLType
    {
        public int URLTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
