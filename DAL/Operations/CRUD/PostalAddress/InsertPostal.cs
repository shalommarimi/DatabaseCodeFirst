using DAL.DBContext;
using DataAccessLayer.DomainClasses;
using System;


namespace Operations.CRUD.PostalAddress
{
    class InsertPostal
    {

        public void Insert_PostalAddress(string addressLine1, string addressLine2,string addressLine3, int FK_UserId, int FK_SuburbId)
        {

            using (var _ObjUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var _ObjPostalAddress = new Postal_Address
                    {

                        AddressLine1 = addressLine1,
                        AddressLine2 = addressLine2,
                        AddressLine3 = addressLine3,
                        FK_SuburbId = FK_SuburbId,
                        FK_UserId = FK_UserId

                    };
                    _ObjUsersDbContext.postalAddress.Add(_ObjPostalAddress);
                    _ObjUsersDbContext.SaveChanges();
                    Console.WriteLine("An Postal Address for User Id " + FK_UserId + " has beed added.");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not add Postal Address");
                }

            }


        }
        public void EnterPostalAddressDetails()
        {

            Console.WriteLine("Please enter User-ID");
            int FK_UserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter AddressLine 1");
            string addressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 2");
            string addressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 3");
            string addressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            int FK_SuburbId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\r\n");

            var _ObjInsertPostalAddress = new InsertPostal();
            _ObjInsertPostalAddress.Insert_PostalAddress(addressLine1, addressLine2, addressLine3, FK_UserId, FK_SuburbId);

        }
    }
}

