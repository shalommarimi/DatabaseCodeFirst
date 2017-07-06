using DAL.DBContext;
using DAL.Domain_Classes;
using System;



namespace Operations.CRUD.PhysicalAddress
{
    class InsertPhysical
    {


        public void Insert_PhysicalAddress(string streetLine1, string streetLine2, string streetLine3, int fkSuburbId, int fkUserId)

        {
            using (var objUsersDbContext = new UsersDbContext())
            {
                try
                {
                    var objPhysicalAddress = new Physical_Address
                    {

                        StreetLine1 = streetLine1,
                        StreetLine2 = streetLine2,
                        StreetLine3 = streetLine3,
                        FkSuburbId = fkSuburbId,
                        FkUserId = fkUserId

                    };
                    objUsersDbContext.PhysicalAddress.Add(objPhysicalAddress);
                    objUsersDbContext.SaveChanges();
                    Console.WriteLine("An Physical Address for User Id " + fkUserId + " has beed added.");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not add Physical Address");
                }

            }


        }

        public void EnterPhysicalAddressDetails()
        {

            Console.WriteLine("Please enter User-ID");
            int fkUserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine 1");
            string streetLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 2");
            string streetLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 3");
            string streetLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            int fkSuburbId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\r\n");

            var objInsertPhysicalAddress = new InsertPhysical();
            objInsertPhysicalAddress.Insert_PhysicalAddress(streetLine1, streetLine2, streetLine3, fkUserId, fkSuburbId);

        }


    }
}
