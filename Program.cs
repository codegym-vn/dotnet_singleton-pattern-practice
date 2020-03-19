using System;

namespace Practice_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Testing Singleton Pattern");
            Console.WriteLine("-------------------------------------------");
            BookBorrower borrower1 = new BookBorrower();
            BookBorrower borrower2 = new BookBorrower();
            borrower1.BorrowBook();
            Console.WriteLine("Book Borrower 1 asked to borrow the book");
            Console.WriteLine("Book borrower 1 Borrowed the book: " + borrower1.GetAuthorAndTitle());

            borrower2.BorrowBook();
            Console.WriteLine("Book Borrower 2 asked to borrow the book");
            Console.WriteLine("Book borrower 2 Borrowed the book: " + borrower2.GetAuthorAndTitle());

            borrower1.ReturnBook();
            Console.WriteLine("Borrower 1 returned the book");
            borrower2.BorrowBook();
            Console.WriteLine("Book Borrower 2 asked to borrow the book");
            Console.WriteLine("Book borrower 2 Borrowed the book: " + borrower2.GetAuthorAndTitle());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("End Testing Singleton Pattern");
        }
    }
}
