using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;
using BL.Models;

namespace EF.Repository
{
    public class stbLocaleEFRepository : IstbLocaleRepository
    {
        ApplicationEFContext context;
        public stbLocaleEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public IEnumerable<stbLocaleDTO> Get()
        {
            var result = context.stbLocales;
            return result;
        }
    }
}
