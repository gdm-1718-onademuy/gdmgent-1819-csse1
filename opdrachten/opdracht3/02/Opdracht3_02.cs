using System;
using System.Collections;

namespace opdracht3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program productList = new Program();

            Queue orderQueue = new Queue();
            orderQueue.Enqueue("table1");
            orderQueue.Enqueue("table2");
            orderQueue.Enqueue("table3");
            orderQueue.Enqueue("table4");

            object[] orders;

            for(int i = 0; i < orderQueue.Count; i++) {
                Console.WriteLine(orderQueue.Dequeue());
                orders = orderQueue.ToArray();
                Console.WriteLine("Your Orders:");
                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                }
            }      
        }
    }
}