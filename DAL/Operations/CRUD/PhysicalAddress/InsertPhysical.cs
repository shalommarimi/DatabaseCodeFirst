using DAL.DBContext;
using DAL.Domain_Classes;
using System;



namespace Operations.CRUD.PhysicalAddress
{
    class InsertPhysical
    {


        public static void Insert_PhysicalAddress(Physical_Address physical)

        {
            using (var objUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var objPhysicalAddress = new Physical_Address
                    {

                        StreetLine1 = physical.StreetLine1,
                        StreetLine2 = physical.StreetLine2,
                        StreetLine3 = physical.StreetLine3,
                        FkSuburbId = physical.FkSuburbId,
                        FkUserId = physical.FkUserId

                    };
                    objUsersDbContext.PhysicalAddress.Add(objPhysicalAddress);
                    objUsersDbContext.SaveChanges();
                    Console.WriteLine("An Physical Address for User Id " + physical.FkUserId + " has beed added.");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not add Physical Address");
                }

            }


        }

        public void EnterPhysicalAddressDetails(Physical_Address physical)
        {

            Console.WriteLine("Please enter User-ID");
            physical.FkUserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine 1");
            physical.StreetLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 2");
            physical.StreetLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 3");
            physical.StreetLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            physical.FkSuburbId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\r\n");

            Insert_PhysicalAddress(physical);

        }


    }
}
