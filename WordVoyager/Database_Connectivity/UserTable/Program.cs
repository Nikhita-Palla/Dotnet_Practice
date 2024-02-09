using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string UserName = null;
            string Email=null;
            string PasswordHash=null;
            int UserId = 0;
            DateTime date = DateTime.MinValue;
            do
            {
                Console.WriteLine("1. Insert User");
                Console.WriteLine("2. Insert User (Stored Procedure)");
                Console.WriteLine("3. Read Users (Connected)");
                Console.WriteLine("4. Read Users (Disconnected)");
                Console.WriteLine("5. Read Users (Connected - Stored Procedure)");
                Console.WriteLine("6. Read Users (Disconnected - Stored Procedure)");
                Console.WriteLine("7. Update User");
                Console.WriteLine("8. Update User (Stored Procedure)");
                Console.WriteLine("9. Delete User (Stored Procedure)");
                Console.WriteLine("10. Delete User ");
                Console.WriteLine("11. Get User Count");
                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                int choice;


                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1 || choice == 2)
                    {
                        Console.WriteLine("Enter the user name:");
                        UserName = Console.ReadLine();
                        Console.WriteLine("Enter the email");
                        Email = Console.ReadLine();
                        Console.WriteLine("Enter the PasswordHash");
                        PasswordHash = Console.ReadLine();
                        date = DateTime.Now;

                    }
                    if (choice == 7 || choice == 8)
                    {
                        Console.WriteLine("Enter the userid ");
                        if (int.TryParse(Console.ReadLine(), out UserId))
                        {
                            int[] outArray = GetIdUserTable.getIdUserTable();
                            if (!(outArray.Contains(UserId)))
                            {
                                Console.WriteLine("The entered Id is not there in the table");
                            }
                            else
                            {
                                
                                Console.WriteLine("Enter the PasswordHash");
                                PasswordHash = Console.ReadLine();
                                date = DateTime.Now;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Enter valid ID");
                        }


                    }
                    if (choice == 9 || choice == 10)
                    {
                        Console.WriteLine("Enter the id of the user to delete:");
                        if (int.TryParse(Console.ReadLine(), out UserId))
                        {
                            int[] outArray = GetIdUserTable.getIdUserTable();
                            if (!(outArray.Contains(UserId)))
                            {
                                Console.WriteLine("The entered Id is not there in the table");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Enter valid ID");
                        }


                    }
                    switch (choice)
                    {
                        case 1:

                            Insert_query.insert_query(UserName, Email, PasswordHash, date);
                            break;
                        case 2:

                            Insert_query.insert_query_SP(UserName, Email, PasswordHash, date);
                            break;
                        case 3:
                            Read_query.read_query_connected();
                            break;
                        case 4:
                            Read_query.read_query_disconnected();
                            break;
                        case 5:
                            Read_query.read_query_connected_SP();
                            break;
                        case 6:
                            Read_query.read_query_disconnected_SP();
                            break;
                        case 7:
                            Update_query.update_query(UserId, PasswordHash);
                            break;
                        case 8:
                            Update_query.update_query_SP(UserId, PasswordHash);
                            break;
                        case 9:
                            Delete_query.delete_query_SP(UserId);
                            break;
                        case 10:
                            Delete_query.delete_query(UserId);
                            break;
                        case 11:
                            UserCount.getUserCount();
                            break;
                        case 12:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please enter a number between 1 and 11.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter a valid number.");
                }

                Console.WriteLine();
            } while (!exit);


        }
    }
}
