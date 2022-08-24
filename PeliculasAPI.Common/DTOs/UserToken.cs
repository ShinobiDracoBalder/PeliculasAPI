using System;

namespace PeliculasAPI.Common.DTOs
{
    public class UserToken
    {
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
