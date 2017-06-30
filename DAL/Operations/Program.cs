using DAL.DBContext;
using Operations.CRUD;
using Operations.CRUD.PhysicalAddress;
using System;
using System.Collections.Generic;


namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                default:
                    break;
            }

            var _ObjInsertPhysicalAddress = new InsertPhysicalAddress();
            _ObjInsertPhysicalAddress.EnterPhysicalAddressDetails();

            //var _ObjInsertDepartment = new InsertDepartment();
            //_ObjInsertDepartment.EntertDepartmentDetails();

            //var _ObjInsertPostalAddress = new InsertPostalAddress();
            //_ObjInsertPostalAddress.EnterPostalAddressDetails();
        }
    }
}
