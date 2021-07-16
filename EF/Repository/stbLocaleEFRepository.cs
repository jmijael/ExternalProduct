using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;

namespace EF.Repository
{
    public class stbLocaleEFRepository : IstbLocaleRepository
    {
        ApplicationEFContext context;
        public stbLocaleEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public IEnumerable<IstbLocaleDTO> GetAll()
        {
            return context.stbLocales;
        }
    }
}
