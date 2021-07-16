using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;

namespace EF.Repository
{
    public class stbURLDocumentEFRepository : IstbURLDocumentRepository
    {
        ApplicationEFContext context;
        public stbURLDocumentEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }
        public IEnumerable<IstbURLDocumentDTO> GetAll()
        {
            return context.stbURLDocuments;
        }
    }
}
