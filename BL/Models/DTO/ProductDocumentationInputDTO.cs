using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
namespace BL.Models
{
    public class ProductDocumentationInputDTO : IProductDocumentationInputDTO
    {
        public string PrimaryLocaleCode { get; set; }
        public string SecondaryLocaleCode { get; set; }
        public string BusinessUnit { get; set; }
        public string ExternalProductID { get; set; }
    }
}
