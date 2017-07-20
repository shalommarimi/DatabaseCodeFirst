using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Linq;

namespace Operations.CRUD.PhysicalAddress
{
    class UpdatePhysical
    {

        public static void Update_Physical(Physical_Address physical)
        {
            using (var usersDbContext = new UsersDbContext())
            {
                try
                {
                    var objUpdatePhysical = usersDbContext.PhysicalAddress.SingleOrDefault(x => x.PkPhysicalAddessId == physical.PkPhysicalAddessId);

                    objUpdatePhysical.StreetLine1 = physical.StreetLine1;
                    objUpdatePhysical.StreetLine2 = physical.StreetLine2;
                    objUpdatePhysical.StreetLine3 = physical.StreetLine3;

                    objUpdatePhysical.FkSuburbId = physical.FkSuburbId;
                    usersDbContext.SaveChanges();
                    Console.WriteLine("Physical Address Updated");
                    Console.ReadKey();
                }
                catch (Exception)
                {

                    Console.WriteLine("Could not Update Physical Address");
                    Console.ReadKey();
                }

            }

        }

        public void EnterPhysicalUpdateDetails(Physical_Address physical)
        {


            Console.WriteLine("Please enter AddressId");
            physical.PkPhysicalAddessId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine 1");
            physical.StreetLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 2");
            physical.StreetLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 3");
            physical.StreetLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            physical.FkSuburbId = Convert.ToInt32(Console.ReadLine());

            Update_Physical(physical);
        }
    }
}
