using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a day number (1-7):");
        string userInput = Console.ReadLine();
        int dayNumber;

        if (userInput != null)
        {
            dayNumber = int.Parse(userInput);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        // Declaration and initialization of dayOfWeek
        string dayOfWeek = "";

        // Use a switch statement to determine the day of the week
        switch (dayNumber)
        {
            case 1:
                dayOfWeek = "Sunday";
                break;
            case 2:
                dayOfWeek = "Monday";
                break;
            case 3:
                dayOfWeek = "Tuesday";
                break;
            case 4:
                dayOfWeek = "Wednesday";
                break;
            case 5:
                dayOfWeek = "Thursday";
                break;
            case 6:
                dayOfWeek = "Friday";
                break;
            case 7:
                dayOfWeek = "Saturday";
                break;
            default:
                dayOfWeek = "Invalid day number";
                break;
        }

        Console.WriteLine($"The day of the week is: {dayOfWeek}");
    }
}
