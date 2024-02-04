using System.Collections;

class Program
{
    static void Main(String[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "a");
        hashtable.Add(2, "b");
        hashtable.Add(3, "c");

        Console.WriteLine(hashtable[1].GetHashCode());
        Console.WriteLine(hashtable[2].GetHashCode());
        Console.WriteLine(hashtable[3].GetHashCode());

        Console.WriteLine("Keys in the HashTable");
        foreach(var i in hashtable.Keys)
        {
           Console.Write(i+" ");
        }
        Console.WriteLine();

        Console.WriteLine("Values in the HashTable");
        foreach (var i in hashtable.Values)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Getting both key and value pair");

        foreach(DictionaryEntry ele in hashtable)
        {
            Console.WriteLine($"Key:{ele.Key} , Value:{ele.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Checking a Key is present in the hashtable or not" + hashtable.ContainsKey(3));
        Console.WriteLine();

        Console.WriteLine("Checking a Value is present in the hashtable or not" + hashtable.ContainsValue('b'));
        Console.WriteLine();

        Console.WriteLine("Removing an element using Key:key->1");
        Console.WriteLine();
        hashtable.Remove(1);
        Console.WriteLine("Getting both key and value pair after removing key 1 from the hashtable");

        foreach (DictionaryEntry ele in hashtable)
        {
            Console.WriteLine($"Key:{ele.Key} , Value:{ele.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Adding a new element to dictionary using item property");
        hashtable[1] = 'a';  // Will set the element at key-> 1 or adds a new value to hashtable with key and that value.

        foreach (DictionaryEntry ele in hashtable)
        {
            Console.WriteLine($"Key:{ele.Key} , Value:{ele.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Setting a new value(r) at key->2");
        hashtable[2] = 'r';
        foreach (DictionaryEntry ele in hashtable)
        {
            Console.WriteLine($"Key:{ele.Key} , Value:{ele.Value}");
        }
        Console.WriteLine();

        Console.WriteLine("Getting a value with key(at key->2) : " + hashtable[2]);

        Console.WriteLine();

        Console.WriteLine("Getting the number of key-value pairs in hashtable : " + hashtable.Count);

        Console.WriteLine();

        Console.WriteLine("Clearing the elements in the hashtable");
        hashtable.Clear();
        Console.WriteLine("Getting the number of key-value pairs in hashtable after clearing: " + hashtable.Count);

    }
}