using EF_Test2.Repository;
using Models;
using System.Diagnostics;

Context context = new();

AuthorRepository authorRepository = new(context);
//authorRepository.Add(new Author { Name = "Stephen", Surname = "King" });

// add random data
/*authorRepository.AddRange
(
	[
		new Author
		{
			Name = "Stephen",
			Surname = "King",
			Books = new List<Book>
			{
				new Book { Title = "It" },
				new Book { Title = "The Shining" }
			}
		},
		new Author
		{
			Name = "George",
			Surname = "Orwell",
			Books = new List<Book>
			{
				new Book { Title = "1984" },
				new Book { Title = "Animal Farm" }
			}
		},
		new Author
		{
			Name = "J.R.R.",
			Surname = "Tolkien",
			Books = new List<Book>
			{
				new Book { Title = "The Hobbit" },
				new Book { Title = "The Lord of the Rings" }
			}
		}
	]
);*/
/*
for (int i = 0; i < 100; i++)
{
	authorRepository.Add(new Author
	{
		Name = Path.GetRandomFileName().Split('.')[0],
		Surname = Path.GetRandomFileName().Split('.')[0],
		Books = Enumerable.Range(0, Random.Shared.Next(2, 20))
		.Select(x => new Book { Title = Path.GetRandomFileName().Split('.')[0] }).ToList()
	});
}*/

// get all authors

var all = authorRepository.GetAllWithBooksAndBooksAuthorsWhoWroteLessThan(3);
foreach (var author in all)
{
	Console.WriteLine($"{author.Name} {author.Surname}");

	if (author.Books is not null)
		foreach (var book in author.Books)
		{
			Console.WriteLine($"\t{book.Title}");
		}
}