using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;

namespace EF.Repository
{
    public class stbProductEFRepository : IstbProductRepository
    {
        ApplicationEFContext context;
        public stbProductEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public IEnumerable<IstbProductDTO> GetAll()
        {
            return context.stbProducts;
        }
    }
}
