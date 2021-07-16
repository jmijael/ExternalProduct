using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
using ExternalProduct.Models;

namespace ExternalProduct.Service
{
    public class ProductDocumentationService : IProductDocumentationService
    {
        IstbProductRepository ProductRepo;
        IstbEntryRepository EntryRepo;
        IstbLocaleRepository LocaleRepo;
        IstbProductDetailRepository ProductDetRepo;
        IstbURLDocumentRepository URLDocRepo;
        IstbURLTypeRepository URLTypeRepo;
        public ProductDocumentationService(IstbProductRepository ProductRepo, IstbEntryRepository EntryRepo, IstbLocaleRepository LocaleRepo,
            IstbProductDetailRepository ProductDetRepo, IstbURLDocumentRepository URLDocRepo, IstbURLTypeRepository URLTypeRepo)
        {
            this.ProductRepo = ProductRepo;
            this.EntryRepo = EntryRepo;
            this.LocaleRepo = LocaleRepo;
            this.ProductDetRepo = ProductDetRepo;
            this.URLDocRepo = URLDocRepo;
            this.URLTypeRepo = URLTypeRepo;
        }
        public object GetResult(IProductDocumentationInputDTO input)
        {
            var product = ProductRepo.GetAll().FirstOrDefault(x => x.ExternalProductId == input.ExternalProductID && x.BusinessUnit == input.BusinessUnit);

            var queryDetails = from entry in EntryRepo.GetAll().ToList().Where(x => x.ProductId == product.ProductId)
                               join locale in LocaleRepo.GetAll().ToList() on entry.LocaleId equals locale.LocaleId
                               join productdetail in ProductDetRepo.GetAll().ToList() on entry.ProductDetailId equals productdetail.ProductDetailId
                               join urldocument in URLDocRepo.GetAll().ToList() on productdetail.ProductDetailId equals urldocument.ProductDetailId
                               join urltype in URLTypeRepo.GetAll().ToList() on urldocument.URLTypeId equals urltype.URLTypeId
                               where locale.LocaleCode == input.PrimaryLocaleCode || locale.LocaleCode == input.SecondaryLocaleCode
                               select new { LocaleCode = locale.LocaleCode, MimeType = urltype.Name, DocumentType = productdetail.DocumentType,
                                            DocumentTitle = urldocument.DocumentTitle, DocumentURL = urldocument.URL};
            List<LocaleDetail> detailList = new List<LocaleDetail>();
            LocaleDetail localePrimary = new LocaleDetail() { LocaleCode = input.PrimaryLocaleCode, 
                Documents = queryDetails.ToList().Where(x=>x.LocaleCode == input.PrimaryLocaleCode).Select(x=>new Document() {
                    MimeType = x.MimeType,
                    DocumentType = x.DocumentType,
                    DocumentTitle = x.DocumentTitle,
                    DocumentURL = x.DocumentURL
                }).ToList()};
            LocaleDetail localeSecondary = new LocaleDetail()
            {
                LocaleCode = input.SecondaryLocaleCode,
                Documents = queryDetails.ToList().Where(x => x.LocaleCode == input.SecondaryLocaleCode).Select(x => new Document()
                {
                    MimeType = x.MimeType,
                    DocumentType = x.DocumentType,
                    DocumentTitle = x.DocumentTitle,
                    DocumentURL = x.DocumentURL
                }).ToList()
            };

            var result = new ProductDocumentation();
            result.ProductID = product.ProductId;
            result.ExternalProductID = product.ExternalProductId;
            result.BusinessUnit = product.BusinessUnit;
            result.Brand = product.Brand;
            result.LocaleDetail = new List<LocaleDetail>();
            result.LocaleDetail.Add(localePrimary);
            result.LocaleDetail.Add(localeSecondary);

            return result;
        }
    }
}
