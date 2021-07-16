using System;
using System.Collections.Generic;
using System.Text;
using BL.Interfaces;

namespace EF.Repository
{
    public class stbURLTypeEFRepository : IstbURLTypeRepository
    {
        ApplicationEFContext context;
        public stbURLTypeEFRepository(ApplicationEFContext context)
        {
            this.context = context;
        }

        public IEnumerable<IstbURLTypeDTO> GetAll()
        {
            return context.stbURLTypes;
        }
    }
}
