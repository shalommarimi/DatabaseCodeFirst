using DAL.DBContext;
using Operations.CRUD;
using System;
using System.Collections.Generic;


namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            //var _ObjInsertPhysicalAddress = new InsertPhysicalAddress();
            //_ObjInsertPhysicalAddress.EnterPhysicalAddressDetails();

            var _ObjInsertDepartment = new InsertDepartment();
            _ObjInsertDepartment.EntertDepartmentDetails();

            //var _ObjInsertPostalAddress = new InsertPostalAddress();
            //_ObjInsertPostalAddress.EnterPostalAddressDetails();
        }
    }
}
