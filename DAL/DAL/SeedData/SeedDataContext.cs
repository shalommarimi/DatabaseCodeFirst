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


            //Inserting Provinces
            IList<Province> provinces = new List<Province>();
            provinces.Add(new Province() { ProvinceName = "Gauteng" });
            provinces.Add(new Province() { ProvinceName = "Limpopo" });
            provinces.Add(new Province() { ProvinceName = "Free State" });
            provinces.Add(new Province() { ProvinceName = "Northen Cape" });
            provinces.Add(new Province() { ProvinceName = "North West" });
            provinces.Add(new Province() { ProvinceName = "Kwa-Zulu Natal" });
            provinces.Add(new Province() { ProvinceName = "Mpumalanga" });
            provinces.Add(new Province() { ProvinceName = "Western Cape" });
            provinces.Add(new Province() { ProvinceName = "Eastern Cape" });

            foreach (Province pro in provinces)
                context.Province.Add(pro);




            IList<City> cities = new List<City>();
            cities.Add(new City() { CityName = "Johannesburg" });
            cities.Add(new City() { CityName = "Polokwane" });
            cities.Add(new City() { CityName = "Bloemfontein" });
            cities.Add(new City() { CityName = "Upington" });
            cities.Add(new City() { CityName = "Mahikeng" });
            cities.Add(new City() { CityName = "Durban" });
            cities.Add(new City() { CityName = "Witbank" });
            cities.Add(new City() { CityName = "Cape Town" });
            cities.Add(new City() { CityName = "East London" });


            foreach (City ci in cities)
                context.City.Add(ci);



            IList<Suburb> suburbs = new List<Suburb>();
            suburbs.Add(new Suburb() { SuburbName = "Ridgeway" });
            suburbs.Add(new Suburb() { SuburbName = "Jane Furse" });
            suburbs.Add(new Suburb() { SuburbName = "Willows" });
            suburbs.Add(new Suburb() { SuburbName = "Flora Park" });
            suburbs.Add(new Suburb() { SuburbName = "Danville" });
            suburbs.Add(new Suburb() { SuburbName = "Ballito" });
            suburbs.Add(new Suburb() { SuburbName = "Willows" });
            suburbs.Add(new Suburb() { SuburbName = "Atlantic Seaboard" });
            suburbs.Add(new Suburb() { SuburbName = "Beacon Bay" });


            foreach (Suburb sub in suburbs)
                context.Suburb.Add(sub);




            base.Seed(context);

        }

    }
}

