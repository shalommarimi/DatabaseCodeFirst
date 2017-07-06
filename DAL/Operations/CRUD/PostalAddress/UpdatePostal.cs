

using DAL.DBContext;
using System;
using System.Linq;

namespace Operations.CRUD.PostalAddress
{
    class UpdatePostal
    {
        public void EnterPostalUpdateDetails()
        {


            Console.WriteLine("Please enter AddressId");
            int pkPostalId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine1");
            string addressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine2");
            string addressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine3");
            string addressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb");
            int fkSuburbId = Convert.ToInt32(Console.ReadLine());

            Update_Postal(addressLine1, addressLine2, addressLine3, fkSuburbId, pkPostalId);
        }




        public void Update_Postal(string addressLine1, string addressLine2, string addressLine3, int fkSuburbId, int fkPostalId)
        {
            using (var usersDbContext = new UsersDbContext())
            {
                try
                {
                    var objUpdatePostal = usersDbContext.PostalAddress.SingleOrDefault(x => x.PkPostalAddressId == fkPostalId);

                    objUpdatePostal.AddressLine1 = addressLine1;
                    objUpdatePostal.AddressLine2 = addressLine2;
                    objUpdatePostal.AddressLine3 = addressLine3;
                    objUpdatePostal.FkSuburbId = fkSuburbId;


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
    }
}
