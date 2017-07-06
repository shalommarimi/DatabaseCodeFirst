using DAL.DBContext;
using System;
using System.Linq;

namespace Operations.CRUD.PhysicalAddress
{
    class UpdatePhysical
    {

        public void Update_Physical(string streetLine1, string streetLine2, string streetLine3, int fkSuburbId, int pkPhysicalId)
        {
            using (var usersDbContext = new UsersDbContext())
            {
                try
                {
                    var objUpdatePhysical = usersDbContext.PhysicalAddress.SingleOrDefault(x => x.PkPhysicalAddessId == pkPhysicalId);
                    
                    objUpdatePhysical = usersDbContext.PhysicalAddress.SingleOrDefault(x => x.PkPhysicalAddessId == pkPhysicalId);
                    objUpdatePhysical.StreetLine1 = streetLine1;
                    objUpdatePhysical.StreetLine2 = streetLine2;
                    objUpdatePhysical.StreetLine3 = streetLine3;
                    objUpdatePhysical.FkSuburbId = fkSuburbId;
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

        public void EnterPhysicalUpdateDetails()
        {

            Console.WriteLine("Please enter AddressId");
            int pkPhysicalId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine1");
            string streetLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine2");
            string streetLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine3");
            string streetLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb");
            int fkSuburbId = Convert.ToInt32(Console.ReadLine());

            Update_Physical(streetLine1, streetLine2, streetLine3, fkSuburbId, pkPhysicalId);
        }
    }
}
