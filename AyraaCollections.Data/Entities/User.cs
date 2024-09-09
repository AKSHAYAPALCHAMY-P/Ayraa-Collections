using System;
using AyraaCollections.Common;

namespace AyraaCollections.Data
{
    public class User
    {
            public Guid nId { get; set; }
            public string strEmail { get; set; }
            public string strFirstName { get; set; }
            public string strLastName { get; set; }
            public string strPassword { get; set; }
            public string strConfirmPassword { get; set; }

            public User() { }

            public User(UserDTO user) 
            {
            nId = Guid.NewGuid();
            strEmail = user.strEmail;
            strFirstName = user.strFirstName;
            strLastName = user.strLastName;
            strPassword = user.strPassword;
            strConfirmPassword = user.strConfirmPassword;
            }
    }
}