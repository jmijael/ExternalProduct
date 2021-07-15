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
    [Table("stbProductDetail")]
    public class stbProductDetailDTO : IstbProductDetailDTO
    {
        [Key]
        public Int64 ProductDetailId { get; set; }
        public string DocumentType { get; set; }
        public bool Verified { get; set; }
    }
}
