using Librarysys;

namespace test;

public class PremiumUserTest
{
    [Fact]
    public void TestPremiumUserNorrowLimit()
    {
        var premiumUser = new PremiumUser("William", "U001");
        var books = new List<Book> {
            new Book("Book nr. 1", "Author 1", "111"),
            new Book("Book nr. 2", "Author 2", "112"),
            new Book("Book nr. 3", "Author 3", "113"),
            new Book("Book nr. 4", "Author 4", "114"),
            new Book("Book nr. 5", "Author 5", "115"),
            new Book("Book nr. 6", "Author 6", "116")
        };

        foreach (var book in books.Take(5)) {
            premiumUser.BorrowBook(book);
        }

        Assert.Equal(5, premiumUser.BorrowedBooks.Count);
        Assert.False(books[4].IsAvailable);




        // borrowing the 6th book, which should fail
        premiumUser.BorrowBook(books[5]);
        Assert.Equal(5, premiumUser.BorrowedBooks.Count);
        Assert.True(books[5].IsAvailable);
    }
}