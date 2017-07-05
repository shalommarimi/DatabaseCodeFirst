using DAL.DBContext;
using DataAccessLayer.DomainClasses;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Operations.CRUD.User
{
    class InsertUser
    {

        public void Insert_User(string firstName, string middleName, string lastName, string email, string password, int FK_DepartmentId, int FK_GenderId, int FK_UserTypeId)

        {
            using (var _ObjUsersDBContext = new UsersDbContext())
            {

                try
                {

                    var _ObjUser = new _User
                    {

                        IsDeleted = false,
                        IsApproved = false,

                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        EmailAddress = email,
                        Password = password,
                        FK_DepartmentId = FK_DepartmentId,
                        FK_GenderId = FK_GenderId,
                        FK_UserTypeId = FK_UserTypeId

                    };

                    _ObjUsersDBContext.user.Add(_ObjUser);
                    _ObjUsersDBContext.SaveChanges();
                    Console.WriteLine("New user has been created \r\n");
                    Console.ReadKey();
                }


                catch (Exception)
                {

                    Console.WriteLine("Could not create user, Please make sure that all Required fields are filled with appropriate information. E.g Fisrt Name does not accept numeric values");
                    Console.ReadKey();
                }
            }
        }



        public void EnterUserDetails()
        {
            Console.WriteLine("Enter the First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the Middle Name(Optional)");
            string middleName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the Email Address:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();


            Console.WriteLine("Enter Department ID, 1-GMIC, 2-GQUA, 3-GMOB");
            string FK_DepartmentId = Console.ReadLine();

            Console.WriteLine("Enter  Gender ID 1-Male, 2-Female");
            string FK_GenderId = Console.ReadLine();

            Console.WriteLine("Enter User Type Id, 1-Normal, 2-Admin");
            string FK_UserTypeId = Console.ReadLine();

            //Hashing the password with some salt
            //Calling or Invoking the HashingPassword method and Passing the entered Password + default Salt
            string salt = "Thisismydefaultsalt";
            string hashedPassword = HashingPassword(password + salt);


            var _ObjInsertUser = new InsertUser();
            _ObjInsertUser.Insert_User(firstName, middleName, lastName, email, hashedPassword, Convert.ToInt16(FK_DepartmentId), Convert.ToInt16(FK_GenderId), Convert.ToInt16(FK_UserTypeId));


        }

        public string HashingPassword(string input)
        {
            byte[] hash;
            using (var _SHA1CryptoServiceProvider = new SHA1CryptoServiceProvider())
            {
                hash = _SHA1CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(input));
            }
            var _StringBuilder = new StringBuilder();

            foreach (byte b in hash) _StringBuilder.AppendFormat("{0:x2}", b);
            {
                return _StringBuilder.ToString();
            }
        }


    }
}