

using DAL.DBContext;
using DataAccessLayer.DomainClasses;
using System;
using System.Linq;

namespace Operations.CRUD.PostalAddress
{
    class UpdatePostal
    {
        public void EnterPostalUpdateDetails()
        {
            var _ObjUpdatePostal = new UpdatePostal();

            Console.WriteLine("Please enter AddressId");
            int PK_PostalId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine1");
            string addressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine2");
            string addressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine3");
            string addressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb");
            int FK_SuburbId = Convert.ToInt32(Console.ReadLine());

            Update_Postal(addressLine1, addressLine2, addressLine3, FK_SuburbId, PK_PostalId);
        }




        public void Update_Postal(string addressLine1, string addressLine2, string addressLine3, int FK_SuburbId, int FK_PostalId)
        {
            using (var usersDBContext = new UsersDbContext())
            {
                try
                {
                    var _ObjUpdatePostal = new Postal_Address();


                    _ObjUpdatePostal = usersDBContext.postalAddress.SingleOrDefault(x => x.PK_PostalAddressId == FK_PostalId);

                    _ObjUpdatePostal.AddressLine1 = addressLine1;
                    _ObjUpdatePostal.AddressLine2 = addressLine2;
                    _ObjUpdatePostal.AddressLine3 = addressLine3;
                    _ObjUpdatePostal.FK_SuburbId = FK_SuburbId;


                    usersDBContext.SaveChanges();
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
