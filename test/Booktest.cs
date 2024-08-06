using Librarysys;

namespace test;

public class BookTest
{
    [Fact]
    public void TestBookCreate()
    {
        var book = new Book("Harry Potter and the Goblet of Fire", "J. K. Rowling", "1234567890");
        Assert.Equal("Harry Potter and the Goblet of Fire", book.Title);
        Assert.Equal("J. K. Rowling", book.Author);
        Assert.Equal("1234567890", book.ISBN);
        Assert.True(book.IsAvailable);
    }

    [Fact]

    public void TestBorrowBook() {

        var book = new Book("Peter Nysgerrig", "H.A. Rey", "9876543210");
        book.Borrow();
        Assert.False(book.IsAvailable);
    }

    [Fact]
    public void TestReturnBook() {

        var book = new Book("The Two Towers", "J.R.R. Tolkien", "9856543210");

        book.Borrow();
        book.Return();
        Assert.True(book.IsAvailable);

    }
}