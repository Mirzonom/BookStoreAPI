namespace BookStore.API.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public string Category { get; set; }
    public List<string> Authors { get; set; }
}