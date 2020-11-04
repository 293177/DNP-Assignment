using System.Collections.Generic;
using DNP_API.Model;
using System;
using System.Threading.Tasks;
using System.Linq;
namespace DNP_API.Data
{
    public interface IAdultService
    {
       Task <IList<Adult>> GetAdultsAsync();
        Task<Adult> AddAdultAsync(Adult adult);
       Task RemoveAdultAsync(Adult Radult);
       void EditAdult();
    }
}