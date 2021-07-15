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
    [Table("stbURLType")]
    public class stbURLTypeDTO : IstbURLTypeDTO
    {
        [Key]
        public Int64 URLTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
