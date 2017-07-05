using DAL.Domain_Classes;
using System.Data.Entity;
namespace DAL.DBContext
{
    public class UsersDbContext : DbContext
    {


        public virtual DbSet<_User> User { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<PhysicalAddress> PhysicalAddress { get; set; }
        public virtual DbSet<PostalAddress> PostalAddress { get; set; }
        public virtual DbSet<PostalCode> PostalCode { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Suburb> Suburb { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<City> City { get; set; }

    }
}
