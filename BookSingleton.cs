using System;

namespace Practice_Singleton
{
    class BookSingleton
    {
        private string Author {get;}
        private string Title {get;}
        private static BookSingleton Book;
        private static bool IsLoanedOut;

        private BookSingleton()
        {
            Author = "Gamma, Helm, Johnson and Vlissides";
            Title = "Design Patterns";
            Book = null;
            IsLoanedOut = false;
        }

        public string GetAuthorAndTitle()
        {
            return Title + " by " + Author;
        }

        public static BookSingleton BorrowBook()
        {
            if(!IsLoanedOut)
            {
                if(Book ==  null)
                {
                    Book = new BookSingleton();
                }
                IsLoanedOut = true;
                return Book;
            }
            return null;
        }

        public void ReturnBook(BookSingleton returnedBook)
        {
            IsLoanedOut = false;
        }
    }
}