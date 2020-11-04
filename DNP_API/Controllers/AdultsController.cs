using DNP_API.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using DNP_API.Model;
using System.Collections.Generic;
using System.Linq;
namespace DNP_API.Controllers{
    [Route ("[controller]")]
    [ApiController]
    public class AdultsController :ControllerBase{
        IAdultService adultService;

        public AdultsController(IAdultService adultService){
            this.adultService = adultService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdultAsync(){
            try{
                IList<Adult> adults = await adultService.GetAdultsAsync();
                return Ok(adults);
            }catch(Exception e){
                Console.WriteLine(e.Message);

                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{adult}")]
        [Route("{Adult: adult}")]
        public async Task<ActionResult> DeleteAdultAsync([FromRoute] Adult adult){
            try{
                await adultService.RemoveAdultAsync(adult);
                return Ok();
            }catch(Exception e){
                Console.WriteLine(e.Message);
                return StatusCode(204, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdultAsync([FromBody] Adult adult){
            try{
                Adult adult1 = await adultService.AddAdultAsync(adult);
                return Ok(adult1);
            }catch(Exception e){
                Console.WriteLine(e.Message);
                return StatusCode(409, e.Message);
            }
        }
    }
}