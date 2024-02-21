using Microsoft.EntityFrameworkCore;
using Models;

namespace EF_Test2.Repository
{
	public class AuthorRepository
	{
		private readonly Context _context;

		public AuthorRepository(Context context)
		{
			_context = context;
		}

		public void Add(Author author)
		{
			_context.Authors.Add(author);
			_context.SaveChanges();
		}

		public void AddRange(IEnumerable<Author> authors)
		{
			_context.Authors.AddRange(authors);
			_context.SaveChanges();
		}

		public List<Author> GetAll()
		{
			return _context.Authors.ToList();
		}

		public List<Author> GetAllWithBooks()
		{
			return _context.Authors.Include(x => x.Books).ToList();
		}

		public List<Author> GetAllWithBooksAndBooksAuthorsWhoWroteMoreThan(int count)
		{
			return _context.Authors.Include(x => x.Books).Where(x => x.Books.Count() > count).ToList();
		}

		public List<Author> GetAllWithBooksAndBooksAuthorsWhoWroteLessThan(int count)
		{
			return _context.Authors.Include(x => x.Books).Where(x => x.Books.Count() < count).ToList();
		}

		public List<Author> GetAuthors(int skip, int take)
		{
			return _context.Authors.Skip(skip).Take(take).ToList();
		}

		public Author? GetById(int id)
		{
			return _context.Authors.FirstOrDefault(x => x.Id == id);
		}
	}
}
