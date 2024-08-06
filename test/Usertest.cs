using Librarysys;

namespace test;

public class UserTest
{
    [Fact]
    public void TestBookCreate()
    {
        var user = new User ("Jens Jensen", "U001");
        Assert.Equal("Jens Jensen", user.Name);
        Assert.Equal("U001", user.UserId);
        Assert.Empty(user.BorrowedBooks);
    }

    [Fact]
    public void TestBorrowBook()
    {
        var book = new Book("book 10", "George", "9876534210");
        var user = new User("Emma", "U005");

        user.BorrowBook(book);
        Assert.Contains(book, user.BorrowedBooks);
        Assert.False(book.IsAvailable);
    }

    [Fact]
    public void TestReturnBook()
    {
        var book = new Book("book 10", "George", "9876534210");
        var user = new User("Emma", "U005");

        user.BorrowBook(book);
        user.ReturnBook(book);
        Assert.Empty(user.BorrowedBooks);
        Assert.True(book.IsAvailable);
    }
}