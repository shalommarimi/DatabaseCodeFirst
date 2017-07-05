using DAL.DBContext;
using DAL.Domain_Classes;
using System;


namespace Operations.CRUD.PhysicalAddress
{
    class InsertPhysical
    {


        public void Insert_PhysicalAddress(string streetLine1, string streetLine2, string streetLine3, int FK_SuburbId, int FK_UserId)

        {
            using (var _ObjUsersDBContext = new UsersDbContext())
            {
                try
                {
                    var _ObjPhysicalAddress = new Physical_Address
                    {

                        StreetLine1 = streetLine1,
                        StreetLine2 = streetLine2,
                        StreetLine3 = streetLine3,
                        FK_SuburbId = FK_SuburbId,
                        FK_UserId = FK_UserId

                    };
                    _ObjUsersDBContext.physicalAddress.Add(_ObjPhysicalAddress);
                    _ObjUsersDBContext.SaveChanges();
                    Console.WriteLine("An Physical Address for User Id " + FK_UserId + " has beed added.");
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
            int FK_UserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter StreetLine 1");
            string streetLine1 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 2");
            string streetLine2 = Console.ReadLine();

            Console.WriteLine("Please enter StreetLine 3");
            string streetLine3 = Console.ReadLine();

            Console.WriteLine("Please enter Suburb-ID");
            int FK_SuburbId = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\r\n");

            var _ObjInsertPhysicalAddress = new InsertPhysical();
            _ObjInsertPhysicalAddress.Insert_PhysicalAddress(streetLine1, streetLine2, streetLine3, FK_UserId, FK_SuburbId);

        }


    }
}
