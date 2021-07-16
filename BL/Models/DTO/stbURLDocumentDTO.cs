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
    [Table("stbULRDocument")]
    public class stbURLDocumentDTO : IstbURLDocumentDTO
    {
        [Key]
        public Int64 ProductDetailId { get; set; }
        public int URLTypeId { get; set; }
        public string DocumentTitle { get; set; }
        public string URL { get; set; }
        public bool Verified { get; set; }
    }
}
