namespace BookStore.API.Contracts
{
    public record BooksRequest(
        string Title,
        string Descriptions,
        decimal Price);
}
