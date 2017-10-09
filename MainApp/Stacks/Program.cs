using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new Stack<string>();
            bookShelf.Push("book1");
            bookShelf.Push("book2");
            bookShelf.Push("book3");
            bookShelf.Push("book4");
            bookShelf.Push("book5");

            Console.WriteLine("ALL BOOKS: ");
            foreach (var book in bookShelf)
            {
                Console.WriteLine(book);
            }

            string topBook = bookShelf.Pop();
            Console.WriteLine("\ntop book from the pop: " + topBook);
            Console.WriteLine("top book: " + topBook);
            Console.WriteLine("book shelf after the pop:");
            foreach (var book in bookShelf)
            { 
                Console.WriteLine(book);
            }

            string nextTop = bookShelf.Peek();
            Console.WriteLine("\ntop book from the peek: " + nextTop);
            Console.WriteLine("book shelf after the peek:");
            foreach (var book in bookShelf)
            {
                Console.WriteLine(book);
            }
        }
    }
}
