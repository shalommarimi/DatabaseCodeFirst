using DAL.DBContext;
using DAL.Domain_Classes;
using System;


namespace Operations.CRUD.PostalAddress
{
    class InsertPostal
    {

        public static void Insert_PostalAddress(Postal_Address postal)
        {

            using (var objUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var objPostalAddress = new Postal_Address
                    {

                        AddressLine1 = postal.AddressLine1,
                        AddressLine2 = postal.AddressLine2,
                        AddressLine3 = postal.AddressLine3,
                        FkSuburbId = postal.FkSuburbId,
                        FkUserId = postal.FkUserId

                    };
                    objUsersDbContext.PostalAddress.Add(objPostalAddress);
                    objUsersDbContext.SaveChanges();
                    Console.WriteLine("An Postal Address for User Id " + postal.FkUserId + " has beed added.");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not add Postal Address");
                    Console.ReadKey();
                }

            }


        }

        public void EnterPostalAddressDetails(Postal_Address postal)
        {

            Console.WriteLine("Please enter User-ID");
            postal.FkUserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter AddressLine 1");
            postal.AddressLine1 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 2");
            postal.AddressLine2 = Console.ReadLine();

            Console.WriteLine("Please enter AddressLine 3");
            postal.AddressLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            postal.FkSuburbId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\r\n");

            Insert_PostalAddress(postal);

        }
    }
}

