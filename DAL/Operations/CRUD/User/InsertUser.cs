using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Operations.CRUD.User
{
    class InsertUser
    {

        public static void Insert_User(_User user)
        {

            using (var objUsersDbContext = new UsersDbContext())
            {

                try
                {

                    var objUser = new _User
                    {


                        IsDeleted = false,
                        IsApproved = false,

                        FirstName = user.FirstName,
                        MiddleName = user.MiddleName,
                        LastName = user.LastName,
                        EmailAddress = user.EmailAddress,
                        Password = user.Password,
                        FkDepartmentId = user.FkDepartmentId,
                        FkGenderId = user.FkGenderId,
                        FkUserTypeId = user.FkUserTypeId

                    };

                    objUsersDbContext.User.Add(objUser);
                    objUsersDbContext.SaveChanges();
                    Console.WriteLine("New user has been created \r\n");

                    Console.ReadKey();
                }


                catch (Exception)
                {

                    Console.WriteLine("Could not create user, Please make sure that all Required fields are filled with appropriate information. E.g Fisrt Name does not accept numeric values\r\n");
                    Console.WriteLine("Press enter to Re-register");
                    Console.ReadKey();
                    Console.Clear();

                    var objInsertUser = new InsertUser();
                    objInsertUser.EnterUserDetails(user);
                    Console.ReadKey();
                }
            }
        }

        public void EnterUserDetails(_User user)
        {
            Console.WriteLine("Enter the First Name");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Middle Name(Optional)");
            user.MiddleName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            user.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Email Address:");
            user.EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter your Password");
            user.Password = Console.ReadLine();

            Console.WriteLine("Enter Department ID, 1-GMIC, 2-GQUA, 3-GMOB");
            user.FkDepartmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  Gender ID 1-Male, 2-Female");
            user.FkGenderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter User Type Id, 1-Normal, 2-Admin");
            user.FkUserTypeId = Convert.ToInt32(Console.ReadLine());

            //Hashing the password with some salt
            //Calling or Invoking the HashingPassword method and Passing the entered Password + default Salt
            string salt = "Thisismydefaultsalt";
            string hashedPassword = HashingPassword(user.Password + salt);

            //calling  Insert_User method.
            Insert_User(user);

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