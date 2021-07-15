using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
namespace BL.Models
{
    public class stbProductDetail : IstbProductDetail
    {
        public int ProductDetailId { get; set; }
        public string DocumentType { get; set; }
        public bool Verified { get; set; }
    }
}
