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
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Password { get; }
        
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            GetPasswordHash(password);
        }

        public User(string username, byte[] passwordSalt, byte[] passwordHash)
        {
            Username = username;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
        }

        public bool VerifyPassword(string text)
        {
            return Password == text;
        }

        private void GetPasswordHash(string password)
        {
            using(var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }            
        }

        
    }
}
