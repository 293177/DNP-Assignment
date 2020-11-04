﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_API.Login;

 namespace DNP_API.Login
{
    public interface IUser
    {
        Task<User> ValidateUser(string username, string password);
        Task<User>  AddUserAsync(User user);
        Task <IList<User>> getUsersAsync();
        Task RemoveUserAsync(User toRemove);
    }
}