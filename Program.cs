using System;

namespace IntNode_and_stuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntNodeFunc a = new IntNodeFunc(1);
            IntNodeFunc b = new IntNodeFunc(3, a);
            IntNodeFunc n = new IntNodeFunc(5, b);

            n.RemoveByIndex(0);
            Console.WriteLine(n.ToString());
        }
    }
}
