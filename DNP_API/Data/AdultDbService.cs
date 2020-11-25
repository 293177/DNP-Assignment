using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DNP_API.Model;
using DNP_API.Context;
namespace DNP_API.Data{
    public class AdultDbService: IAdultService{
        private AdultContext cxt;
        public AdultDbService(AdultContext adultContext){
            cxt = adultContext;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            EntityEntry<Adult> newAdult = await cxt.Adults.AddAsync(adult);
            await cxt.SaveChangesAsync();
            return newAdult.Entity;
        }

        public void EditAdult()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return await cxt.Adults.ToListAsync();
        }

        public async Task RemoveAdultAsync(Adult Radult)
        {
            Adult toRemove = await cxt.Adults.FirstOrDefaultAsync(r => r.Id == Radult.Id );
            if(toRemove != null){
                cxt.Adults.Remove(toRemove);
                await cxt.SaveChangesAsync();
            }
        }
    }
}