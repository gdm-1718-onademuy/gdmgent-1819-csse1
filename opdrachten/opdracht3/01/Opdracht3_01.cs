using System;
using System.Collections.Generic;

namespace opdracht3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,double> productList = new SortedList<string,double>();
            productList.Add("Cola 25cl", 1);
            productList.Add("Cola 33cl", 1.5);
            productList.Add("Witte wijn", 2);
            productList.Add("Pils", 3);
            productList.Add("Toast", 5);
            productList.Add("Kaasplank", 4);
            
            foreach(KeyValuePair<string,double> product in productList )
            {
                Console.WriteLine("product: {0}, price: {1}", product.Key , product.Value );
            }
            
            if(productList.ContainsKey("Cola 25cl")) 
            {
                Console.WriteLine("The item you requested is available");
            }
        }
    }
}