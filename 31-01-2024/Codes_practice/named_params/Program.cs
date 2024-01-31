class Program
{
    static void DisplayPersonDetails(string firstName, string lastName, int age)
    {
        Console.WriteLine($"Name: {firstName} {lastName}, Age: {age}");
    }

    static void Main()
    {
        // Without named parameters
        DisplayPersonDetails("Palla", "Nikhita", 21);

        // With named parameters
        DisplayPersonDetails(firstName: "Deva", lastName: "Harshita", age: 24);



        // Parameters in a different order using named parameters
        DisplayPersonDetails(age: 40, lastName: "Lakshmi", firstName: "Vijaya");
    }
}
