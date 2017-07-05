using DAL.DBContext;
using System;
using System.Linq;

namespace Operations.CRUD.User                          /*This class and methods are still under construction, JOINS must be added to retrieve from multile tables*/
{
    class SelectUser
    {

        public void RetrieveUser()
        {
            using (var _ObjUsersDbContext = new UsersDbContext())
            {
                try
                {   //Retrieving that Names
                    var users = from user in _ObjUsersDbContext.User
                                select user.LastName + " " + user.FirstName + " " + user.MiddleName + " " + user.FkDepartmentId;

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
