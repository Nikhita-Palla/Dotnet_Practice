class Program
{
  
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
        

    }
}