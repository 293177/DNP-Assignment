using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Text.Json;
using System.Text;
using DNP_API.Model;

namespace DNP_API.Data{
    public class CloudAdultService : IAdultService{
        private readonly string url = "http://dnp.metamate.me";
        private readonly HttpClient client = new HttpClient();

    
        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            string stringToJson = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(stringToJson,Encoding.UTF8,"application/json");
            HttpResponseMessage responseMessage = await client.PutAsync(url +"/adults",content);
            Console.WriteLine(responseMessage.ToString());
            return adult;
        }

        public void EditAdult()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            string s = await client.GetStringAsync(url+"/adults");
            IList<Adult> result = JsonSerializer.Deserialize<List<Adult>>(s);
            return result;
        }

        public async Task RemoveAdultAsync(Adult Radult)
        {
            HttpResponseMessage responseMessage = await client.DeleteAsync(url+$"/adults?id={Radult.Id}");
            Console.WriteLine(responseMessage.ToString());
        }
    }
}