using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class BookApp
    {
        public int bookId;
        public string title;
        public double price;
        public string bookType;

        public BookApp(int bookId, string title, double price, string bookType)
        {
            this.bookId = bookId;
            this.title = title;
            this.price = price;
            this.bookType = bookType;
        }

        public void display()
        {
            Console.WriteLine("Book Id is: " + bookId);
            Console.WriteLine("The title of the Book is: " + title);
            Console.WriteLine("Price of the Book is: " + price);
            Console.WriteLine("The Book Type is: " + bookType);

        }

        public static void Main()
        {
            BookApp b1 = new BookApp(20, "Game", 333, "Story Book");
            b1.display();
            Console.WriteLine();

            BookApp b2 = new BookApp(34, "Of", 123, "Novel");
            b1.display();
            Console.WriteLine();

            BookApp b3 = new BookApp(40, "Thrones", 245, "Book");
            b1.display();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
