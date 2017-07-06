using DAL.DBContext;
using System;
using System.Linq;

namespace Operations.CRUD.User
{
    class UpdateApprovalStatus
    {

        public void UpdateUserApproval(int fkUserId, bool isApproved)
        {
            using (var objUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var objUser = objUsersDbContext.User.SingleOrDefault(x => x.PkUserId == fkUserId);
                    objUser.IsApproved = isApproved;
                    objUsersDbContext.SaveChanges();

                    Console.WriteLine("User with Id " + fkUserId + " has been Approved");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not Approve User, Please make sure the User exist");
                    Console.ReadKey();
                }
            }
        }



        public void EnterUpdateStatus()
        {
            Console.WriteLine("Please UserId to Approve");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Options \r\n 1.  Approve User");
            int option = Convert.ToInt32(Console.ReadLine());
            bool isApproved = false;
            switch (option)
            {
                case 1:
                    isApproved = true;
                    break;

                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }
            var objUpdateUserStatus = new UpdateApprovalStatus();
            objUpdateUserStatus.UpdateUserApproval(userId, isApproved);

        }
    }
}

