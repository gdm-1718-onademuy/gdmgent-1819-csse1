using System;

namespace deel1_uml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UML | Books Database");

            // CREATE AUTHOR INSTANCE (OBJECT)
            Author johnDoe = new Author("John Doe", "john.doe@mail.com", 'm');

            // CALL METHODS FROM AUTHOR (+LOG TO CONSOLE)
            Console.WriteLine("Variables - Author");
            johnDoe.print(); // logs all author info to console
            Console.WriteLine("* The author's name is: {0}", johnDoe.getName());
            Console.WriteLine("* The author's email is: {0}", johnDoe.getEmail());
            Console.WriteLine("* The author's gender is: {0}", johnDoe.getGender());
            Console.WriteLine("");

            // CREATE BOOK INSTANCE (OBJECT)
            Book testBook = new Book("John's Book", johnDoe, 15, 5);

            // CALL METHODS FROM BOOK
            string testBookAuthorName = testBook.getAuthorName();
            //store email - get Author object and then call getEmail() method from Author object
            string testBookAuthorEmail = testBook.getAuthor().getEmail();
            // store the quantity of books in stock
            int testBookQtyInStock = testBook.getQtyInStock();
            // update quantity of books in stock to 17
            testBook.setQtyInStock(17);
            // store updated quantity
            testBookQtyInStock = testBook.getQtyInStock();

            // LOG INFO STORED FROM BOOK METHODS
            Console.WriteLine("Variables - Book");
            Console.WriteLine("* The book's author is {0}", testBookAuthorName);
            Console.WriteLine("* The email of the author of this book is {0}", testBookAuthorEmail);
            Console.WriteLine("* We have {0} copies of this book in stock", testBookQtyInStock); // logs last updated quality
        }
    }
}
