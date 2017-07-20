using DAL.Domain_Classes;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.DBContext
{
    public class SeedDataContext : DropCreateDatabaseIfModelChanges<UsersDbContext>
    {
        protected override void Seed(UsersDbContext context)
        {
            //Inserting Departments
            IList<Department> departments = new List<Department>();
            departments.Add(new Department() { DepartmentName = "GMIC", DepartmentDescription = "Gauteng Microsoft Solutions" });
            departments.Add(new Department() { DepartmentName = "GMOB", DepartmentDescription = "Gauteng Mobile Solutions" });
            departments.Add(new Department() { DepartmentName = "GQUA", DepartmentDescription = "Gauteng Quality Solutions" });

            foreach (Department dep in departments)
                context.Department.Add(dep);


            //Inserting Gender
            IList<Gender> genders = new List<Gender>();
            genders.Add(new Gender() { GenderValue = "Male" });
            genders.Add(new Gender() { GenderValue = "Female" });


            foreach (Gender gen in genders)
                context.Gender.Add(gen);



            //UserType, Normal--Sdmin
            //Province



            base.Seed(context);

        }

    }
}

