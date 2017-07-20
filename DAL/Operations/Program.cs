using DAL.Domain_Classes;
using Operations.CRUD.PhysicalAddress;
using Operations.CRUD.PostalAddress;
using Operations.CRUD.User;
using System;


namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Menu \r\n  \r\n User Operations: \r\n 0. See Registered Users \r\n 1. Register User  \r\n 2. Update User  \r\n ");
            Console.WriteLine("Physical Address Operations: \r\n 3. Enter User Physical Address  \r\n 4. Update User Physical Address  \r\n ");
            Console.WriteLine("Postal Address Operations: \r\n 5. Enter User Postal Address  \r\n 6. Update User Postal Address  \r\n ");
            Console.WriteLine("User Approval Operations: \r\n 7. Press 1 to Approve User");
            Console.WriteLine("User Deletion Operations: \r\n 8. Press 1 to Delete User");



            //Object in use by 2---Methods as Parameter ,thats why is Glabol
            var user = new _User();
            var physical = new Physical_Address();
            var postal = new Postal_Address();


            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    var objSelectUser = new SelectUser();
                    objSelectUser.RetrieveUser();
                    break;
                case 1:
                    var objInsertUser = new InsertUser();
                    objInsertUser.EnterUserDetails(user);


                    Console.WriteLine("would you like to add your physical address: Y/N");
                    string value = Console.ReadLine(); 
                    string lower = value.ToLower();
                    if (lower == "y") 
                    {
                        var objaddressOption = new InsertPhysical();
                        objaddressOption.EnterPhysicalAddressDetails(physical);
                    }
                    else if (lower=="n")
                    {
                        Console.WriteLine("Thank you");
                    }
                    break;

                case 2:
                    var objUpdateUser = new UpdateUser();
                    objUpdateUser.EnterUpdateUserDetails(user);
                    break;

                case 3:
                    var objInsertPhysical = new InsertPhysical();
                    objInsertPhysical.EnterPhysicalAddressDetails(physical);
                    break;
                case 4:
                    var objUpdatePhysical = new UpdatePhysical();
                    objUpdatePhysical.EnterPhysicalUpdateDetails(physical);
                    break;

                case 5:
                    var objInsertPostal = new InsertPostal();
                    objInsertPostal.EnterPostalAddressDetails(postal);
                    break;
                case 6:
                    var objUpdatePostal = new UpdatePostal();
                    objUpdatePostal.EnterPostalUpdateDetails(postal);
                    break;
                case 7:
                    var objUpdateApprovalStatus = new UpdateApprovalStatus();
                    objUpdateApprovalStatus.EnterUpdateStatus();
                    break;
                case 8:
                    var objSoftDeleteUser = new DeleteUser();
                    objSoftDeleteUser.UserIdToDelete();

                    break;
                default:
                    Console.WriteLine("Opps! Invalid option entered. Retry");
                    Console.ReadKey();



                    break;
            }

        }



    }
}

