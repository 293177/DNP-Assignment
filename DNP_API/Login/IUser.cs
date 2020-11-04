﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DNP_API.Login;

 namespace DNP_API.Login
{
    public interface IUser
    {
        Task<User> ValidateUser(string username, string password);
        Task  AddUserAsync(string username, string password, string role);
        Task <IList<User>> getUsersAsync();
        Task RemoveUserAsync(User toRemove);
    }
}