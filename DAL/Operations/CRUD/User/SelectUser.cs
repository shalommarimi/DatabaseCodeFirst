using DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.CRUD.User
{
    class SelectUser
    {

        public void RetrieveUser()
        {
            using (var _ObjUsersDbContext = new UsersDbContext())
            {
                try
                {   //Retrieving that Names
                    var users = from user in _ObjUsersDbContext.user
                                select user.LastName + " " + user.FirstName + " " + user.MiddleName + " " + user.FK_DepartmentId;

                    //Looping through the Names
                    foreach (string user in users)
                    {
                        Console.WriteLine("{0}", user);
                    }

                    Console.ReadKey();
                    
                }
                //In case of any errors, it will be caught here
                catch (Exception)
                {

                    Console.WriteLine("Unable to retrieve user(s)");
                    Console.ReadKey();
                }
            }

        }
    }
}
