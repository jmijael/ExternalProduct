using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;

namespace EF.Repository
{
    public class stbProductDetailEFRepository : IstbProductDetailRepository
    {
        ApplicationEFContext context;
        public stbProductDetailEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public IEnumerable<IstbProductDetailDTO> GetAll()
        {
            return context.stbProductDetails;
        }
    }
}
