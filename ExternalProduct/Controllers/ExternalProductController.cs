using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BL.Models;
using BL.Interfaces;
using EF.Repository;

namespace ExternalProduct.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExternalProductController : ControllerBase
    {
        IstbLocaleRepository LocaleRepo;
        public ExternalProductController(IstbLocaleRepository LocaleRepo)
        {
            this.LocaleRepo = LocaleRepo;
        }

        //[HttpGet]
        //public IEnumerable<ExternalProduct> Get()
        //{
        //    ExcelReader.Library.ExcelReader er = new ExcelReader.Library.ExcelReader("C:\\Users\\Mijael\\Downloads\\ProdDocumentation\\DocLitImport_V5.0.xlsx", 1);
        //    return er.result;
        //}

        [HttpGet]
        public IEnumerable<stbLocaleDTO> Get()
        {
            return LocaleRepo.GetAll().Cast<stbLocaleDTO>();
        }

        //[HttpPost]
        //public IEnumerable<ExternalProduct> SendExternalProduct(ExternalProductDto value)
        //{
        //    ExcelReader.Library.ExcelReader er = new ExcelReader.Library.ExcelReader("C:\\Users\\Mijael\\Downloads\\ProdDocumentation\\DocLitImport_V5.0.xlsx", 1);
        //    return er.result;
        //}
    }
}
