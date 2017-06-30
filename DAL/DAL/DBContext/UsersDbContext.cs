

using DAL.Domain_Classes;
using DataAccessLayer.DomainClasses;
using System.Data.Entity;
namespace DAL.DBContext
{
   public class UsersDbContext : DbContext
    {


        public virtual DbSet<_User> user { get; set; }
        public virtual DbSet<Department> department { get; set; }
        public virtual DbSet<Gender> gender { get; set; }
        public virtual DbSet<Physical_Address> physicalAddress { get; set; }
        public virtual DbSet<Postal_Address> postalAddress { get; set; }
        public virtual DbSet<Postal_Code> postalCode { get; set; }
        public virtual DbSet<Province> province { get; set; }
        public virtual DbSet<Suburb> suburb { get; set; }
        public virtual DbSet<UserType> userType{ get; set; }
        public virtual DbSet<City> city { get; set; }

    }
}
