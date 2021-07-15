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
        [Key]
        public Int64 LocaleId { get; set; }
        public int ProductDetailId { get; set; }
        public int ProductId { get; set; }
    }
}
