class Program
{
    public static void Main(String[] args)
    {
        int[] numbers=new int[10] {1,2,3,4,5,6,7,8,9,10};
        
        //Iterating over array
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }

        //Changing a particular value at index
        numbers[2] = 8;


        //reversing array
        Array.Sort(numbers);
        Console.WriteLine("After Reversing");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        //sorting
        Array.Sort(numbers);
        Console.WriteLine("After Sorting");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Array.Clear(numbers, 1, 3); // Clears elements from index 1 to 3
        Console.WriteLine("After clearing....");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        int index = Array.IndexOf(numbers, 1); // Returns the index of value 1(index 0), if the value is not there returns -1
        Console.WriteLine(index);

        Console.WriteLine("resizing the array to five elements");
        Array.Resize(ref numbers, 5); // Resizes the array to have 5 elements
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        /*
                Console.WriteLine("resizing the array to fifteen elements");
                Array.Resize(ref numbers, 15); // Resizes the array to have 5 elements
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }*/
        Console.ReadLine();


    }
}