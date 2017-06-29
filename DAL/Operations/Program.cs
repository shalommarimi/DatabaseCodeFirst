using DAL.DBContext;
using Operations.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
