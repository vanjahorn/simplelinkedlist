namespace simplelinkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList<int> minLista = new SimpleLinkedList<int>();
            minLista.AddFirst(8643);
            minLista.AddFirst(3534);
            minLista.AddFirst(6544);
            // skriver ut "count: 3"
            Console.WriteLine("count: " + minLista.Count());
            minLista.Clear();
            Console.WriteLine("count: " + minLista.Count());

            SimpleLinkedList<double> minfulaLista = new SimpleLinkedList<double>();
            minfulaLista.AddFirst(0.12);
            minfulaLista.AddFirst(0.34);
            minfulaLista.AddFirst(0.56);
            // skriver ut "index 1: 0.34"
            Console.WriteLine("index 1: " + minfulaLista.ElementAt(1));

        }
    }
}
