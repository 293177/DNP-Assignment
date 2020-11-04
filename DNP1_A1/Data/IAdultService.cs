using System.Collections.Generic;
using DNP1_A1.Models;
using System;
using System.Threading.Tasks;
using System.Linq;
namespace DNP1_A1.Data
{
    public interface IAdultService
    {
       Task <IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adult);
       Task RemoveAdultAsync(Adult Radult);
       void EditAdult();
    }
}