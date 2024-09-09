using System;
using System.Configuration;
using AyraaCollections.Common;

namespace AyraaCollections.Data
{
    public class User
    {
            public Guid Id { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }

            public User() { }

        public User(UserDTO user)
        {
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Password = user.Password;
        }

        public UserDTO GetUserDTO()
        {
            return new UserDTO()
            {
                Email = this.Email,
                FirstName = this.FirstName,
                LastName = this.LastName
            };
        }
    }
}