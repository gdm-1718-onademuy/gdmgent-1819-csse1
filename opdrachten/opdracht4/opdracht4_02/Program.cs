using System;

namespace opdracht4_02
{
    public class Product
    {
        public string Name;
        public string Type;
        public Product(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
    class Price
    {
        public Price()
        {

        }
    }
    public class MenuItem
    {
        public string Name;
        public void getMenuItem(string name) 
        {
            Console.WriteLine(Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.Name = "Spaghetti";
            menuItem.getMenuItem("Spaghetti");
        }
    }
}
