using Microsoft.EntityFrameworkCore;

namespace Models
{
	[Index(nameof(Name), nameof(Surname))]
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public string Surname { get; set; } = default!;

		public virtual ICollection<Book> Books { get; set; } = default!;
	}
}
