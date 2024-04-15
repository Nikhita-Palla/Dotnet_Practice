using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Database_Connectivity_Category
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            string categoryName = null;
            string categoryDescription=null;

            int CategoryId = 0;
            
            do
            {
                Console.WriteLine("1. Insert Category");
                Console.WriteLine("2. Insert Category (Stored Procedure)");
                Console.WriteLine("3. Read Categories (Connected)");
                Console.WriteLine("4. Read Categories (Disconnected)");
                Console.WriteLine("5. Read Categories (Connected - Stored Procedure)");
                Console.WriteLine("6. Read Categories (Disconnected - Stored Procedure)");
                Console.WriteLine("7. Update Category");
                Console.WriteLine("8. Update Category (Stored Procedure)");
                Console.WriteLine("9. Delete Category (Stored Procedure)");
                Console.WriteLine("10. Delete Category ");
                Console.WriteLine("11. Get Category Count");
                Console.WriteLine("12. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if(choice==1 || choice== 2)
                    {
                        Console.WriteLine("Enter the name of the category:");
                        categoryName = Console.ReadLine();
                        Console.WriteLine("Enter the description of the category:");
                        categoryDescription = Console.ReadLine();

                    }
                    if(choice==7 || choice== 8)
                    {
                        Console.WriteLine("Enter the id of the category:");
                        if(int.TryParse(Console.ReadLine(),out CategoryId))
                        {
                            int[] outArray = GetIdCategoryTable.getIdCategoryTable();
                            if (!(outArray.Contains(CategoryId)))
                            {
                                Console.WriteLine("The entered Id is not there in the table");
                            }
                            else
                            {
                                Console.WriteLine("Enter the new description of the category to be updated:");
                                categoryDescription = Console.ReadLine();
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Enter valid ID");
                        }
                        
                        
                    }
                    if (choice == 9 || choice == 10)
                    {
                        Console.WriteLine("Enter the id of the category to delete:");
                        if (int.TryParse(Console.ReadLine(), out CategoryId))
                        {
                            int[] outArray = GetIdCategoryTable.getIdCategoryTable();
                            if (!(outArray.Contains(CategoryId)))
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
                            
                            Insert_query.insert_query(categoryName, categoryDescription);
                            break;
                        case 2:
                            
                            Insert_query.insert_query_SP(categoryName, categoryDescription);
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
                            Update_query.update_query(CategoryId,categoryDescription);
                            break;
                        case 8:
                            Update_query.update_query_SP(CategoryId, categoryDescription);
                            break;
                        case 9:
                            Delete_query.delete_query_SP(CategoryId);
                            break;
                        case 10:
                            Delete_query.delete_query(CategoryId);
                            break;
                        case 11:
                            CategoryCount.getCategoryCount();
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
