using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Linq;

namespace Operations.CRUD.User                       //" CLASS UNDER CONSTRUCTION"
{
    class SelectUser : _User
    {
        public void RetrieveUser()
        {
            var objUsersDbContext = new UsersDbContext();

            // var users = from user in _ObjUsersDbContext.user
            //select user.LastName + " " + user.FirstName + " " + user.MiddleName + " " + user.FK_DepartmentId;


            _User u = new _User();

            var querySUdc = (from user in objUsersDbContext.User
                             select new { FirstName = user.FirstName });

            var querySUd = (from userd in objUsersDbContext.Department
                            select new
                            {
                                DepartmentName = userd.DepartmentName
                            });


            var querySUc = (from user in objUsersDbContext.User  //.DefaultIfEmpty(new _User())
                            join department in objUsersDbContext.Department
                            on user.FkDepartmentId equals department.PkDepartmentId
                            select new

                            {
                                PK_UserId = user.PkUserId,
                                FirstName = user.FirstName,
                                MiddleName = user.MiddleName,
                                LastName = user.LastName,
                                DepartmentName = department.DepartmentName,
                                //sex.GenderValue,
                                // types.UserTypeName,
                                //department.DepartmentDescription,
                                //physAddress.StreetLine1,
                                //physAddress.StreetLine2,
                                //physAddress.StreetLine3
                            }).ToList();

            querySUdc.ToList();
            querySUd.FirstOrDefault(x => x.DepartmentName == "GMIC");
            var query = (from user in objUsersDbContext.User  //.DefaultIfEmpty(new _User())
                         join department in objUsersDbContext.Department on user.FkDepartmentId equals department.PkDepartmentId
                         //join sex in _ObjUsersDbContext.gender on user.FK_GenderId equals sex.PK_GenderId
                         // join types in _ObjUsersDbContext.userType on user.FK_UserTypeId equals types.UserTypeId
                         // join physAddress in _ObjUsersDbContext.physicalAddress on user.PK_UserId equals physAddress.FK_UserId
                         // join postAddress in _ObjUsersDbContext.postalAddress on user.PK_UserId equals postAddress.FK_UserId

                         select new

                         {
                             PK_UserId = user.PkUserId,
                             FirstName = user.FirstName,
                             MiddleName = user.MiddleName,
                             LastName = user.LastName,
                             DepartmentName = department.DepartmentName,
                             //sex.GenderValue,
                             // types.UserTypeName,
                             //department.DepartmentDescription,
                             //physAddress.StreetLine1,
                             //physAddress.StreetLine2,
                             //physAddress.StreetLine3
                         });

            //foreach(var results in query)
            foreach (var resuls in query)
            {
                Console.WriteLine("{0}, {1}, {2},{3},{4}", resuls.PK_UserId, resuls.FirstName, resuls.MiddleName, resuls.LastName, resuls.DepartmentName);
                //, resuls.StreetLine1, resuls.StreetLine2, resuls.StreetLine3,resuls.DepartmentName);
                //,resuls.UserTypeName,resuls.DepartmentName,resuls.DepartmentDescription,resuls.StreetLine1
                //,resuls.StreetLine2,resuls.StreetLine3);
                //,{ 4},{ 5},{ 6},{ 7},{ 8},{ 9},{ 10},{ 11}
            }


            //var urs= _ObjUsersDbContext.user.ToList();//FirstOrDefault(x=> x.PK_UserId==u.PK_UserId);
            //Console.WriteLine(results.LastName,results.FirstName,results.MiddleName,results.PK_UserId);
            Console.ReadKey();
            // }
            //Console.ReadLine();





        }

    }


}


