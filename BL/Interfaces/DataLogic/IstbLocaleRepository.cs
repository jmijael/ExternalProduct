using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
namespace BL.Interfaces
{
    public interface IstbLocaleRepository
    {
         IEnumerable<stbLocaleDTO> Get();
    }
}
