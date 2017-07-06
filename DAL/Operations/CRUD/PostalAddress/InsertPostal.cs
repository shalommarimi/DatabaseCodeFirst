using DAL.DBContext;
using DAL.Domain_Classes;
using System;


namespace Operations.CRUD.PostalAddress
{
    class InsertPostal
    {

        public void Insert_PostalAddress(string addressLine1, string addressLine2, string addressLine3, int fkUserId, int fkSuburbId)
        {

            using (var objUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var objPostalAddress = new Postal_Address
                    {

                        AddressLine1 = addressLine1,
                        AddressLine2 = addressLine2,
                        AddressLine3 = addressLine3,
                        FkSuburbId = fkSuburbId,
                        FkUserId = fkUserId

                    };
                    objUsersDbContext.PostalAddress.Add(objPostalAddress);
                    objUsersDbContext.SaveChanges();
                    Console.WriteLine("An Postal Address for User Id " + fkUserId + " has beed added.");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not add Postal Address");
                    Console.ReadKey();
                }

            }


        }
        public void EnterPostalAddressDetails()
        {

            Console.WriteLine("Please enter User-ID");
            int fkUserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter AddressLine 1");
            string addressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 2");
            string addressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 3");
            string addressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            int fkSuburbId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\r\n");

            var objInsertPostalAddress = new InsertPostal();
            objInsertPostalAddress.Insert_PostalAddress(addressLine1, addressLine2, addressLine3, fkUserId, fkSuburbId);

        }
    }
}

