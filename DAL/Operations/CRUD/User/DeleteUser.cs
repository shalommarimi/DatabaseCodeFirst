using DAL.DBContext;
using System;
using System.Linq;

namespace Operations.CRUD.User
{
    class DeleteUser
    {

        public void SoftDeleteUser(int fkUserId, bool isDeleted)
        {
            using (var objUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var objUser = objUsersDbContext.User.SingleOrDefault(x => x.PkUserId == fkUserId);
                    objUser.IsDeleted = isDeleted;
                    objUsersDbContext.SaveChanges();

                    Console.WriteLine("User with Id " + fkUserId + " has been deleted");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not delete User, Please make sure the User exist");
                    Console.ReadKey();
                }
            }
        }



        public void UserIdToDelete()
        {
            Console.WriteLine("Please UserId to delete");

            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Options \r\n Press 1 to Delete User");
            int option = Convert.ToInt32(Console.ReadLine());
            bool isDeleted = false;
            switch (option)
            {
                case 1:
                    isDeleted = true;
                    break;

                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }
            var objSoftDeleteUser = new DeleteUser();
            objSoftDeleteUser.SoftDeleteUser(userId, isDeleted);

        }
    }
}
