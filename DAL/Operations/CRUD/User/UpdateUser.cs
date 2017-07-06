using DAL.DBContext;
using System;

namespace Operations.CRUD.User
{
    class UpdateUser
    {

        public void UpdateUserDetails(int pkUserId, string userFirstname, string userMiddleName, string userLastName, string userEmailAddress, string userPassword, int userDeptId, int userGenderId, int usertypeId)
        {
            using (var updateUserContext = new UsersDbContext())
            {
                try
                {


                    var objupdateUser = updateUserContext.User.Find(pkUserId);

                    objupdateUser.PkUserId = pkUserId;

                    objupdateUser.FirstName = userFirstname;
                    objupdateUser.MiddleName = userMiddleName;
                    objupdateUser.LastName = userLastName;
                    objupdateUser.EmailAddress = userEmailAddress;
                    objupdateUser.Password = userPassword;
                   // objupdateUser.FkGenderId = userGenderId;
                   // objupdateUser.FkDepartmentId = userDeptId;
                  //  objupdateUser.FkUserTypeId = usertypeId;

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


        public void EnterUpdateUserDetails()
        {
            Console.WriteLine("Enter UserId to Update");
            int pkUserId = Convert.ToInt32(Console.ReadLine());

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

            var objUpdateUser = new UpdateUser();
            objUpdateUser.UpdateUserDetails(pkUserId, userFirstname, userMiddleName, userLastName, userEmailAddress, userPassword, Convert.ToInt16(userDeptId), Convert.ToInt16(userGenderId), Convert.ToInt16(usertypeId));


        }



    }
}

