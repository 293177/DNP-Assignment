using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace DNP_API.Login
{
    public class User
    {
        [NotNull]
        [JsonPropertyName("username")]
        public string username { get; set; }
        [NotNull]
        [JsonPropertyName("password")]
        public string password { get; set; }
        [NotNull]
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}