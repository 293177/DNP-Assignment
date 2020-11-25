using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using DNP_API.Model;
using DNP_API.Context;
namespace DNP_API.Login{
    public class UserDbService:IUser{
        private AdultContext ctx;
        public UserDbService(AdultContext context){
            ctx = context;
        }

        public async Task<User> AddUserAsync(User user)
        {
            EntityEntry<User> newUser = await ctx.users.AddAsync(user);
            await ctx.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task<IList<User>> getUsersAsync()
        {
            return await ctx.users.ToListAsync();
        }

        public async Task RemoveUserAsync(User toRemove)
        {
            User user = await ctx.users.FirstOrDefaultAsync(user => user.username == toRemove.username);
            if(user != null){
                ctx.users.Remove(user);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            List<User> users = ctx.users.Where(users => users.username.Equals(username) && users.password.Equals(password)).ToList();
            return users[0];
        }
    }
}