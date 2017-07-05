using DAL.DBContext;
using DataAccessLayer.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.CRUD.User                          /*This class and methods are still under construction, JOINS must be added to retrieve from multile tables*/
{
    class SelectUser
    {

        public void RetrieveUser()
        {
            using (var _ObjUsersDbContext = new UsersDbContext())
            {
               // try
                //{   //Retrieving that Names
                    var users = from user in _ObjUsersDbContext.user
                                select user.LastName + " " + user.FirstName + " " + user.MiddleName + " " + user.FK_DepartmentId;
                    //LINQ query for selecting information about all the users
                    
      
            
          
               

                // var users = from user in _ObjUsersDbContext.user
                //select user.LastName + " " + user.FirstName + " " + user.MiddleName + " " + user.FK_DepartmentId;


                _User u = new _User();

                var query = (from user in _ObjUsersDbContext.user.DefaultIfEmpty(new _User())
                             join department in _ObjUsersDbContext.department on user.FK_DepartmentId equals department.PK_DepartmentId
                             join sex in _ObjUsersDbContext.gender on user.FK_GenderId equals sex.PK_GenderId
                             join types in _ObjUsersDbContext.userType on user.FK_UserTypeId equals types.UserTypeId
                             join physAddress in _ObjUsersDbContext.physicalAddress on user.PK_UserId equals physAddress.FK_UserId
                             join postAddress in _ObjUsersDbContext.postalAddress on user.PK_UserId equals postAddress.FK_UserId

                             select new

                             {
                                 user.PK_UserId,
                                 user.FirstName,
                                 user.MiddleName,
                                 user.LastName,
                                 department.DepartmentName,
                                 sex.GenderValue,
                                 types.UserTypeName,
                                 department.DepartmentDescription,
                                 physAddress.StreetLine1,
                                 physAddress.StreetLine2,
                                 physAddress.StreetLine3
                             });
                //Looping through the Names
                foreach (var user in query)
                    //{
                        Console.WriteLine("{0}", user);
                    //}

                    Console.ReadKey();
                    
                }
                //In case of any errors, it will be caught here
                //catch (Exception)
                //{

                //    Console.WriteLine("Unable to retrieve user(s)");
                //    Console.ReadKey();
                //}
            }

        }
    }

