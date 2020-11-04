using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DNP_API.Model;

namespace DNP_API.Data
{
    public class AdultService : IAdultService
    {
        private string adultFile = "adults.json";
        public IList<Adult> adults { get; set; }

        public AdultService()
        {
            string content = File.ReadAllText(adultFile);
            adults = JsonSerializer.Deserialize<IList<Adult>>(content);
        }

        private void WriteToFile()
        {
            string productAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, productAsJson);
        }


        public void EditAdult()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
           return adults;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            adults.Add(adult);
             WriteToFile();
            return adult;
        }

        public async Task RemoveAdultAsync(Adult Radult)
        {
            Adult toRemove1 = adults.First(t => t.Id == Radult.Id);
            adults.Remove(Radult);
            WriteToFile();
        }
    }
}