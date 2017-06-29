//using System;
//using Dataaccess;




//namespace CodeFirstEntityFramework.Operations
//{
//    class InsertDepartment
//    {
//        public void EntertDepartmentDetails()
//        {

            
//            Console.WriteLine("Please enter Department Name");
//            string _departmentName = Console.ReadLine();

//            Console.WriteLine("Please enter Department Description");
//            string _departmentDescription = Console.ReadLine();

//            Console.WriteLine("\r\n");


//            var _ObjInsertDepartment = new InsertDepartment();
//           _ObjInsertDepartment.Insert_Department(_departmentName, _departmentDescription);

//        }

//        public void Insert_Department(string _departmentName, string _departmentDescription)
//        {
//            using (var usersDBContext = new UsersDBContext())
//            {
//                try
//                {
//                    Department _Objdepartment = new Department();
//                    _Objdepartment.DepartmentName = _departmentName;
//                    _Objdepartment.DepartmentDescription = _departmentDescription;
//                    usersDBContext.departments.Add(_Objdepartment);
//                    usersDBContext.SaveChanges();

//                    Console.WriteLine(" A new Department has been inserted");
//                    Console.ReadKey();
//                }
//                catch (Exception)
//                {

//                    Console.WriteLine("Could not insert new Department");
//                }
            
//            }

          

//        }
        
//    }
//}
