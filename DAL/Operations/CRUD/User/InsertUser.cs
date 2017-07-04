using DAL.DBContext;
using DAL.Domain_Classes;
using DataAccessLayer.DomainClasses;
using Operations.CRUD.PhysicalAddress;
using System;

namespace Operations.CRUD.User
{
    class InsertUser
    {

        public void insert_user(string fname, string mname, string lname, string email, string password, int userDeptId, int userGenderId, int usertypeId)
        {
            using (var _ObjUsersDBContext = new UsersDbContext())
            {

                try
                {


                    var _ObjUser = new _User
                    {

                        IsDeleted = false,
                        IsApproved = false,

                        FirstName = fname,
                        MiddleName = mname,
                        LastName = lname,
                        EmailAddress = email,
                        Password = password,
                        FK_DepartmentId = userDeptId,
                        FK_GenderId = userGenderId,
                        FK_UserTypeId = usertypeId

                    };

                    _ObjUsersDBContext.user.Add(_ObjUser);
                    _ObjUsersDBContext.SaveChanges();
                    Console.WriteLine("New user has been created \r\n");

                    Console.WriteLine("Would you like to add your Physical Address? Y/N");
                    string answer = Console.ReadLine();

                    if ((answer.Equals("y", StringComparison.InvariantCultureIgnoreCase)))
                    {
                        var _ObjInsertPhysical = new InsertPhysical();
                        _ObjInsertPhysical.EnterPhysicalAddressDetails();
                    }
                    Console.ReadKey();
                }



                catch (Exception)
                {

                    Console.WriteLine("Could not create user ");
                }
            }
        }
        public void EnterUserDetails()
        {
            Console.WriteLine("Enter the firstname");
            string userFirstname = Console.ReadLine();

            Console.WriteLine("Enter the Middle name:");
            string userMiddleName = Console.ReadLine();

            Console.WriteLine("Enter the last name :");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Enter the email addres:");
            string userEmailAddress = Console.ReadLine();

            Console.WriteLine("Enter the password");
            string userPassword = Console.ReadLine();


            Console.WriteLine("Enter the Department ID");
            string userDeptId = Console.ReadLine();

            Console.WriteLine("Enter the GenderId");
            string userGenderId = Console.ReadLine();

            Console.WriteLine("Enter the usertypeid");
            string usertypeId = Console.ReadLine();

            var _ObjInsertUser = new InsertUser();
            _ObjInsertUser.insert_user(userFirstname, userMiddleName, userLastName, userEmailAddress, userPassword, Convert.ToInt16(userDeptId), Convert.ToInt16(userGenderId), Convert.ToInt16(usertypeId));


        }


    }
}