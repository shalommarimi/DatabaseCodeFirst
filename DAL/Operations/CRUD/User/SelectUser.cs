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

            var qry = objUsersDbContext.User.Where(x => x.IsApproved == false).Select(y => new { y.PkUserId, y.FirstName, y.MiddleName, y.LastName,  y.Gender.GenderValue, y.Department.DepartmentName, y.PhysicalAddress.FirstOrDefault().StreetLine1, y.PhysicalAddress.FirstOrDefault().StreetLine2, y.PhysicalAddress.FirstOrDefault().StreetLine3 });
            foreach (var results in qry)
            {
                Console.WriteLine("  UserID: {0} First Name: {1}  Middle Name: {2} Last Name: {3} Gender: {4} Department Name: {5} Streetline1: {6} Streetline2: {7} Streetline3: {8}  ", results.PkUserId, results.FirstName, results.MiddleName, results.LastName,  results.GenderValue
                    , results.DepartmentName, results.StreetLine1, results.StreetLine2, results.StreetLine3);

            }

            Console.ReadKey();

        }
        
    }


}


