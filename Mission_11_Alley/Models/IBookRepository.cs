namespace Mission_11_Alley.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
