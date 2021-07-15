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
    [Table("stbProduct")]
    public class stbProductDTO : IstbProductDTO
    {
        [Key]
        public Int64 ProductId { get; set; }
        public string ExternalProductId { get; set; }
        public string BusinessUnit { get; set; }
        public string Brand { get; set; }
    }
}
