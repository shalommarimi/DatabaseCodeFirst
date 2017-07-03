using System;
using DAL.DBContext;
using DataAccessLayer.DomainClasses;
using System.Linq;

namespace Operations.CRUD
{
    class UpdateApprovalStatus
    {

        public void UpdateUserApproval(int FK_UserId, bool isApproved)
        {
            using (var _ObjUsersDbContext = new UsersDbContext())
            {
                try
                {

                    var _ObjUser = new _User();

                    _ObjUser = _ObjUsersDbContext.user.SingleOrDefault(x => x.PK_UserId == FK_UserId);
                    _ObjUser.IsApproved = isApproved;
                    _ObjUsersDbContext.SaveChanges();

                    Console.WriteLine("User with Id " + FK_UserId + " has been Approved");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not Approve User, Please make sure the User exist");
                }
            }
        }
        public void EnterUpdateStatus()
        {
            Console.WriteLine("Please UserId to Approve");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Options \r\n 1.  Approve User \r\n 2. Disapprove User");
            int option = Convert.ToInt32(Console.ReadLine());
            bool isApproved = false;
            switch (option)
            {
                case 1:
                    isApproved = true;
                    break;

                case 2:
                    isApproved = false;
                    break;
                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }
            var _ObjUpdateUserStatus = new UpdateApprovalStatus();
            _ObjUpdateUserStatus.UpdateUserApproval(userId, isApproved);

        }
    }
}

