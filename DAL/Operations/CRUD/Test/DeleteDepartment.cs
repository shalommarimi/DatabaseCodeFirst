//using Dataaccess;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CodeFirstEntityFramework.Operations
//{
//    class DeleteDepartment
//    {
//        public void Delete_Department(int PK_DepartmentId)
//        {
//            using (var usersDBContext = new UsersDBContext())
//            {
//                try
//                {
//                    var _ObjUpdateDepartment = new Department();
//                    _ObjUpdateDepartment = usersDBContext.departments.SingleOrDefault(x => x.PK_DepartmentId == PK_DepartmentId);
//                    usersDBContext.departments.Remove(_ObjUpdateDepartment);
//                    usersDBContext.SaveChanges();
//                    Console.WriteLine("Department Deleted");
//                    Console.ReadKey();
//                }
//                catch (Exception)
//                {

//                    Console.WriteLine("Could not delete Department, Department with ID " + PK_DepartmentId + " may not exist or there is a Referential Integrity constraint");
//                    Console.ReadKey();
//                }

//            }
//        }

//        public void EnterDepartId()
//        {
//            var _ObjUpdateDepartment = new UpdateDepartment();

//            Console.WriteLine("Please enter Department ID to Delete");
//            int PK_Departmentid = Convert.ToInt32(Console.ReadLine());
            
//            Delete_Department(PK_Departmentid);
//        }

//    }
//}
