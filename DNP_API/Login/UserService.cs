using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DNP_API.Model;

namespace DNP_API.Login
{
    public class UserService : IUser
    {
        private List<User> users;
        HttpClient client = new HttpClient();
        private string userFile = "users.json";

        public UserService()
        {
            string content = File.ReadAllText(userFile);
            users = JsonSerializer.Deserialize<List<User>>(content);
        }
        private void writeUserFile(List<User> user)
        {
            string productAsJson = JsonSerializer.Serialize(user);
            File.WriteAllText(userFile, productAsJson);
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.username.Equals(username));
            if (first == null)
            {
                throw new Exception("user not found");
            }

            if (!first.password.Equals(password))
            {
                throw new Exception("Password is incorrect");
            }

            return first;
        }

        public async Task<User> AddUserAsync(User user)
        {
            users.Add(user);
            writeUserFile(users);
            return user;
        }

        public async Task<IList<User>> getUsersAsync()
        {
            return users;
        }

        public async Task RemoveUserAsync(User toRemove)
        {
            User toBeRemoved = users.First(t => t.username == toRemove.username);
            users.Remove(toRemove);
            writeUserFile(users);
        }
    }
}