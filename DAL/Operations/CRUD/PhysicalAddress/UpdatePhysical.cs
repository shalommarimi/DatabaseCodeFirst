using DAL.DBContext;
using DAL.Domain_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.CRUD.PhysicalAddress
{
    class UpdatePhysical
    {

        public void Update_Physical(string streetLine1, string streetLine2, string streetLine3, int FK_SuburbId, int PK_PhysicalId)
        {
            using (var usersDBContext = new UsersDbContext())
            {
                try
                {
                    var _ObjUpdatePhysical = new Physical_Address();


                    _ObjUpdatePhysical = usersDBContext.physicalAddress.SingleOrDefault(x => x.PK_PhysicalAddessId == PK_PhysicalId);

                    _ObjUpdatePhysical.StreetLine1 = streetLine1;
                    _ObjUpdatePhysical.StreetLine2 = streetLine2;
                    _ObjUpdatePhysical.StreetLine3 = streetLine3;

                    _ObjUpdatePhysical.FK_SuburbId = FK_SuburbId;
                    usersDBContext.SaveChanges();
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
            var _ObjUpdateDepartment = new UpdatePhysical();

            Console.WriteLine("Please enter AddressId");
            int PK_PhysicalId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine1");
            string streetLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine2");
            string streetLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine3");
            string streetLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb");
            int FK_SuburbId = Convert.ToInt32(Console.ReadLine());

            Update_Physical(streetLine1, streetLine2, streetLine3, FK_SuburbId, PK_PhysicalId);
        }
    }
}
