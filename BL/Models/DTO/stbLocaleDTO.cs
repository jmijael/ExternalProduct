using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;

namespace BL.Models
{
    [Table("stbLocale")]
    public class stbLocaleDTO : IstbLocaleDTO
    {
        [Key]
        public Int64 LocaleId { get; set; }
        public string LocaleCode { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
}
