using System;

namespace deel1_uml
{
    public class Book
    {
        // define member variables
        private string name;
        public Author author; // get an instance of Author (object)
        private double price;
        private int qtyInStock = 0;

        // constructor
        public Book(string name, Author author, double price, int qtyInStock = 0)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qtyInStock = qtyInStock;
        }

        public string getName()
        {
            return name;
        }

        public Author getAuthor()
        {
            return author;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQtyInStock()
        {
            return qtyInStock;
        }

        public void setQtyInStock(int qtyInStock)
        {
            this.qtyInStock = qtyInStock;
        }

        public void print()
        {
            Console.Write("{0} is the author of {1}", author, name);
        }
        public string getAuthorName()
        {
            return author.getName();
        }
    }
}