using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal  class BookManagement
    {
        public List<Book> books = new List<Book>();
        public  void AddBook(Book book)
        { 
            books.Add(book);
        }
        public void RemoveBook(Book book) { 
            books.Remove(book);
        }
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}, Copies: {book.NumOfCopies}");
            }
        }
        
    }
}
