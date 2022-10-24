using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login_IT4B
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool VerifyPassword(string text)
        {
            return Password == text;
        }

        private byte[] GetPasswordHash(string password)
        {
            byte[] passwordSalt;
            byte[] passwordHash;
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            return passwordHash;
        }

        
    }
}
