

using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Linq;

namespace Operations.CRUD.PostalAddress
{
    class UpdatePostal
    {





        public void Update_Postal(Postal_Address postal)
        {
            using (var usersDbContext = new UsersDbContext())
            {
                try
                {
                    var objUpdatePostal = usersDbContext.PostalAddress.SingleOrDefault(x => x.PkPostalAddressId == postal.PkPostalAddressId);

                    objUpdatePostal.AddressLine1 = postal.AddressLine1;
                    objUpdatePostal.AddressLine2 = postal.AddressLine2;
                    objUpdatePostal.AddressLine3 = postal.AddressLine3;
                    objUpdatePostal.FkSuburbId = postal.FkSuburbId;


                    usersDbContext.SaveChanges();
                    Console.WriteLine("Postal Address Updated");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not Update Postal Address");
                    Console.ReadKey();
                }

            }


        }

        public void EnterPostalUpdateDetails(Postal_Address postal)
        {



            Console.WriteLine("Please enter Postal AddressId");
            postal.PkPostalAddressId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter AddressLine 1");
            postal.AddressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 2");
            postal.AddressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 3");
            postal.AddressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            postal.FkSuburbId = Convert.ToInt32(Console.ReadLine());

            Update_Postal(postal);
        }
    }
}
