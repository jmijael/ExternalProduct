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
    [Table("stbEntry")]
    public class stbEntryDTO : IstbEntryDTO
    {
        public Int64 LocaleId { get; set; }
        [Key]
        public Int64 ProductDetailId { get; set; }
        public Int64 ProductId { get; set; }
    }
}
