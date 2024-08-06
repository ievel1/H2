
namespace Librarysys;

public class Book {

    public string Title { get; private set;}
    public string Author { get; private set;}
    public string ISBN { get; private set;}
    public bool IsAvailable { get; private set;}

    public Book(string title, string author, string isbn) {

        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = true;
    }
    public void DisplayInfo() {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available: {IsAvailable}");
    }

    public void Borrow() {
        IsAvailable = false;
    }

    public void Return() {
        IsAvailable = true;
    }
}
