using Librarysys;

public class LibraryTests
{
    [Fact]
    public void TestAddAndRemoveBook()
    {
        var library = new Library();
        var book = new Book("The Hobbit", "J.R.R. Tolkien", "1234567850");

        library.AddBook(book);
        Assert.Contains(book, library.Books);

        library.RemoveBook(book);
        Assert.DoesNotContain(book, library.Books);
    }

    [Fact]
    public void TestRegisterUser()
    {
        var library = new Library();
        var user = new User("Konrad", "U006");

        library.RegisterUser(user);
        Assert.Contains(user, library.Users);
    }

    [Fact]
    public void TestDisplayAvailableBooks()
    {
        var library = new Library();
        var book1 = new Book("Book 1", "Author A", "111");
        var book2 = new Book("Book 2", "Author B", "222");
        var book3 = new Book("Book 3", "Author C", "333");
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        book2.Borrow(); // Book 2 is not available

        // Test that only available books are displayed
        var availableBooks = library.Books.Where(b => b.IsAvailable).ToList();
        Assert.Contains(book1, availableBooks);
        Assert.Contains(book3, availableBooks);
        Assert.DoesNotContain(book2, availableBooks);
    }
}
