using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Year})";
    }
}

class HomeLibrary
{
    private List<Book> library;

    public HomeLibrary()
    {
        library = new List<Book>();
    }

    public void AddBook(string title, string author, int year)
    {
        library.Add(new Book { Title = title, Author = author, Year = year });
    }

    public void RemoveBook(string title)
    {
        Book bookToRemove = library.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bookToRemove != null)
        {
            library.Remove(bookToRemove);
            Console.WriteLine($"Book '{title}' has been removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        return library.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> FindBooksByYear(int year)
    {
        return library.Where(book => book.Year == year).ToList();
    }

    public void SortByTitle()
    {
        library.Sort((book1, book2) => string.Compare(book1.Title, book2.Title, StringComparison.OrdinalIgnoreCase));
    }

    public void SortByAuthor()
    {
        library.Sort((book1, book2) => string.Compare(book1.Author, book2.Author, StringComparison.OrdinalIgnoreCase));
    }

    public void DisplayLibrary()
    {
        Console.WriteLine("Books in the library:");
        foreach (Book book in library)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {
        HomeLibrary library = new HomeLibrary();

        library.AddBook("Горе от ума", "Пушкин", 1880);
        library.AddBook("У лукоморья дуб зеленый", "Пушкин", 1879);
        library.AddBook("Путь Абая", "Мухтар Ауезов", 1900);

        library.DisplayLibrary();

        string authorToFind = "Пушкин";
        List<Book> booksByAuthor = library.FindBooksByAuthor(authorToFind);
        Console.WriteLine($"\nBooks by {authorToFind}:");
        foreach (Book book in booksByAuthor)
        {
            Console.WriteLine(book);
        }

        library.SortByTitle();
        Console.WriteLine("\nLibrary sorted by title:");
        library.DisplayLibrary();

        string bookTitleToRemove = "1879";
        library.RemoveBook(bookTitleToRemove);

        Console.WriteLine("\nUpdated library after book removal:");
        library.DisplayLibrary();

        Console.ReadLine();
    }
}
