//using Dataaccess;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CodeFirstEntityFramework.Operations
//{
//    class UpdateDepartment
//    {
//       public void Update_Department(int PK_DepartmentId, string Departmentname, string DepartmentDescription)
//        {
//            using (var usersDBContext = new UsersDBContext())
//            {
//                try
//                {
//                    var _ObjUpdateDepartment = new Department();
//                    _ObjUpdateDepartment = usersDBContext.departments.SingleOrDefault(x => x.PK_DepartmentId == PK_DepartmentId);
//                    _ObjUpdateDepartment.DepartmentName = Departmentname;
//                    _ObjUpdateDepartment.DepartmentDescription = DepartmentDescription;
//                    usersDBContext.SaveChanges();
//                    Console.WriteLine("Department Updated");
//                    Console.ReadKey();
//                }
//                catch (Exception)
//                {

//                    Console.WriteLine("Could not update Department, Department with ID " +PK_DepartmentId + " may not exist");
//                    Console.ReadKey();
//                }
               
//            }
            
//        }

//        public  void EnterUpdateDetails()
//        {
//            var _ObjUpdateDepartment = new UpdateDepartment();

//            Console.WriteLine("Please enter Department ID to update");
//            int PK_Departmentid = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Please enter Departmenrt Name");
//            string DepartmentName = Console.ReadLine();

//            Console.WriteLine("Please enter Department Description");
//            string DepartmentDescription = Console.ReadLine();
//            Update_Department(PK_Departmentid, DepartmentName, DepartmentDescription);
//        }


//    }
//}
