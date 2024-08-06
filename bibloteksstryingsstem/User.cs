namespace Librarysys;


public class User {
    public string Name { get; private set;}
    public string UserId { get; private set;}
    public List<Book> BorrowedBooks { get; private set;}

    public User(string name, string userId) {

        Name = name;
        UserId = userId;
        BorrowedBooks = new List<Book>();

    }

    public virtual void BorrowBook(Book book) {

        if (book.IsAvailable) {
            book.Borrow();
            BorrowedBooks.Add(book);
            Console.WriteLine($"{Name} borrowed {book.Title}");
        } else {
            Console.WriteLine($"{book.Title} is not avaiable");
        }
    }

    public void ReturnBook(Book book) {
        if (BorrowedBooks.Contains(book)){
            book.Return();
            BorrowedBooks.Remove(book);
            Console.WriteLine($"{Name} returned {book.Title}");
        } else {
            Console.WriteLine($"{Name} does not have {book.Title}");
        }
    }

    public void DisplayBorrowedBooks() {

        Console.WriteLine($"{Name}'s Borrowed Books:");
        foreach (var book in BorrowedBooks) {
            Console.WriteLine($"- {book.Title}");
        }
    }
}