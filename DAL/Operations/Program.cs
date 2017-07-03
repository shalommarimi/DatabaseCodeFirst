﻿using DAL.DBContext;
using Operations.CRUD;
using Operations.CRUD.PhysicalAddress;
using System;


namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Menu \r\n  \r\n User Operations: \r\n 1. Register User  \r\n 2. Update User  \r\n 3. Delete User \r\n");
            Console.WriteLine("Physical Address Operations: \r\n 4. Enter User Physical Address  \r\n 5. Update User Physical Address  \r\n 6. Delete Physical Address \r\n");
            Console.WriteLine("Postal Address Operations: \r\n 7. Enter User Postal Address  \r\n 8. Update User Postal Address  \r\n 9. Delete Postal Address");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    var _ObjInsertDepartment = new InsertDepartment();
                    _ObjInsertDepartment.EntertDepartmentDetails();
                    break;

                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    var _ObjInsertPhysical = new InsertPhysical();
                    _ObjInsertPhysical.EnterPhysicalAddressDetails();
                    break;
                case 5:
                    var _ObjUpdatePhysical = new UpdatePhysical();
                    _ObjUpdatePhysical.EnterPhysicalUpdateDetails();
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Opps! Invalid option entered. Retry");
                    break;
            }


            //var _ObjInsertDepartment = new InsertDepartment();
            //_ObjInsertDepartment.EntertDepartmentDetails();



        }
    }
}
