
using System.Data.Entity;
namespace DAL.DBContext
{
    class UsersDbContext : DbContext
    {
        public class UsersDBContext : DbContext
        {

            //public virtual DbSet<User> users { get; set; }
            //public virtual DbSet<Department> departments { get; set; }
            //public virtual DbSet<Gender> genders { get; set; }
            public virtual DbSet<Physical_Address> physicalAddresses { get; set; }
            public virtual DbSet<Postal_Address> postalAddresses { get; set; }
            public virtual DbSet<Postal_Code> postalCodes { get; set; }
            public virtual DbSet<Province> provinces { get; set; }
            public virtual DbSet<Suburb> suburbs { get; set; }
            public virtual DbSet<UserType> userTypes { get; set; }
            public virtual DbSet<City> cities { get; set; }

        }
    }
}
