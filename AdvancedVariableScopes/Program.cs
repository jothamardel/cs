Book book1 = new Book("Harry Potter and the Sorcerer's Stone.", "J.K. Rowlings");

book1.Printsummary();
Console.WriteLine(book1.GetTitleLengthWithoutWhitespace());



public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Printsummary()
    {
        string summary = $"{Title} - {Author}";
        Console.WriteLine(summary);
    }

    public int GetTitleLengthWithoutWhitespace()
    {
        string titleWithoutWhitespaces = Title.Replace(" ", "");
        return titleWithoutWhitespaces.Length; 
    }
}