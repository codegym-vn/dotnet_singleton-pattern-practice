namespace Practice_Singleton
{
    public class BookBorrower
    {
        private BookSingleton BorrowedBook;
        private bool HaveBook = false;

        public void BorrowBook()
        {
            BorrowedBook = BookSingleton.BorrowBook();
            HaveBook = BorrowedBook == null ? false : true;
        }

        public string GetAuthorAndTitle()
        {
            if(HaveBook)
            {
                return BorrowedBook.GetAuthorAndTitle();
            }
            return "I dont have the book";
        }

        public void ReturnBook()
        {
            BorrowedBook.ReturnBook(BorrowedBook);
        }
    }
}