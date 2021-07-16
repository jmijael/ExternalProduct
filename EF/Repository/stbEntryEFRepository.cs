using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;

namespace EF.Repository
{
    public class stbEntryEFRepository : IstbEntryRepository
    {
        ApplicationEFContext context;
        public stbEntryEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public IEnumerable<IstbEntryDTO> GetAll()
        {
            return context.stbEntrys;
        }
    }
}
