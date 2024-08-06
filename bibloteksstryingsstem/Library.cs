namespace Librarysys;


public class Library {
    public List<Book> Books { get; private set;}
    public List<User> Users { get; private set;}

    public Library() {
        Books = new List<Book>();
        Users = new List<User>();
    }

    public void AddBook(Book book) {
        Books.Add(book);
        Console.WriteLine($"{book.Title} added to library");
    }

    public void RemoveBook(Book book) { 
        if (Books.Remove(book)) {
        Console.WriteLine($"{book.Title} removed from library");
        } else {
            Console.WriteLine($"{book.Title} not found in library");
        }
    }

    public void RegisterUser(User user) {
        Users.Add(user);
        Console.WriteLine($"{user.Name} registered");
    }

    public void DisplayAllBooks() {

        Console.WriteLine("All books in library");

        foreach (var book in Books){
            book.DisplayInfo();
        }
    }

    public void DisplayAvailableBooks() {

        Console.WriteLine("All available books in library");

        foreach (var book in Books) {
            if (book.IsAvailable) {
                book.DisplayInfo();
            }
        }

    }

    public Book FindBookByISBN(string isbn) {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }

}