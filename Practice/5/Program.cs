using System.Diagnostics.Tracing;

public class Book {
    private string Author;
    private string Title;
    private int Published;
    private bool[] Given;

    public Book(string Author, string Title, int Published, bool[] Given) {
        this.Author = Author;
        this.Title = Title;
        this.Published = Published;
        this.Given = Given;
    }

    public Book isAuthor(Book[] books, string author) {
        List<Book> out_books = new List<Book>();
        foreach (Book book in books) {
            if (book.Author == author) {
                return book;
            }
        }
    }
}

static class Program {
    static void Main() {
        bool[] year = new bool[]{
            true, true, false, false, 
            true, true, false, false, 
            true, true, false, false
        };
        Book[] books = new Book[]{new Book("Oleg", "Niga", 2000, year),
                                  new Book("Oleg", "Kniga", 2001, year),
                                  new Book("Vasa", "Nigga", 2001, year),
                                  new Book("Vasa", "Knigga", 2000, year),
                                  };
        Book book = new Book("Oleg", "Niga", 2000, year);
        foreach (Book booke in book.isAuthor(books, "Oleg")) {
            Console.WriteLine(booke)
        }
    }
}