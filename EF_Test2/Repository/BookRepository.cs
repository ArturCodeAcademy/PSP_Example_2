using Models;

namespace EF_Test2.Repository
{
	public class BookRepository
	{
		private readonly Context _context;

		public BookRepository(Context context)
		{
			_context = context;
		}

		public void Add(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();
		}

		public void AddRange(IEnumerable<Book> books)
		{
			_context.Books.AddRange(books);
			_context.SaveChanges();
		}

		public List<Book> GetAll()
		{
			return _context.Books.ToList();
		}

		public List<Book> GetBooks(int skip, int take)
		{
			return _context.Books.Skip(skip).Take(take).ToList();
		}

		public Book? GetById(int id)
		{
			return _context.Books.FirstOrDefault(x => x.Id == id);
		}

		public List<Book> GetBooksByAuthor(int authorId)
		{
			return _context.Books.Where(x => x.AuthorId == authorId).ToList();
		}

		public void Remove(int id)
		{
			var book = _context.Books.FirstOrDefault(x => x.Id == id);
			if (book is null)
				return;

			_context.Books.Remove(book);
			_context.SaveChanges();
		}
	}
}
