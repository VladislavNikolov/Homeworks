namespace C.GenericList
{
    using System;

    public class GenericListMain
    {
        public static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(5);
            list.Add(7);
            list.Add(9);
            Console.WriteLine(list);
            list.Insert(6, 0);
            Console.WriteLine(list);
            list.Remove(5);
            Console.WriteLine(list);
            Console.WriteLine(list.IndexOf(4));
            Console.WriteLine(list.Contains(7));
            Console.WriteLine(list.Max<int>());
        }
    }
}
