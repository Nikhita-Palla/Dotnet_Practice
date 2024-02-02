class Program
{

    static void ienumerable_less3(IEnumerable<int> ienumerable)
    {
        foreach(int x in ienumerable)
        {
            if (x < 2)
            {
                Console.WriteLine(x);
            }
            else
            {
                ienumerable_greater3(ienumerable);
            }
        }
    }
    static void ienumerable_greater3(IEnumerable<int> ienumerable)
    {
        foreach (int x in ienumerable)
        {
            Console.WriteLine(x);
        }
    }

    static void ienumerator_less3(IEnumerator<int> ienumerator)
    {
        while (ienumerator.MoveNext())
        {

            if (ienumerator.Current > 2)
            {
                Console.WriteLine();
                Console.WriteLine();
                ienumerator_greater3(ienumerator);

            }
            else
            {
                Console.WriteLine(ienumerator.Current.ToString());
            }

        }
    }

    static void ienumerator_greater3(IEnumerator<int> ienumerator)
    {

        if (ienumerator.Current > 2)
        {
            Console.WriteLine(ienumerator.Current);
        }
        while (ienumerator.MoveNext())
        {
            Console.WriteLine(ienumerator.Current.ToString());

        }
    }

    public static void Main(String[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        IEnumerable<int> ienumerable=(IEnumerable<int>)list;

        foreach(int i in ienumerable)
        {
            Console.WriteLine(i);
        }
        
        IEnumerator<int> ienumerator=list.GetEnumerator();
        
        while(ienumerator.MoveNext())
        {
            Console.WriteLine(ienumerator.Current);
        }
        ienumerator.Reset();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Program p=new Program();

        Console.WriteLine("IEnnumerator.........");
        ienumerator_less3( ienumerator);
        /*ienumerator_greater3(ienumerator);*/

        Console.WriteLine("IEnnumerable.........");
        ienumerable_less3(ienumerable);
        

        

    }
}