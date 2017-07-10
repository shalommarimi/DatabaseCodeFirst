using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Linq;

namespace Operations.CRUD.User                      
{
    class SelectUser : _User
    {
        public void RetrieveUser()
        {
            var objUsersDbContext = new UsersDbContext();

            _User u = new _User();

            var query = (from user in objUsersDbContext.User  //.DefaultIfEmpty(new _User())
                         join department in objUsersDbContext.Department on user.FkDepartmentId equals department.PkDepartmentId
                         join gender in objUsersDbContext.Gender on user.FkGenderId equals gender.PkGenderId
                         join types in objUsersDbContext.UserType on user.FkUserTypeId equals types.UserTypeId
                         join physAddress in objUsersDbContext.PhysicalAddress on user.PkUserId equals physAddress.FkUserId
                         join postAddress in objUsersDbContext.PostalAddress on user.PkUserId equals postAddress.FkUserId

                         select new

                         {
                             PK_UserId = user.PkUserId,
                             types.UserTypeName,
                             FirstName = user.FirstName,
                             MiddleName = user.MiddleName,
                             LastName = user.LastName,
                             gender.GenderValue,
                             DepartmentName = department.DepartmentName,  
                             IsApproved=user.IsApproved,                       
                             physAddress.StreetLine1,
                             physAddress.StreetLine2,
                             physAddress.StreetLine3,
                             postAddress.AddressLine1,
                             postAddress.AddressLine2,
                             postAddress.AddressLine3

                         });


            foreach (var results in query)
            {
                Console.WriteLine("UserId:{0}  UserType: {1}  First Name: {2} Middle Name: {3} Last Name: {4} Approval Status :{5} Gender: {6} Department Name: {7} Streetline1 {8} Streetline2 {9} Streetline3 {10}  Addressline1 {11} Addressline{12} Addressline {13}  ", results.PK_UserId, results.UserTypeName, results.FirstName, results.MiddleName, results.LastName, results.IsApproved,results.GenderValue
                    , results.DepartmentName, results.StreetLine1, results.StreetLine2 , results.StreetLine3, results.AddressLine1, results.AddressLine2, results.AddressLine3);

            }

            Console.ReadKey();

        }

    }


}


