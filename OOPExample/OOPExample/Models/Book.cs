namespace Example.Models;

public class Library
{
    public List<Book> Books = new List<Book>();
    private static int _id = 1;

    public void AddBook()
    {
        Book book = new Book();

        book.Id = _id;
        _id++;

        Console.WriteLine("enter book name:");
        book.Name = Console.ReadLine();

        Console.WriteLine("enter author name:");
        book.AuthorName = Console.ReadLine();

        Console.WriteLine("enter book page count:");
        book.PageCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter book price:");
        book.Price = Convert.ToDouble(Console.ReadLine());

        Books.Add(book);
    }

    public Book GetBookById(int id)
    {
        foreach (var book in Books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }

        return null;
    }

    public int FindAllBooks(string authorName)
    {
        int count = 0;
        foreach (var book in Books)
        {
            if (book.AuthorName == authorName)
            {
                count++;
            }
        }
        return count;
    }

    public List<Book> RemoveAllBooks(int code)
    {
        List<Book> RemovedBooks = new List<Book>();
        Book removedBook = GetBookById(code);
        RemovedBooks.Add(removedBook);
        Books.Remove(removedBook);

        return RemovedBooks;
    }
}

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public double Price { get; set; }
}

public class Order
{
    private static int _id { get; set; }
    public List<Book> Books { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }

    public void Satish(int id, Library lib)
    {
        foreach (var book in lib.Books)
        {
            if (book.Id == id)
            {
                Books.Add(book);
                Price += book.Price;
            }
            else
            {
                Console.WriteLine("book with ID {0} was not found.", id);
            }
        }

        _id++;
    }
}