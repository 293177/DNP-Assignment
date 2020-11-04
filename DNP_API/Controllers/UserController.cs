using DNP_API.Login;
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
    public class UserController:ControllerBase{
        IUser userService;
        public UserController(IUser userService){
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            try{
                User user = await userService.ValidateUser(username, password);
                return Ok(user);
            }catch(Exception e){
                Console.WriteLine(e.Message);
                StatusCode(404, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<User>>> GetUsersAsync(){
            try{
                IList<User> users = await userService.getUsersAsync();
                return Ok(users);
            }catch(Exception e){
                Console.WriteLine(e.Message);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddUserAsync([FromBody] string username, string password, string role){
            if(!ModelState.IsValid){
                return BadRequest();
            }
            try{
                 await userService.AddUserAsync(username,password,role);
                return Ok();
            }catch(Exception e){
                Console.WriteLine(e.Message);
                StatusCode(409, e.Message);
            }
        }
        [HttpDelete ("{toRemove}")]
        [Route("{User : toRemove}")]
        public async Task<ActionResult<User>> DeleteUserAsync([FromRoute] User toRemove){
            try{
                await userService.RemoveUserAsync(toRemove);
                return Ok();
            }catch(Exception e){
                Console.WriteLine(e.Message);
                StatusCode(204, e.Message);
            }
            return toRemove;
        }
    }


}