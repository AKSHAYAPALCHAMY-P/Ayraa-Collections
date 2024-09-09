using System;

namespace AyraaCollections.Common
{

    public class UserDTO
    {
        public Guid nId { get; set; }
        public string strEmail { get; set; }
        public string strFirstName {  get; set; }
        public string strLastName { get; set; }
        public string strPassword {  get; set; }
        public string strConfirmPassword {  get; set; }

        public UserDTO(UserType userType) { }
     
    }

}


