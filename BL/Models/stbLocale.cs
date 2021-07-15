using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;

namespace BL.Models
{
    public class stbLocale : IstbLocale
    {
        public int LocaleId { get; set; }
        public string LocaleCode { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
}
