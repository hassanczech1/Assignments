using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BorrowingSystem
    {
        private Dictionary<Member, List<Book>> borrowedBooks = new Dictionary<Member, List<Book>>();

        public void BorrowBook(Member member, Book book)
        {
            if (!borrowedBooks.ContainsKey(member))
            {
                borrowedBooks[member] = new List<Book>();
            }
            borrowedBooks[member].Add(book);
            book.NumOfCopies--;
        }

        public void ReturnBook(Member member, Book book)
        {
            if (borrowedBooks.ContainsKey(member) && borrowedBooks[member].Contains(book))
            {
                borrowedBooks[member].Remove(book);
                book.NumOfCopies++;
            }
        }
        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("Members and their borrowed books:");
            foreach (var entry in borrowedBooks)
           
            {
               
                Console.WriteLine($"{entry.Key.Name} (ID: {entry.Key.MemberID}) has borrowed:");

                foreach (var book in entry.Value)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author} current copies {book.NumOfCopies}");
                }
                Console.WriteLine(); 
            }
        }
    }
}

