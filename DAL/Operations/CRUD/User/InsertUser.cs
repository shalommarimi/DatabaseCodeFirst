using DAL.DBContext;
using System;
using System.Security.Cryptography;
using System.Text;
using DAL.Domain_Classes;

namespace Operations.CRUD.User
{
    class InsertUser
    {

        public void Insert_User(string firstName, string middleName, string lastName, string email, string password, int fkDepartmentId, int fkGenderId, int fkUserTypeId)

        {
            using (var objUsersDbContext = new UsersDbContext())
            {

                try
                {

                    var objUser = new _User
                    {

                        IsDeleted = false,
                        IsApproved = false,

                        FirstName = firstName,
                        MiddleName = middleName,
                        LastName = lastName,
                        EmailAddress = email,
                        Password = password,
                        FkDepartmentId = fkDepartmentId,
                        FkGenderId = fkGenderId,
                        FkUserTypeId = fkUserTypeId

                    };

                    objUsersDbContext.User.Add(objUser);
                    objUsersDbContext.SaveChanges();
                    Console.WriteLine("New user has been created \r\n");

                    Console.WriteLine("would you like to add your physical address: Y/N");
                    char value =Console;
                    if()
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
            string fkDepartmentId = Console.ReadLine();

            Console.WriteLine("Enter  Gender ID 1-Male, 2-Female");
            string fkGenderId = Console.ReadLine();

            Console.WriteLine("Enter User Type Id, 1-Normal, 2-Admin");
            string fkUserTypeId = Console.ReadLine();

            //Hashing the password with some salt
            //Calling or Invoking the HashingPassword method and Passing the entered Password + default Salt
            string salt = "Thisismydefaultsalt";
            string hashedPassword = HashingPassword(password + salt);


            var objInsertUser = new InsertUser();
            objInsertUser.Insert_User(firstName, middleName, lastName, email, hashedPassword, Convert.ToInt16(fkDepartmentId), Convert.ToInt16(fkGenderId), Convert.ToInt16(fkUserTypeId));


        }

        public string HashingPassword(string input)
        {
            byte[] hash;
            using (var sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
            {
                hash = sha1CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(input));
            }
            var stringBuilder = new StringBuilder();

            foreach (byte b in hash) stringBuilder.AppendFormat("{0:x2}", b);
            {
                return stringBuilder.ToString();
            }
        }


    }
}