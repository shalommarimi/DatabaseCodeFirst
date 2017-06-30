using DAL.DBContext;
using DataAccessLayer.DomainClasses;

namespace Operations.CRUD.User
{
    class InsertUser
    {
        public void Insert_User()
        {
            using (var usersDbContext = new UsersDbContext())
            {
                try
                {
                   var user = new _User();
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
     
    }
}
