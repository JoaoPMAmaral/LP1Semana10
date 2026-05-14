using System;
using System.Collections.Generic;
using System.Linq;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>(){1,10,-30,10,-5};
            Stack<int> stack = new Stack<int>(new[]{1,10,-30,10,-5});
            Queue<int> queue = new Queue<int>(new[]{1,10,-30,10,-5});
            HashSet<int> hash = new HashSet<int>(){1,10,-30,10,-5};

            Console.Write("List: ");
            foreach(int number in list)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.Write("Stack: ");
            foreach(int number in stack)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.Write("Queue: ");
            foreach(int number in queue)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.Write("HashSet: ");
            foreach(int number in hash)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
