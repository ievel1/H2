namespace Librarysys;


public class PremiumUser : User 
{
    public PremiumUser(string name, string userId) : base(name, userId) {}

    public override void BorrowBook(Book book) {
        
        if (BorrowedBooks.Count < 5 && book.IsAvailable) {

            base.BorrowBook(book);

        } else {

            Console.WriteLine($"Premium limit reached or {book.Title} is not available");
        }
    }
}