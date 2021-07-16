using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExternalProduct.Models;
using BL.Models;

namespace ExternalProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductDocumentationController
    {
        IProductDocumentationService pdService;
        public ProductDocumentationController(IProductDocumentationService pdService)
        {
            this.pdService = pdService;
        }
        [HttpGet]
        public ProductDocumentation GetResult()
        {
            ProductDocumentationInputDTO input = new ProductDocumentationInputDTO();
            input.PrimaryLocaleCode = "fr-FR";
            input.SecondaryLocaleCode = "en-US";
            input.BusinessUnit = "CTL";
            input.ExternalProductID = "MS-DIS1710-0";
            return (ProductDocumentation)pdService.GetResult(input);
        }
    }
}
