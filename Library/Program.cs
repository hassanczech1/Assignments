using System;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Book
            Book book1 = new Book(20, "SpiderMan", "Ahmed");
            Book book2 = new Book(21, "BatMan", "Hassan");

            BookManagement bookManagement = new BookManagement();

            bookManagement.AddBook(book1);
            bookManagement.AddBook(book2);

            Console.WriteLine("Books in the library:");
            bookManagement.DisplayBooks();
            #endregion

            Member member1 = new Member(1, "Body");
            Member member2 = new Member(2, "Mohamed");

            MemberManagement memberManagement = new MemberManagement();

            memberManagement.RegisterMember(member1);
            memberManagement.RegisterMember(member2);
            Console.WriteLine("Members in the library:");
            memberManagement.DisplayMembers();

            BorrowingSystem borrowingSystem = new BorrowingSystem();
            borrowingSystem.BorrowBook(member2, book1);
            borrowingSystem.BorrowBook(member2, book2);
            borrowingSystem.DisplayBorrowedBooks();
            borrowingSystem.ReturnBook(member2,book1);
            borrowingSystem.DisplayBorrowedBooks();






        }
    }
}
