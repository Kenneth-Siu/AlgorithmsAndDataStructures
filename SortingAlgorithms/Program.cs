namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();

            list.Add(value: 1);
            list.Add(value: 2);
            list.Add(value: 3);
            list.Add(value: 4);
            list.Add(value: 5);
            list.RemoveAt(index: 2);
            list.Insert(index: 1, value: 355);
            Console.WriteLine(list.Find(value: 1));
            Console.WriteLine(list.Find(value: 2));
            Console.WriteLine(list.Find(value: 3));
            Console.WriteLine(list.Find(value: 4));
            Console.WriteLine(list.Find(value: 5));
            Console.WriteLine(list.Find(value: 355));
            Console.WriteLine(list.Length());

            // thing.Insert(999, 1);
            // thing.RemoveAt(999);
        }
    }
}
