using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Security.Cryptography;

namespace Operations.CRUD.User
{
    class UpdateUser
    {

        public static void UpdateUserDetails(_User user)
        {
            using (var updateUserContext = new UsersDbContext())
            {
                try
                {


                    var objupdateUser = updateUserContext.User.Find(user.PkUserId);

                    objupdateUser.FirstName = user.FirstName;
                    objupdateUser.MiddleName = user.MiddleName;
                    objupdateUser.LastName = user.LastName;
                    objupdateUser.EmailAddress = user.EmailAddress;
                    objupdateUser.Password = user.Password;
                    objupdateUser.FkGenderId = user.FkGenderId;
                    objupdateUser.FkDepartmentId = user.FkDepartmentId;
                    objupdateUser.FkUserTypeId = user.FkUserTypeId;

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


        public void EnterUpdateUserDetails(_User user)
        {
            Console.WriteLine("Enter UserId to Update");
            user.PkUserId = Convert.ToInt32(Console.ReadLine());

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

            //calling  IUpdate_User method.

            UpdateUserDetails(user);


        }
        public string HashingPassword(string input)
        {
            byte[] hash;
            using (var sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
            {
                hash = sha1CryptoServiceProvider.ComputeHash(System.Text.Encoding.Unicode.GetBytes(input));
            }
            var stringBuilder = new System.Text.StringBuilder();

            foreach (byte b in hash) stringBuilder.AppendFormat("{0:x2}", b);
            {
                return stringBuilder.ToString();
            }
        }



    }
}

