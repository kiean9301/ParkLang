using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkLang.AppData;

namespace ParkLang
{
    public enum ErrorCode
    {
        Error,
        Success
    }
    public class UserRepository
    {
        public ErrorCode Register(String username, String password, String firstname, String lastname)
        {
            try
            {
                using (var db = new dbParkingSystemEntities())
                {
                    var newUser = new User();
                    newUser.username = username;
                    newUser.password = password;
                    newUser.firstname = firstname;
                    newUser.lastname = lastname;
                    
                    db.User.Equals(newUser);
                    db.SaveChanges();
                }
                    return ErrorCode.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
                return ErrorCode.Success;
            }
        }
           
    }
}
