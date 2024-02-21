namespace Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; } = default!;
		public int AuthorId { get; set; }
		public virtual Author Author { get; set; } = default!;
	}
}
