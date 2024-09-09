using System.Linq;
using AyraaCollections.Common;
using AyraaCollections.Data;

public class AuthenticationBL
{
    public bool Register(UserDTO dtoUser)
    {
        var ExistingUser = AyraaCollectionsContext.Users.Exists(u => u.Email == dtoUser.Email);

        if(ExistingUser) 
        {
            return false;
        }

        User user = new User(dtoUser);
        AyraaCollectionsContext.Users.Add(user);
        return true;
    }

    public UserDTO LogIn(string strEmail, string strPassword)
    {
        var user = AyraaCollectionsContext.Users.FirstOrDefault(u => u.Email == strEmail && u.Password == strPassword);

        if(user != null)
        {
            return user.GetUserDTO();
        }

        return null;
    }
}