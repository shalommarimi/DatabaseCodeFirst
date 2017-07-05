using DAL.DBContext;
using DAL.Domain_Classes;
using DataAccessLayer.DomainClasses;
using System.Linq;
using System;

namespace Operations.CRUD.User
{
    class UpdateUser
    {
        public void EnterUpdateUserDetails()
        {
            Console.WriteLine("Enter UserId to Update");
            int PK_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Name");
            string userFirstname = Console.ReadLine();

            Console.WriteLine("Enter Middle Name (Optional))");
            string userMiddleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string userLastName = Console.ReadLine();


            Console.WriteLine("Enter Email Address:");
            string userEmailAddress = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string userPassword = Console.ReadLine();


            Console.WriteLine("Enter Department ID");
            string userDeptId = Console.ReadLine();

            Console.WriteLine("Enter GenderId");
            string userGenderId = Console.ReadLine();

            Console.WriteLine("Enter the UserTypeId");
            string usertypeId = Console.ReadLine();

            var _ObjUpdateUser = new UpdateUser();
            _ObjUpdateUser.UpdateUserDetails(PK_id, userFirstname, userMiddleName, userLastName, userEmailAddress, userPassword, Convert.ToInt16(userDeptId), Convert.ToInt16(userGenderId), Convert.ToInt16(usertypeId));


        }


        public void UpdateUserDetails(int PK_id, string userFirstname, string userMiddleName, string userLastName, string userEmailAddress, string userPassword, int userDeptId, int userGenderId, int usertypeId)
        {
            using (var updateUserContext = new UsersDbContext())
            {
                try
                {


                    var _objupdateUser = updateUserContext.user.Find(PK_id);

                    _objupdateUser.PK_UserId = PK_id;

                    _objupdateUser.FirstName = userFirstname;
                    _objupdateUser.MiddleName = userMiddleName;
                    _objupdateUser.LastName = userLastName;
                    _objupdateUser.EmailAddress = userEmailAddress;
                    _objupdateUser.Password = userPassword;
                    _objupdateUser.FK_GenderId = userGenderId;
                    _objupdateUser.FK_DepartmentId = userDeptId;
                    _objupdateUser.FK_UserTypeId = usertypeId;

                    updateUserContext.SaveChanges();

                    Console.WriteLine("User details updated");
                    Console.ReadKey();

                }
                catch (Exception)
                {
                    Console.WriteLine("Could not updated user Details");
                    Console.ReadKey();
                }
            }
        }
    }
}

