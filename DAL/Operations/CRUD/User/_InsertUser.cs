using DAL.DBContext;
using DataAccessLayer.DomainClasses;

namespace Operations.CRUD.User
{
    class _InsertUser
    {
        public void Insert_User()
        {
            using (var usersDbContext = new UsersDbContext())
            {
                try
                {
                    var user = new _User
                    {
                        FirstName = "You are an idiot Giraffe"

                   };
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
     
    }
}
