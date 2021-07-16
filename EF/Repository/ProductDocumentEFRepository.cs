using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace EF.Repository
{
    public class ProductDocumentEFRepository : IProductDocumentRepository
    {
        ApplicationEFContext context;
        public ProductDocumentEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public bool Save(IProductDocumentDTO input)
        {
            var param = new SqlParameter[] {
                new SqlParameter(){ ParameterName = "@Action", Value = input.Action},
                new SqlParameter(){ ParameterName = "@ExternalProductID", Value = input.ExternalProductID},
                new SqlParameter(){ ParameterName = "@BusinessUnit", Value = input.BusinessUnit},
                new SqlParameter(){ ParameterName = "@Culture", Value = input.Culture},
                new SqlParameter(){ ParameterName = "@DocumentType", Value = input.DocumentType},
                new SqlParameter(){ ParameterName = "@MIMEType", Value = input.MIMEType},
                new SqlParameter(){ ParameterName = "@SourceDocumentURL", Value = input.SourceDocumentURL},
                new SqlParameter(){ ParameterName = "@Brand", Value = input.Brand},
                new SqlParameter(){ ParameterName = "@DocumentTitle", Value = input.DocumentTitle}
            };
            var result =  context.Database.ExecuteSqlRaw("sp_Name @Action, @ExternalProductID, @BusinessUnit, @Culture, @DocumentType, @MIMEType, @SourceDocumentURL, @Brand, @DocumentTitle", param);
            return result > 0;
        }
    }
}
