namespace Mission_11_Alley.Models
{
    public class EBookRepository : IBookRepository
    {
        private BookContext _context;

        public EBookRepository(BookContext temp) 
        {
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
