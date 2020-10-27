using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# collections");
            doListDemo();
            doStackDemo();
            doDictionaryDemo();
            doQueueDemo();
            doSetDemo();
        }
        private static void doSetDemo()
        {
            Console.WriteLine("In to do set demo");
            //Creating set
            var set = new HashSet<string>();
            //Adding elements in set
            set.Add("Siddhi");
            set.Add("Ravi");
            set.Add("Mohan");
            set.Add("Ravi");
            set.Add("Shaily");
            //Displaying elements in set
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("In to do Queue demo");
            //Creating queue
            Queue<string> queue = new Queue<string>();
            //Adding elements in queue
            queue.Enqueue("Siddhi");
            queue.Enqueue("Nidhi");
            queue.Enqueue("Shaily");
            Console.WriteLine("Head : " + queue.Peek());
            Console.WriteLine("Iterating the element");
            //Displaying elements in dictionary
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("dequeue element :" + dequeue);
            Console.WriteLine("Iterating the queue elements after dequeue one element");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("In to do dictionary demo");
            //Creating dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //Adding elements in dictionary
            dictionary.Add(100, "Siddhi");
            dictionary.Add(101, "Shaily");
            dictionary.Add(102, "Nidhi");
            //Access using key
            Console.WriteLine("Access element at key 100 " + dictionary[100]);
            //Displaying elements in dictionary
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key : " + element.Key + " Element : " + element.Value);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("In to do stack demo");
            //Creating stack
            Stack<string> stack = new Stack<string>();
            //Adding elements in stack
            stack.Push("Siddhi");
            stack.Push("Ravi");
            stack.Push("Ajay");
            stack.Push("Nidhi");
            stack.Push("Shaily");
            //Displaying elements in stack
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            //Popping element
            string k = stack.Pop();
            Console.WriteLine("Popping element : " + k);
        }
        private static void doListDemo()
        {
            Console.WriteLine("In to do list demo");
            //Creating list
            List<string> list = new List<string>();
            //Adding elements in list
            list.Add("Siddhi");
            list.Add("Ravi");
            list.Add("Mohan");
            list.Add("Nidhi");
            list.Add("Shaily");
            //Displaying elements in list
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
