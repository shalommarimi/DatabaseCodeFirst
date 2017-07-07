﻿using Operations.CRUD.PhysicalAddress;
using Operations.CRUD.PostalAddress;
using Operations.CRUD.User;
using System;


namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Menu \r\n  \r\n User Operations: \r\n 0. See Registered Users \r\n 1. Register User  \r\n 2. Update User  \r\n 3. Delete User \r\n");
            Console.WriteLine("Physical Address Operations: \r\n 4. Enter User Physical Address  \r\n 5. Update User Physical Address  \r\n 6. Delete Physical Address \r\n");
            Console.WriteLine("Postal Address Operations: \r\n 7. Enter User Postal Address  \r\n 8. Update User Postal Address  \r\n 9. Delete Postal Address \r\n");
            Console.WriteLine("User Approval Operations: \r\n 10. Press 1 to Approve User");
            Console.WriteLine("User Deletion Operations: \r\n 11. Press 1 to Delete User");


            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    var objSelectUser = new SelectUser();
                    objSelectUser.RetrieveUser();
                    break;
                case 1:
                    var objInsertUser = new InsertUser();
                    objInsertUser.EnterUserDetails();

                    Console.WriteLine("would you like to add your physical address: Y/N");
                    char value = Convert.ToChar(Console.ReadLine());
                    if (value == 'Y' || value == 'y')
                    {
                        var objaddressOption = new InsertPhysical();
                        objaddressOption.EnterPhysicalAddressDetails();
                    }
                    else if (value == 'N' || value == 'n')
                    {
                        Console.WriteLine("Thank you");
                    }
                    break;

                case 2:
                    var objUpdateUser = new UpdateUser();
                    objUpdateUser.EnterUpdateUserDetails();
                    break;
                case 3:
                    break;
                case 4:
                    var objInsertPhysical = new InsertPhysical();
                    objInsertPhysical.EnterPhysicalAddressDetails();
                    break;
                case 5:
                    var objUpdatePhysical = new UpdatePhysical();
                    objUpdatePhysical.EnterPhysicalUpdateDetails();
                    break;
                case 6:

                    break;
                case 7:
                    var objInsertPostal = new InsertPostal();
                    objInsertPostal.EnterPostalAddressDetails();
                    break;
                case 8:
                    var objUpdatePostal = new UpdatePostal();
                    objUpdatePostal.EnterPostalUpdateDetails();
                    break;
                case 10:
                    var objUpdateApprovalStatus = new UpdateApprovalStatus();
                    objUpdateApprovalStatus.EnterUpdateStatus();
                    break;
                case 11:
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

